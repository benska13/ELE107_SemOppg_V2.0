using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibaryPasient;


namespace Sentral
{
    public partial class Klokke : Form
    {
        BindingList<Kroppstemperaturx> templist = new BindingList<Kroppstemperaturx>();
        BindingList<Pulsfrekvens> pulslist = new BindingList<Pulsfrekvens>();
        BindingList<Blodtrykk> blodtrykksliste = new BindingList<Blodtrykk>();
        BindingList<Respirasjonsrate> resplist = new BindingList<Respirasjonsrate>();
        BindingList<Alarm> alarmlist = new BindingList<Alarm>();




        public Klokke()
        {
            InitializeComponent();
            listKroppstemperaturBindingSource.DataSource = templist;
            listPulsfrekvensBindingSource.DataSource = pulslist;
            listBlodtrykkBindingSource.DataSource = blodtrykksliste;
            listRespirasjonsrateBindingSource.DataSource = resplist;
            listAlarmBindingSource.DataSource = alarmlist;
        }


        public void Intervallskrivut(DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker3, ListPasient pasient)
        {
            DateTime tid1 = Convert.ToDateTime(dateTimePicker1);
            DateTime tid2 = Convert.ToDateTime(dateTimePicker3);

            foreach (Kroppstemperaturx a in pasient.ListKroppstemperatur)
            {
                if (a.DatoTid < tid2 && a.DatoTid > tid1)
                {
                    templist.Add(a);
                }



            }
            foreach (Pulsfrekvens p in pasient.ListPulsfrekvens)
            {
                if (p.DatoTid < tid2 && p.DatoTid > tid1)
                {
                    pulslist.Add(p);
                }

            }
            foreach (Blodtrykk p in pasient.ListBlodtrykk)
            {
                if (p.DatoTid < tid2 && p.DatoTid > tid1)
                {
                    blodtrykksliste.Add(p);
                }

            }
            foreach (Respirasjonsrate p in pasient.ListRespirasjonsrate)
            {
                if (p.DatoTid < tid2 && p.DatoTid > tid1)
                {
                    resplist.Add(p);
                }

            }
            foreach (Alarm p in pasient.ListAlarm)
            {
                if (p.datoTid < tid2 && p.datoTid > tid1)
                {
                    alarmlist.Add(p);
                }

            }




        }
    }


}

