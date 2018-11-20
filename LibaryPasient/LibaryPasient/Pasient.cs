using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;

/*
  legge til
  -

     * */
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
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Alder { get; set; }
        public DateTime SisteMeldingMottatt { get; set; }
        public BindingList<Kroppstemperaturx> ListKroppstemperatur { get; set; }
        public BindingList<Blodtrykk> ListBlodtrykk { get; set; }
        public BindingList<Respirasjonsrate> ListRespirasjonsrate { get; set; }
        public BindingList<Pulsfrekvens> ListPulsfrekvens { get; set; }
        public BindingList<Alarm> ListAlarm { get; set; }
        public ListPasient(Pasient innPasient)
        {
            Id = idteller++;
            Navn = innPasient.Navn;
            Alder = innPasient.Alder;

            ListKroppstemperatur = new BindingList<Kroppstemperaturx>();
            ListBlodtrykk = new BindingList<Blodtrykk>();
            ListRespirasjonsrate = new BindingList<Respirasjonsrate>();
            ListPulsfrekvens = new BindingList<Pulsfrekvens>();
            ListAlarm = new BindingList<Alarm> {new Alarm()};

            NyData(innPasient);
        }

        public ListPasient()
        {
        }

        public void NyData(Pasient inPasient)
        {
            Alder = inPasient.Alder;

            ListKroppstemperatur.Insert(0, inPasient.Kroppstemperatur);
            ListBlodtrykk.Insert(0, inPasient.Blodtrykk);
            ListPulsfrekvens.Insert(0, inPasient.Pulsfrekvens);
            ListRespirasjonsrate.Insert(0, inPasient.Respirasjonsrate);
            if (ListAlarm.First().Alarmm != inPasient.Alarm.Alarmm || ListAlarm.First().Grense != inPasient.Alarm.Grense)
            {
                ListAlarm.Insert(0, inPasient.Alarm);
            }
            
        }
    }
    public class Alarm
    {
        public  bool Grense { get; set; } = false;

        public bool Alarmm { get; set; } = false;

        public void SetAlarm()
        {
            Alarmm = true;
            DatoTid = Pasient.DatoKlokke;
        }
        public  string Hendelse { get; set; } = "";
        public DateTime DatoTid { get; set; }

        public void SetGrense(string s)
        {
            Grense = true;
            Hendelse = s;
        }

        public override string ToString()
        {
            return "Alarm:";
        }
    }
    public class Kroppstemperaturx
    {
        public int Verdi { get; set; } = 0;
        public string Enhet { get; } = " *C";
        public DateTime DatoTid { get; set; }

        public int Min { get; set; } = 35;
        public int Max { get; set; } = 40;


        public int GetVerdi()
        {
            return Verdi;
        }
        public bool SetVerdi(int value)
        {
            Verdi = value;
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public override string ToString()
        {
            return "Kroppstemperatur:";
        }
    }
    public class Blodtrykk
    {
        public int Verdi { get; set; } = 0;
        public string Enhet { get; } = " mmHg";
        public int Verdi2 { get; set; } = 0;
        public DateTime DatoTid { get; set; }
        public int Min { get; set; } = 50;
        public int Max { get; set; } = 100;

        public int GetVerdi()
        {
            return Verdi;
        }
        public bool SetVerdi(int value)
        {
            Verdi = value;
            Verdi2 =(int) (Verdi* (2.0/ 3));
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi2 < Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Blodtrykk:";
        }
    }
    public class Pulsfrekvens
    {
        public int Verdi { get; set; } = 0;
        public string Enhet { get; } = " SPM";
        public DateTime DatoTid { get; set; }
        public int Min { get; set; } = 50;
        public int Max { get; set; } = 200;
        public int GetVerdi()
        {
            return Verdi;
        }
        public bool SetVerdi(int value)
        {
            Verdi = value;
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "Pulsfrekvens:";
        }
    }
    public class Respirasjonsrate
    {
        public int Verdi { get; set; } = 0;
        public string Enhet { get; } = " PPM";
        public DateTime DatoTid { get; set; }
        public int Min { get; set; } = 10;
        public int Max { get; set; } = 60;
        public int GetVerdi()
        {
            return Verdi;
        }
        public bool SetVerdi(int value)
        {
            Verdi = value;
            DatoTid = Pasient.DatoKlokke;
            if (Verdi > Max || Verdi < Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "Respirasjonsrate:";
        }
    }
}