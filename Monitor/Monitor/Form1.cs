using System;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibaryPasient;
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;

/*
 Må forbedres:
    - handling ved brudd i kommunikajon med server og comport
        (blir idag fanget opp med try-catch)
    - mulighet for å koble fra server
    - sikker lukking av koblinger og tråder ved avsluttning
    - revurdere sokkel klassen som er laget

    */




namespace Monitor
{
    public delegate void Mdt(string d);

    public partial class Pasientmonitor : Form
    {
        private readonly Pasient _pasient;
        private readonly SerialPort _comPort;
        private bool _forrigeAlarm;
        private bool _forrigeGrense;
        private int _teller;
        private Mdt _minDelegate;

        private Socket _klientSokkel;
        private IPEndPoint _serverEp;

        public Pasientmonitor()
        {
            try
            {
                InitializeComponent();
                _comPort = new SerialPort();
                _forrigeAlarm = false;
                _forrigeGrense = false;
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
            Thread.Sleep(400);
            _comPort.WriteLine($"$D{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}"); //Oppdatere dato
            Thread.Sleep(400);
            _comPort.WriteLine($"$T{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}"); //Klokke
            Thread.Sleep(400);
            _comPort.WriteLine("$S001"); //frekvens

            Thread.Sleep(400);
        }

        private void AlarmLogikk()
        {
            txtAlarmHendelse.Text = _pasient.Alarm.Hendelse;
            bool nybeskjed = false;


            if (_forrigeGrense != _pasient.Alarm.Grense)
            {
                nybeskjed = true;
                _forrigeGrense = _pasient.Alarm.Grense;
                if (_forrigeGrense)
                {
                    _pasient.Alarm.SetAlarm();
                }
            }
            if (_forrigeAlarm != _pasient.Alarm.Alarmm)
            {
                nybeskjed = true;
                _forrigeAlarm = _pasient.Alarm.Alarmm;
            }

            btnAlarm.BackColor = _pasient.Alarm.Alarmm ? Color.Red : Color.White;

            btnGrense.BackColor = _pasient.Alarm.Grense ? Color.Red : Color.White;

            if (nybeskjed)
            {
                SendData();
            }
        }

        private void SendData()
        {

            try
            {
                if (_klientSokkel != null)  // Usikker på om denne sjekken er nyttig
                {

                    if (_klientSokkel.Connected)
                    {
                        string json = new JavaScriptSerializer().Serialize(_pasient);

                        _klientSokkel.Send(Encoding.ASCII.GetBytes(json));
                        _teller = 0;
                    }
                    else
                    {
                        _klientSokkel.Close();
                        _klientSokkel = null;
                        txtSentralInfo.Text = "Sokkel = null";
                    }
                }
            }
            catch (Exception)
            {
                if (_klientSokkel != null) _klientSokkel.Close();   // Ikke bra løsning?
                _klientSokkel = null;
                txtSentralInfo.Text = "Sokkel = null";
            }
        }

        private void OppdaterLabel()
        {
            labelMaxPuls.Text = "Max: " + _pasient.Pulsfrekvens.Max.ToString();
            labelMinPuls.Text = "Min: " + _pasient.Pulsfrekvens.Min.ToString();
            labelMaxBlod.Text = "Max: " + _pasient.Blodtrykk.Max.ToString();
            labelMinBlod.Text = "Min: " + _pasient.Blodtrykk.Min.ToString();
            labelMaxResp.Text = "Max: " + _pasient.Respirasjonsrate.Max.ToString();
            labelMinResp.Text = "Min: " + _pasient.Respirasjonsrate.Min.ToString();
            labelMaxTemp.Text = "Max: " + _pasient.Kroppstemperatur.Max.ToString();
            labelMinTemp.Text = "Min: " + _pasient.Kroppstemperatur.Min.ToString();
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
                MessageBox.Show(exception.Message.ToString());
            }
        }

