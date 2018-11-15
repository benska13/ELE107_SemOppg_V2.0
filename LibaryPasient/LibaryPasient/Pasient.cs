using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;

/*
  legge til
    - id på pasient
    - enhet på målinger
    - blodt mangler en variabel
    */
namespace LibaryPasient
{
    public class Pasient
    {
        public string Navn { get; set; } = "";
        public string Alder { get; set; } = "";
        public Kroppstemperaturx Kroppstemperatur { get; set; } = new Kroppstemperaturx();
        public Pulsfrekvens Pulsfrekvens { get; set; } = new Pulsfrekvens();
        public Blodtrykk Blodtrykk { get; set; } = new Blodtrykk();
        public Respirasjonsrate Respirasjonsrate { get; set; } = new Respirasjonsrate();
        public Alarm Alarm { get; set; } = new Alarm();
        public static DateTime DatoKlokke { get; set; }
        public Socket KommSokkel { get; set; }
        public void SetDatoKlokke(string datoKlokke)
        {

            DatoKlokke = DateTime.ParseExact(datoKlokke, "yyyyMMddHHmmss", null);
        }
        public override string ToString()
        {
            return Navn;
        }
    }
    public class ListPasient
    {
        private static int idteller = 1;
        public int Id { get; }
        public string Navn { get; set; }
        public string Alder { get; set; }
        public BindingList<Kroppstemperaturx> ListKroppstemperatur { get; set; }
        public BindingList<Blodtrykk> ListBlodtrykk { get; set; }
        public BindingList<Respirasjonsrate> ListRespirasjonsrate { get; set; }
        public BindingList<Pulsfrekvens> ListPulsfrekvens { get; set; }
        public BindingList<Alarm> ListAlarm { get; set; }
        public Socket KommSokkel { get; set; }
        public ListPasient(Pasient innPasient)
        {
            Id = idteller++;
            Navn = innPasient.Navn;
            Alder = innPasient.Alder;

            ListKroppstemperatur = new BindingList<Kroppstemperaturx>();
            ListBlodtrykk = new BindingList<Blodtrykk>();
            ListRespirasjonsrate = new BindingList<Respirasjonsrate>();
            ListPulsfrekvens = new BindingList<Pulsfrekvens>();
            ListAlarm = new BindingList<Alarm>();

            NyData(innPasient);
        }
        public void NyData(Pasient inPasient)
        {
            Navn = inPasient.Navn;
            Alder = inPasient.Alder;
            KommSokkel = inPasient.KommSokkel;

            ListKroppstemperatur.Insert(0, inPasient.Kroppstemperatur);
            ListBlodtrykk.Insert(0, inPasient.Blodtrykk);
            ListPulsfrekvens.Insert(0, inPasient.Pulsfrekvens);
            ListRespirasjonsrate.Insert(0, inPasient.Respirasjonsrate);
            ListAlarm.Insert(0, inPasient.Alarm);
        }
    }
    public class Alarm
    {
        public static bool Grense { get; set; }
        public static bool Alarmm { get; set; }
        public static string Hendelse { get; set; }
        public DateTime datoTid { get; set; }
        public void SetGrense(bool value)
        {
            Grense = value;
            datoTid = Pasient.DatoKlokke;
        }

        public bool GetGrense()
        {
            return Grense;
        }

        public void SetAlarm(bool value, string hendelse)
        {
            Alarmm = value;
            Hendelse = hendelse;
            datoTid = Pasient.DatoKlokke;
        }

        public void SetAlarm(bool value)
        {
            Alarmm = value;
        }

        public bool GetAlarm()
        {
            return Alarmm;
        }

        public string GetHendelse()
        {
            return Hendelse;
        }

        public void SetHendelse(string h)
        {
            Hendelse = h;
        }
    }
    public class Kroppstemperaturx
    {
        public int Verdi { get; set; }
        public string Enhet { get; } = "*C";
        public DateTime DatoTid { get; set; }

        public int Min { get; set; } = 35;
        public int Max { get; set; } = 40;


        public int GetVerdi()
        {
            return Verdi;
        }
        public void SetVerdi(int value)
        {
            Verdi = value;
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                Alarm.Grense = true;
                Alarm.Hendelse = this.ToString();
            }
        }
        public override string ToString()
        {
            return "Kroppstemperatur:";
        }
    }
    public class Blodtrykk
    {
        public int Verdi { get; set; }
        public string Enhet { get; } = "mm Hg";
        public int Verdi2 { get; set; }
        public string Enhet2 { get; } = "mm Hg";
        public DateTime DatoTid { get; set; }
        public int Min { get; set; } = 50;
        public int Max { get; set; } = 100;

        public int GetVerdi()
        {
            return Verdi;
        }
        public void SetVerdi(int value)
        {
            Verdi = value;
            Verdi2 =(int) (Verdi* (2.0/ 3));
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                Alarm.Grense = true;
                Alarm.Hendelse = this.ToString();
            }
        }

        public override string ToString()
        {
            return "Blodtrykk:";
        }
    }
    public class Pulsfrekvens
    {
        public int Verdi { get; set; }
        public string Enhet { get; } = "slag/min";
        public DateTime DatoTid { get; set; }
        public int Min { get; set; } = 50;
        public int Max { get; set; } = 200;
        public int GetVerdi()
        {
            return Verdi;
        }
        public void SetVerdi(int value)
        {
            Verdi = value;
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                Alarm.Grense = true;
                Alarm.Hendelse = this.ToString();
            }
        }
        public override string ToString()
        {
            return "Pulsfrekvens:";
        }
    }
    public class Respirasjonsrate
    {
        public int Verdi { get; set; }
        public string Enhet { get; } = "pust/min";
        public DateTime DatoTid { get; set; }
        public int Min { get; set; } = 10;
        public int Max { get; set; } = 60;
        public int GetVerdi()
        {
            return Verdi;
        }
        public void SetVerdi(int value)
        {
            Verdi = value;
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                Alarm.Grense = true;
                Alarm.Hendelse = this.ToString();
            }
        }
        public override string ToString()
        {
            return "Respirasjonsrate:";
        }
    }
}