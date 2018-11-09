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
// ny kom

namespace Sentral
{
    public partial class Form1 : Form
    {
        private BindingList<ListPasient> _pasienter;
        private BindingList<Alarm> AktiveAlarmer;


        private Socket _lytteSokkel;
        private Socket _kommSokkel;
        private Socket _kommSokkel2;
        private string _mottattTekst;
        private string _mottattTekst2;
        private int teller = 1;
        private string _filnavn = "PasienterFil";

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


        private void bgwVentPaKlient_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
        private void bgwVentPaKlient_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }
        private void bgwVenterPaData_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _mottattTekst = minSokkel.VentPaData(_kommSokkel);

        }

        private void bgwVenterPaData_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

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


        private void button1_Click(object sender, EventArgs e)
        {
            _pasienter.Add(new ListPasient(new Pasient()));
        }

        private void bgwVenterPaData2_DoWork(object sender, DoWorkEventArgs e)
        {
            _mottattTekst2 = minSokkel.VentPaData(_kommSokkel2);
        }

        private void bgwVenterPaData2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

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
            //
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

        public void Intervall_Click(object sender, EventArgs e)
        {

        }
    }

}