        private void kobleTilSentralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _klientSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
                _klientSokkel.Connect(_serverEp);  // blokkerende metode
                SendData();
                txtSentralInfo.Text = "Tilkoblet server";
            }
            catch (SocketException eks)
            {
                MessageBox.Show("Feil: " + eks.Message);
                txtSentralInfo.Text = "Feilmelding";
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
                MessageBox.Show("feil med henting av com porter" + exception.Message.ToString());

            }
        }

        private void kobleTilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (kobleTilToolStripMenuItem.Text == "Koble til")
                {
                    _comPort.Close();
                    _comPort.PortName = ts_cbComPorter.SelectedItem.ToString();
                    _comPort.BaudRate = 9600;
                    _comPort.ReadTimeout = 1000;

                    _comPort.DataReceived += new SerialDataReceivedEventHandler(MottarData);

                    _comPort.Open();

                    SettOppKort();


                    txtComInfo.Text = "Koblet til:" + _comPort.PortName;
                    kobleTilToolStripMenuItem.Text = "Koble fra";
                }
                else
                {
                    _comPort.Close();
                    kobleTilToolStripMenuItem.Text = "Koble til";
                    txtComInfo.Text = "Koblet fra";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Prøv en annen serieport.\n\n" + ex.Message.ToString());
            }
        }

        private void MottarData(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = "";
                SerialPort sp = (SerialPort)sender;
                data = sp.ReadExisting();

                _minDelegate = new Mdt(OppdaterPasient);
                Invoke(_minDelegate, data);
            }
            catch (Exception exception)
            {
                MessageBox.Show("MottarDatan\n" + exception.Message.ToString());
            }
        }

        private void OppdaterPasient(string data)
        {
            if (data != "")
            {
                // Finner dato og klokkeslett
                string dato = "";
                int pos = data.IndexOf('B');
                dato += data.Substring(pos + 1, 8);
                pos = data.IndexOf('C');
                dato += data.Substring(pos + 1, 6);
                _pasient.SetDatoKlokke(dato);

                _pasient.Alarm.Grense = false;
                bool b = false;

                // Finner puls
                pos = data.IndexOf('F');
                b = _pasient.Pulsfrekvens.SetVerdi(Convert.ToInt32(data.Substring(pos + 1, 4)));
                if (b) _pasient.Alarm.SetGrense("Puls");
                // Finner blodtrykk
                pos = data.IndexOf('G');
                b = _pasient.Blodtrykk.SetVerdi(Convert.ToInt32(data.Substring(pos + 1, 4)));
                if (b) _pasient.Alarm.SetGrense("Blod");
                // Finner temperatur
                pos = data.IndexOf('H');
                b = _pasient.Kroppstemperatur.SetVerdi(Convert.ToInt32((data.Substring(pos + 1, 3))));
                if (b) _pasient.Alarm.SetGrense("Temp");
                // Finner respirasjon
                pos = data.IndexOf('I');
                b = _pasient.Respirasjonsrate.SetVerdi(Convert.ToInt32(data.Substring(pos + 1, 3)));
                if (b) _pasient.Alarm.SetGrense("Resp");

                // Digital /alarm
                pos = data.IndexOf('E');
                string a = data.Substring(pos + 1, 1);
                if (a == "1")
                {
                    _pasient.Alarm.SetAlarm();
                    _pasient.Alarm.Hendelse = "Alarm-Snor";
                }
                a = data.Substring(pos + 2, 7);
                int id = Convert.ToInt32(a, 2);
                if (id > 0)
                {
                    _pasient.Alarm.Alarmm = false;
                    _pasient.Alarm.Hendelse = "ID: " + id;
                    _comPort.WriteLine("$O00");
                    Thread.Sleep(300);
                    _comPort.WriteLine("$O10");
                    Thread.Sleep(200);
                    btnAlarm.BackColor = Color.White;
                }

                // Oppdatere gui
                txtTemp.Text = _pasient.Kroppstemperatur.GetVerdi() + _pasient.Kroppstemperatur.Enhet;
                txtBlodtrykk.Text = _pasient.Blodtrykk.GetVerdi() + _pasient.Blodtrykk.Enhet;
                txtBlodtrykk2.Text = _pasient.Blodtrykk.Verdi2 + _pasient.Blodtrykk.Enhet;
                txtPuls.Text = _pasient.Pulsfrekvens.GetVerdi() + _pasient.Pulsfrekvens.Enhet;
                txtResp.Text = _pasient.Respirasjonsrate.GetVerdi() + _pasient.Respirasjonsrate.Enhet;
                txtSisteStatus.Text = _pasient.Blodtrykk.DatoTid.ToString(CultureInfo.CurrentCulture);
                txtAlarmHendelse.Text = _pasient.Alarm.Hendelse;

                AlarmLogikk();

                _teller++;
                if (_teller > 10)
                {
                    SendData();
                }
            }
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _comPort.Close();
            _klientSokkel.Close();
            this.Close();
        }
    }
}
