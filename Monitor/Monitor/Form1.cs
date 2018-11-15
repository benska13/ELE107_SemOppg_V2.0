using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibaryPasient;
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;

/*
 bugs
    - dato og klokke, konvertere til datetime
    - alarm, konvertere til bool
    -[ok?] sender data før den er koblet til sentral
    - [ok?]feiler om den ikke får data fra simsim
    - hvis sentral blir koblet ifra
    - bedre mottak av data på seriell. 
    
 Legge til:
    - bedre visning for alarm
    - id - registrering
    - [ok]klokke på monitor


    */




namespace Monitor
{
    public delegate void Mdt(string d);
    public partial class Form1 : Form
    {
        private Pasient _pasient;
        private SerialPort comPort;
        private bool _forrigeAlarm;
        private bool _forrigeGrense;
        private int _teller;
        private Mdt _minDelegate;

        private Socket klientSokkel=null;
        private IPEndPoint serverEP;

        public Form1()
        {
            try
            {
                InitializeComponent();
                comPort = new SerialPort();
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
            comPort.WriteLine($"$D{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}"); //Oppdatere dato
            Thread.Sleep(400);
            comPort.WriteLine($"$T{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}"); //Klokke
            Thread.Sleep(400);
            comPort.WriteLine("$S001"); //frekvens

            Thread.Sleep(400);
        }

        private void AlarmLogikk()
        {
            txtAlarmHendelse.Text = _pasient.Alarm.Hendelse;
            bool nybeskjed = false;


            if (_forrigeGrense != _pasient.Alarm.Grense)
            {
                nybeskjed= true;
                _forrigeGrense = _pasient.Alarm.Grense;
                if (_forrigeGrense)
                {
                    _pasient.Alarm.SetAlarm();
                }
            }
            if (_forrigeAlarm!=_pasient.Alarm.Alarmm)
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

            
            //if (_pasient.Alarm.GetGrense())
            //{
            //    btnGrense.BackColor = Color.Red;

            //    if (!_forrigeAlarm)
            //    {
            //        _forrigeAlarm = true;
            //        btnAlarm.BackColor = Color.Red;
            //        _pasient.Alarm.SetAlarm(true);
            //        txtAlarmHendelse.Text = _pasient.Alarm.GetHendelse();
            //        SendData();
            //    }
            //}
            //else
            //{
            //    btnGrense.BackColor = Color.White;
            //    _forrigeAlarm = false;
            //}
            //_pasient.Alarm.SetGrense(false);

            //if (_pasient.Alarm.GetAlarm())
            //{
            //    btnAlarm.BackColor = Color.Red;
            //    txtAlarmHendelse.Text = _pasient.Alarm.GetHendelse();

            //}
        }

        private void SendData()
        {

            try
            {
                if (klientSokkel != null )
                {

                    if (klientSokkel.Connected)
                    {
                        string json = new JavaScriptSerializer().Serialize(_pasient);

                        klientSokkel.Send(Encoding.ASCII.GetBytes(json));
                    }
                    else
                    {
                        klientSokkel.Close();
                        klientSokkel = null;
                        txtSentralInfo.Text = "Sokkel = null";
                    }
                }
            }
            catch (Exception )
            {
                klientSokkel.Close();     // Ikke bra løsning?
                klientSokkel = null;
                txtSentralInfo.Text = "Sokkel = null";
            }
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
                klientSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
                klientSokkel.Connect(serverEP);  // blokkerende metode

                txtSentralInfo.Text = "Tilkoblet server";
            }
            catch (SocketException eks)
            {
                MessageBox.Show("Feil: " + eks.Message);
                klientSokkel.Close();
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

                    comPort.DataReceived += new SerialDataReceivedEventHandler(MottarData);

                    comPort.Open();

                    SettOppKort();


                    txtComInfo.Text = "Koblet til:" + comPort.PortName;
                    kobleTilToolStripMenuItem.Text = "Koble fra";
                }
                else
                {
                    comPort.Close();
                    kobleTilToolStripMenuItem.Text = "Koble til";
                    txtComInfo.Text = "Koblet fra";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Prøv en annen serieport.\n\n" + ex.ToString());
            }
        }

        private void MottarData(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                bool ferdig = false;
                string data = "";
                SerialPort sp = (SerialPort)sender;
                data = sp.ReadExisting();

                _minDelegate = new Mdt(OppdaterPasient);
                Invoke(_minDelegate, data);

            }
            catch (Exception exception)
            {
                MessageBox.Show("MottarDatan\n" + exception.ToString());
            }
        }

        private void OppdaterPasient(string data)
        {
            if (data!="")
            {
                // Finner dato og klokkeslett
                string dato = "";
                var _pos = data.IndexOf('B');
                dato += data.Substring(_pos + 1, 8);
                _pos = data.IndexOf('C');
                dato += data.Substring(_pos + 1, 6);
                _pasient.SetDatoKlokke(dato);


                _pasient.Alarm.Grense = false;


                bool b = false;
                // Finner puls
                _pos = data.IndexOf('F');
                b=_pasient.Pulsfrekvens.SetVerdi(Convert.ToInt32(data.Substring(_pos + 1, 4)));
                if (b) _pasient.Alarm.SetGrense( "Puls");
                
                // Finner blodtrykk
                _pos = data.IndexOf('G');
                b=_pasient.Blodtrykk.SetVerdi(Convert.ToInt32(data.Substring(_pos + 1, 4)));
                if (b) _pasient.Alarm.SetGrense( "Blod");
                // Finner temperatur
                _pos = data.IndexOf('H');
                b=_pasient.Kroppstemperatur.SetVerdi(Convert.ToInt32((data.Substring(_pos + 1, 3))));
                if (b) _pasient.Alarm.SetGrense( "Temp");
                // Finner respirasjon
                _pos = data.IndexOf('I');
                b=_pasient.Respirasjonsrate.SetVerdi(Convert.ToInt32(data.Substring(_pos + 1, 3)));
                if (b) _pasient.Alarm.SetGrense( "Resp");
                // Digital /alarm
                _pos = data.IndexOf('E');
                var a = data.Substring(_pos + 1, 1);
                if (a == "1")
                {
                    _pasient.Alarm.SetAlarm();
                    _pasient.Alarm.Hendelse = "Alarm-Snor";
                }
                a = data.Substring(_pos + 2, 7);
                int id = Convert.ToInt32(a, 2);
                if (id > 0)
                {
                    _pasient.Alarm.Alarmm = false;
                    _pasient.Alarm.Hendelse = "ID: " + id;
                    comPort.WriteLine("$O00");
                    Thread.Sleep(300);
                    comPort.WriteLine("$O10");
                    Thread.Sleep(200);
                    btnAlarm.BackColor = Color.White;
                }

                // Oppdatere gui
                txtTemp.Text = _pasient.Kroppstemperatur.GetVerdi().ToString();
                txtBlodtrykk.Text = _pasient.Blodtrykk.GetVerdi().ToString();
                txtPuls.Text = _pasient.Pulsfrekvens.GetVerdi().ToString();
                txtResp.Text = _pasient.Respirasjonsrate.GetVerdi().ToString();
                txtSisteStatus.Text = _pasient.Blodtrykk.DatoTid.ToString();
                txtAlarmHendelse.Text = _pasient.Alarm.Hendelse;

                AlarmLogikk();


                _teller++;
                if (_teller > 5)   ///skal være 10
                {
                    SendData();
                    _teller = 0;
                }
            }

        }


    }
}
