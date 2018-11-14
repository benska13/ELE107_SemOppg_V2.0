using System;
using LibaryPasient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
        private BindingList<Alarm> AktiveAlarmer;

        private List<Socket> _kommSokkeList;
        private Socket _lytteSokkel;

        private int teller = 1;
        private string _filnavn = "PasienterFil";

        private Mdt minDelegate;

        private int pasientnr = 0;

        public Form1()
        {

            InitializeComponent();
            _pasienter = new BindingList<ListPasient> { };
            OppdaterLabelerGui();

            _lytteSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            _lytteSokkel.Bind(serverEp);
            _lytteSokkel.Listen(10);

            listPasientBindingSource.DataSource = _pasienter;
            bgwVentPaKlient.RunWorkerAsync();
            AktiveAlarmer = new BindingList<Alarm>();
            // dataGridAktiveAlarmer.DataSource = AktiveAlarmer;




            try
            {
                LesSkrivFil.LesFraFil(_filnavn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            _kommSokkeList = new List<Socket>();
            //ThreadPool.QueueUserWorkItem(VentPaaMonitor, _pasienter);
        }

        void PasientSjekk(Pasient n)
        {
            bool pasientFunnet = false;
            foreach (ListPasient p in _pasienter)
            {
                if (p.Navn == n.Navn)
                {
                    p.NyData(n);
                    pasientFunnet = true;
                    OppdaterVerdiGui(p);
                }
            }

            if (!pasientFunnet)
            {
                _pasienter.Add(new ListPasient(n));
                OppdaterVerdiGui(_pasienter.Last());
            }
        }

        private void VentPaaData(object state)
        {
            //ListPasient lp = (ListPasient) state;
            Socket kommSocket = (Socket)state;
            int i = pasientnr;
            while (true)
            {
                string data = minSokkel.VentPaData(kommSocket);
                Pasient p = Serialize.StringTPasient(data);

                minDelegate = new Mdt(PasientSjekk);
                this.Invoke(minDelegate, p);
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
            // lblBx3Enhet2.Text = p.Blodtrykk.Enhet2;
            gbxResp.Text = p.Respirasjonsrate.ToString();
            lblBx4Enhet.Text = p.Respirasjonsrate.Enhet;

        }


        public void OppdaterVerdiGui(ListPasient n)
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
            //txtBx3Verdi2.Text = n.ListBlodtrykk.First().Verdi2.ToString();

            lblBx4Min.Text = n.ListRespirasjonsrate.First().Min.ToString();
            lblBx4Max.Text = n.ListRespirasjonsrate.First().Max.ToString();
            txtBx4Verdi.Text = n.ListRespirasjonsrate.First().Verdi.ToString();
            textBoxTidMaal.Text = n.ListAlarm.First().datoTid.ToLongTimeString();

            LesSkrivFil.SkrivTilFil(_pasienter, _filnavn);
        }


        private void dgwPasienter_SelectionChanged(object sender, EventArgs e)
        {
            int x = dgwPasienter.SelectedRows[0].Index;
            OppdaterVerdiGui(_pasienter[x]);
            listPulsfrekvensBindingSource.DataSource = _pasienter[dgwPasienter.SelectedRows[0].Index].ListPulsfrekvens;
            listKroppstemperaturBindingSource.DataSource = _pasienter[dgwPasienter.SelectedRows[0].Index].ListKroppstemperatur;
            listRespirasjonsrateBindingSource.DataSource = _pasienter[dgwPasienter.SelectedRows[0].Index].ListRespirasjonsrate;
            listBlodtrykkBindingSource.DataSource = _pasienter[dgwPasienter.SelectedRows[0].Index].ListBlodtrykk;

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
            var kommSocket = minSokkel.VentPaaKlient(_lytteSokkel);   // Blokerer, venter på klient
            _kommSokkeList.Add(kommSocket);                             // Klient oppdaget og legger tilkoblingsdata til i listen

        }

        private void bgwVentPaKlient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string data = minSokkel.VentPaData(_kommSokkeList[pasientnr]);         // venter på pasientdata
            Pasient p = Serialize.StringTPasient(data);                // konverterer til pasient 
            //_pasienter.Add(new ListPasient(p));                         // legger pasient til i listen med pasienter                        MÅ S`JEKKE OM  P ER DER FRA FØR!!!

            PasientSjekk(p);


            ThreadPool.QueueUserWorkItem(VentPaaData, _kommSokkeList[pasientnr]);                  // Starter en tråd som venter på data
            pasientnr++;
            bgwVentPaKlient.RunWorkerAsync();

        }
    }

}
