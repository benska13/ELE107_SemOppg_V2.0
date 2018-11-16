using System;
using LibaryPasient;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

// Fjerne socet class i egen libary

namespace Sentral2
{
    public delegate void Mdt(Pasient p);

    public partial class Sentral : Form
    {
        private readonly BindingList<ListPasient> _pasienter;
        private readonly BindingList<string> _aktivAlarm;

        private Socket _kommSokkel;
        private readonly Socket _lytteSokkel;

        private const string Filnavn = "PasienterFil.txt";

        private Mdt _minDelegate;

        public Sentral()
        {
            InitializeComponent();

            _pasienter = new BindingList<ListPasient> { };
            _aktivAlarm = new BindingList<string>();
            lbAktiveAlarmer.DataSource = _aktivAlarm;

            OppdaterLabelerGui();

            _lytteSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            _lytteSokkel.Bind(serverEp);
            _lytteSokkel.Listen(10);

            if (File.Exists(Filnavn))
            {
                try
                {
                    _pasienter = LesSkrivFil.LesFraFil(Filnavn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    File.Delete(Filnavn);
                }
            }

            listPasientBindingSource.DataSource = _pasienter;
            dgwPasienter.SelectAll();
            bgwVentPaKlient.RunWorkerAsync();

            ThreadPool.QueueUserWorkItem(SjekkTilkobling);
        }

        private void SjekkTilkobling(object state) // Sjekker igjennom alle pasienter, setter farge etter hvor lenge siden sist motatt data 
        {
            Thread.Sleep(3000);
            TimeSpan toSek = new TimeSpan(0, 0, 0, 20);
            TimeSpan tiSek = new TimeSpan(0, 0, 0, 10);
            while (true)                               // Ikke helt bra
            {
                DateTime tidNo = DateTime.Now;

                foreach (ListPasient p in _pasienter)
                {
                    TimeSpan differanse = tidNo - p.SisteMeldingMottatt;


                    if (differanse > toSek)
                    {
                        dgwPasienter.Rows[_pasienter.IndexOf(p)].DefaultCellStyle.BackColor = Color.Gray;
                    }
                    else if (differanse > tiSek)
                    {
                        dgwPasienter.Rows[_pasienter.IndexOf(p)].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {

                        dgwPasienter.Rows[_pasienter.IndexOf(p)].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        void PasientSjekk(Pasient n) // Sjekker om pasientens navn finnes fra før, da oppdatere den, ellers opprette ny
        {
            bool pasientFunnet = false;
            foreach (ListPasient p in _pasienter)
            {
                if (p.Navn == n.Navn)
                {
                    p.NyData(n);
                    pasientFunnet = true;
                    OppdaterVerdiGui(p);
                    p.SisteMeldingMottatt = DateTime.Now;

                    OppdaterAktivAlarmList(p);
                }
            }

            if (!pasientFunnet)
            {
                _pasienter.Insert(0, new ListPasient(n));
                OppdaterVerdiGui(_pasienter.First());
                OppdaterAktivAlarmList(_pasienter.First());
                _pasienter.First().SisteMeldingMottatt = DateTime.Now;
            }
        }

        private void OppdaterAktivAlarmList(ListPasient p)  // Lager en liste over alle pasienter som har en aktiv alarm
        {
            try
            {
                bool f = true;
                if (_aktivAlarm.Contains(p.Id + p.Navn))
                {
                    if (!p.ListAlarm.First().Alarmm)
                    {
                        _aktivAlarm.RemoveAt(_aktivAlarm.IndexOf(p.Id + p.Navn));
                    }
                }
                else
                {
                    if (p.ListAlarm.First().Alarmm)
                    {
                        _aktivAlarm.Add(p.Id + p.Navn);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void VentPaaData(object state) // Venter på data i den socketen som blir sendt inn
        {
            try
            {

                Socket kommSocket = (Socket)state;
                while (kommSocket.IsBound)         // usikker.. Ha en sjekk som ser at kobling er ok før den venter på data?
                {
                    string data = minSokkel.VentPaData(kommSocket);
                    Pasient p = Serialize.StringTPasient(data);

                    _minDelegate = new Mdt(PasientSjekk);
                    this.Invoke(_minDelegate, p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OppdaterLabelerGui()
        {
            // bx1= temp
            // bx2= puls
            // bx3= blod
            // bx4= resp
            Pasient p = new Pasient();
            gbxTemp.Text = p.Kroppstemperatur.ToString();
            gbxPuls.Text = p.Pulsfrekvens.ToString();
            gbxBlod.Text = p.Blodtrykk.ToString();
            gbxResp.Text = p.Respirasjonsrate.ToString();
            tpTemp.Text = p.Kroppstemperatur.ToString();
            tpAlarm.Text = p.Alarm.ToString();
            tpBlod.Text = p.Blodtrykk.ToString();
            tpPuls.Text = p.Pulsfrekvens.ToString();
            tpResp.Text = p.Respirasjonsrate.ToString();
        }

        public void OppdaterVerdiGui(ListPasient n) // Oppdaterer gui med de siste verdiene som kom ifra monitor
        {

            if (_pasienter[dgwPasienter.SelectedRows[0].Index] == n)
            {
                // bx1= temp
                // bx2= puls
                // bx3= blod
                // bx4= resp
                lblBx1Min.Text = "Min: " + n.ListKroppstemperatur.First().Min.ToString();
                lblBx1Max.Text = "Max: " + n.ListKroppstemperatur.First().Max.ToString();
                txtBx1Verdi.Text = n.ListKroppstemperatur.First().Verdi.ToString() +
                                   n.ListKroppstemperatur.First().Enhet;

                lblBx2Min.Text = "Min: " + n.ListPulsfrekvens.First().Min.ToString();
                lblBx2Max.Text = "Max: " + n.ListPulsfrekvens.First().Max.ToString();
                txtBx2Verdi.Text = n.ListPulsfrekvens.First().Verdi.ToString() + n.ListPulsfrekvens.First().Enhet;

                lblBx3Min.Text = "Min: " + n.ListBlodtrykk.First().Min.ToString();
                lblBx3Max.Text = "Max: " + n.ListBlodtrykk.First().Max.ToString();
                txtBx3Verdi1.Text = n.ListBlodtrykk.First().Verdi.ToString() + n.ListBlodtrykk.First().Enhet;
                txtBx3Verdi2.Text = n.ListBlodtrykk.First().Verdi2.ToString() + n.ListBlodtrykk.First().Enhet;

                lblBx4Min.Text = "Min: " + n.ListRespirasjonsrate.First().Min.ToString();
                lblBx4Max.Text = "Max: " + n.ListRespirasjonsrate.First().Max.ToString();
                txtBx4Verdi.Text = n.ListRespirasjonsrate.First().Verdi.ToString() +
                                   n.ListRespirasjonsrate.First().Enhet;
            }
            LesSkrivFil.SkrivTilFil(_pasienter, Filnavn);
        }

        private void gbxPuls_MouseCaptureChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpPuls;
        }

        private void gbxTemp_MouseCaptureChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpTemp;
        }

        private void gbxResp_MouseCaptureChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpResp;
        }

        private void gbxBlod_MouseCaptureChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpBlod;
        }

        private void bgwVentPaKlient_DoWork(object sender, DoWorkEventArgs e) // Venter på en ny monitor
        {
            _kommSokkel = minSokkel.VentPaaKlient(_lytteSokkel); // Blokerer, venter på klient
        }

        private void bgwVentPaKlient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(VentPaaData, _kommSokkel); // Starter en tråd som venter på data
            bgwVentPaKlient.RunWorkerAsync();
        }

        private void dgwPasienter_SelectionChanged_1(object sender, EventArgs e) // Viser data fra den pasienten som blir klikket på
        {
            if (dgwPasienter.SelectedRows.Count != 0)
            {
                int x = dgwPasienter.SelectedRows[0].Index;
                OppdaterVerdiGui(_pasienter[x]);
                listPulsfrekvensBindingSource.DataSource = _pasienter[x].ListPulsfrekvens;
                listKroppstemperaturBindingSource.DataSource = _pasienter[x].ListKroppstemperatur;
                listRespirasjonsrateBindingSource.DataSource = _pasienter[x].ListRespirasjonsrate;
                listBlodtrykkBindingSource.DataSource = _pasienter[x].ListBlodtrykk;
                listAlarmBindingSource.DataSource = _pasienter[x].ListAlarm;
            }
        }

        private void Intervall_Click(object sender, EventArgs e) // Viser målinger i en gitt tidsperiode
        {
            string startStr = dateTimePicker1.Value.ToString("HH:mm:ss");
            DateTime start = Convert.ToDateTime(startStr);
            string stoppStr = dateTimePicker3.Value.ToString("HH:mm:ss");
            DateTime stopp = Convert.ToDateTime(stoppStr);
            Klokke k = new Klokke(start, stopp, _pasienter[dgwPasienter.SelectedRows[0].Index]);
            k.ShowDialog();
        }

        private void buttonAvslutt_Click(object sender, EventArgs e)
        {
            // avslutte alle tråder og koble ifra
            // Lagre en siste gang
            LesSkrivFil.SkrivTilFil(_pasienter, Filnavn);
            this.Close();

        }
    }
}


