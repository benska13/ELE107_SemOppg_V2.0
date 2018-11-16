using System;
using LibaryPasient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Threading;



// Klokke oppdatert hvert 10 sek // OK
// aktive alarmer // ok
// avslutt 
//Varsler watchdog 
// sjekk om pasient finnes fra før

namespace Sentral2
{
    public delegate void Mdt(Pasient p);

    public partial class Form1 : Form
    {
        private BindingList<ListPasient> _pasienter;
        private BindingList<string> _aktivAlarm;

        private Socket _kommSokkel;
        private Socket _lytteSokkel;

        private string _filnavn = "PasienterFil.txt";

        private Mdt _minDelegate;

        public Form1()
        {
            InitializeComponent();

            _pasienter = new BindingList<ListPasient> { };
            _aktivAlarm=new BindingList<string>();
            lbAktiveAlarmer.DataSource = _aktivAlarm;

            OppdaterLabelerGui();

            _lytteSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            _lytteSokkel.Bind(serverEp);
            _lytteSokkel.Listen(10);

            if (File.Exists(_filnavn))
            {
                try
                {
                    _pasienter = LesSkrivFil.LesFraFil(_filnavn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    File.Delete(_filnavn);
                }
            }

            listPasientBindingSource.DataSource = _pasienter;
            dgwPasienter.SelectAll();
            bgwVentPaKlient.RunWorkerAsync();
        }

        void PasientSjekk(Pasient n)      // Kan gjøres bedre
        {
            bool pasientFunnet = false;
            foreach (ListPasient p in _pasienter)
            {
                if (p.Navn == n.Navn)
                {
                    p.NyData(n);
                    pasientFunnet = true;
                    OppdaterVerdiGui(p);

                     OppdaterAktivAlarmList(p);
                }
            }

            if (!pasientFunnet)
            {
                _pasienter.Insert(0, new ListPasient(n));
                OppdaterVerdiGui(_pasienter.Last());
                OppdaterAktivAlarmList(_pasienter.Last());
            }
        }

        private void OppdaterAktivAlarmList(ListPasient p)
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

        private void VentPaaData(object state)
        {
            try
            {

                Socket kommSocket = (Socket)state;
                while (kommSocket.IsBound)
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
            lblBx1Enhet.Text = p.Kroppstemperatur.Enhet;
            gbxPuls.Text = p.Pulsfrekvens.ToString();
            lblBx2Enhet.Text = p.Pulsfrekvens.Enhet;
            gbxBlod.Text = p.Blodtrykk.ToString();
            lblBx3Enhet1.Text = p.Blodtrykk.Enhet;
            lblBx3Enhet2.Text = p.Blodtrykk.Enhet2;
            gbxResp.Text = p.Respirasjonsrate.ToString();
            lblBx4Enhet.Text = p.Respirasjonsrate.Enhet;
            tpTemp.Text = p.Kroppstemperatur.ToString();
            tpAlarm.Text = p.Alarm.ToString();
            tpBlod.Text = p.Blodtrykk.ToString();
            tpPuls.Text = p.Pulsfrekvens.ToString();
            tpResp.Text = p.Respirasjonsrate.ToString();
        }
        public void OppdaterVerdiGui(ListPasient n)
        {
            if (_pasienter[dgwPasienter.SelectedRows[0].Index]==n)
            {
                // bx1= temp
                // bx2= puls
                // bx3= blod
                // bx4= resp
                lblBx1Min.Text = n.ListKroppstemperatur.First().Min.ToString();
                lblBx1Max.Text = n.ListKroppstemperatur.First().Max.ToString();
                txtBx1Verdi.Text = n.ListKroppstemperatur.First().Verdi.ToString();

                lblBx2Min.Text = n.ListPulsfrekvens.First().Min.ToString();
                lblBx2Max.Text = n.ListPulsfrekvens.First().Max.ToString();
                txtBx2Verdi.Text = n.ListPulsfrekvens.First().Verdi.ToString();

                lblBx3Min.Text = n.ListBlodtrykk.First().Min.ToString();
                lblBx3Max.Text = n.ListBlodtrykk.First().Max.ToString();
                txtBx3Verdi1.Text = n.ListBlodtrykk.First().Verdi.ToString();
                txtBx3Verdi2.Text = n.ListBlodtrykk.First().Verdi2.ToString();

                lblBx4Min.Text = n.ListRespirasjonsrate.First().Min.ToString();
                lblBx4Max.Text = n.ListRespirasjonsrate.First().Max.ToString();
                txtBx4Verdi.Text = n.ListRespirasjonsrate.First().Verdi.ToString();
                textBoxTidMaal.Text = n.ListAlarm.First().DatoTid.ToLongTimeString();

                
            }
            LesSkrivFil.SkrivTilFil(_pasienter, _filnavn);
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
        private void bgwVentPaKlient_DoWork(object sender, DoWorkEventArgs e)
        {
            _kommSokkel = minSokkel.VentPaaKlient(_lytteSokkel);   // Blokerer, venter på klient
        }
        private void bgwVentPaKlient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(VentPaaData, _kommSokkel);                  // Starter en tråd som venter på data
            bgwVentPaKlient.RunWorkerAsync();
        }
        private void dgwPasienter_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgwPasienter.SelectedRows.Count!=0)
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
        private void Intervall_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dateTimePicker1);
            DateTime stop = Convert.ToDateTime(dateTimePicker3);
            Klokke k = new Klokke(start, stop, _pasienter[dgwPasienter.SelectedRows[0].Index]);
            k.ShowDialog();
        }

        private void buttonAvslutt_Click(object sender, EventArgs e)
        {
            // avslutte alle tråder og koble ifra
            // Lagre en siste gang
            LesSkrivFil.SkrivTilFil(_pasienter,_filnavn);
            this.Close();

        }
    }


}
