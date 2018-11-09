using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibaryPasient;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Script.Serialization;

/*
 bugs
    - dato og klokke, konvertere til datetime
    - alarm, konvertere til bool
    -[ok?] sender data før den er koblet til sentral
    - feiler om den ikke får data fra simsim
    - hvis sentral blir koblet ifra
    - bedre mottak av data på seriell. 
    
 Legge til:
    - bedre visning for alarm
    - id - registrering
    - klokke på monitor


    */




namespace Monitor
{
    public partial class Form1 : Form
    {
        private Pasient _pasient;
        private SerialPort comPort;
        private bool _forrigeAlarm;
        private int _teller;

        private IPEndPoint serverEndPoint;
        private Socket klientSokkel;


        public Form1()
        {
            try
            {
                InitializeComponent();
                comPort = new SerialPort();
                _forrigeAlarm = false;
                _teller = 10;
                _pasient = new Pasient();
                OppdaterLabel();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void SettOppKort()
        {
            Thread.Sleep(300);
            comPort.WriteLine($"$D{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}"); //Oppdatere dato
            Thread.Sleep(300);
            comPort.WriteLine($"$T{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}"); //Klokke
            Thread.Sleep(300);
            comPort.WriteLine("$S001"); //frekvens

            Thread.Sleep(200);

            // Legge til noe som sjekker at det kommer data fra port før den starter bgw

            bgWLesData.RunWorkerAsync();
        }

        private void AlarmLogikk()
        {
            if (_pasient.Alarm.GetGrense())
            {
                btnGrense.BackColor = Color.Red;

                if (!_forrigeAlarm)
                {
                    _forrigeAlarm = true;
                    btnAlarm.BackColor = Color.Red;
                    _pasient.Alarm.SetAlarm(true);
                }
            }
            else
            {
                btnGrense.BackColor = Color.White;
                _forrigeAlarm = false;
            }
            _pasient.Alarm.SetGrense(false);

            if (_pasient.Alarm.GetAlarm())
            {
                btnAlarm.BackColor = Color.Red;
                //txtAlarmH.Text = _pasient.Alarm.GetHendelse();
            }
        }

        private void SendData()
        {
            if (klientSokkel != null)
            {

                string json = new JavaScriptSerializer().Serialize(_pasient);

                klientSokkel.Send(Encoding.ASCII.GetBytes(json));
            }


        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            _pasient.Alarm.SetAlarm(false);
            btnAlarm.BackColor = Color.White;
            SendData();
        }

        void OppdaterLabel()
        {
            labelMaxPuls.Text = _pasient.Pulsfrekvens.Max.ToString();
            labelMinPuls.Text = _pasient.Pulsfrekvens.Min.ToString();
            labelMaxBlod.Text = _pasient.Blodtrykk.Max.ToString();
            labelMinBlod.Text = _pasient.Blodtrykk.Min.ToString();
            labelMaxResp.Text = _pasient.Respirasjonsrate.Max.ToString();
            labelMinResp.Text = _pasient.Respirasjonsrate.Min.ToString();
            labelMaxTemp.Text = _pasient.Kroppstemperatur.Max.ToString();
            labelMinTemp.Text = _pasient.Kroppstemperatur.Min.ToString();
            txtPasientNavn.Text = _pasient.Navn;
            txtPasientAlder.Text = _pasient.Alder;
        }

        private void registrerPasientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                RegistrerPM registrer = new RegistrerPM(_pasient);
                registrer.ShowDialog();


                _pasient.Kroppstemperatur.Min = (int)registrer.MinTemp;
                _pasient.Kroppstemperatur.Max = (int)registrer.MaxTemp;
                _pasient.Blodtrykk.Max = (int)registrer.MaxBlodtrykk;
                _pasient.Blodtrykk.Min = (int)registrer.MinBlodtrykk;
                _pasient.Pulsfrekvens.Max = (int)registrer.MaxPuls;
                _pasient.Pulsfrekvens.Min = (int)registrer.MinPuls;
                _pasient.Respirasjonsrate.Max = (int)registrer.MaxResp;
                _pasient.Respirasjonsrate.Min = (int)registrer.MinResp;
                _pasient.Navn = registrer.Navn;
                _pasient.Alder = registrer.Alder;

                OppdaterLabel();

                SendData(); //sende registrert pasient til sentral
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void kobleTilSentralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //minSokkel.KobleTilServer();    // blokkerende metode
                Socket klientSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
                klientSokkel.Connect(serverEP);

                txtSentralInfo.Text = "Tilkoblet server";

                string json = new JavaScriptSerializer().Serialize(_pasient);
                klientSokkel.Send(Encoding.ASCII.GetBytes(json));
            }
            catch (SocketException eks)
            {
                MessageBox.Show("Feil: " + eks.Message);
            }

            

        }

        private void velgComPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ts_cbComPorter.Items.Clear(); //Tømmer listen
                string[] portNames = SerialPort.GetPortNames(); //henter tilgjengelige porter

                foreach (string name in portNames) //legger tigjengelige porter til i windu
                {
                    ts_cbComPorter.Items.Add(name);
                }

                if (ts_cbComPorter.Items.Count > 0) ts_cbComPorter.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("feil med henting av com porter" + exception.ToString());

            }
        }

        private void kobleTilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (kobleTilToolStripMenuItem.Text == "Koble til")
                {
                    comPort.Close();
                    comPort.PortName = ts_cbComPorter.SelectedItem.ToString();
                    comPort.BaudRate = 9600;
                    comPort.ReadTimeout = 1000;
                    comPort.Open();

                    SettOppKort();

                    kobleTilToolStripMenuItem.Text = "Koble fra";
                }
                else
                {
                    comPort.Close();
                    kobleTilToolStripMenuItem.Text = "Koble til";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Prøv en annen serieport.\n\n" + ex.ToString());
            }
        }
    }
}
