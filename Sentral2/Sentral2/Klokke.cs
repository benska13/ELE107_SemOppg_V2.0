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


namespace Sentral2
{
    public partial class Klokke : Form
    {
        BindingList<Kroppstemperaturx> templist = new BindingList<Kroppstemperaturx>();
        BindingList<Pulsfrekvens> pulslist = new BindingList<Pulsfrekvens>();
        BindingList<Blodtrykk> blodtrykksliste = new BindingList<Blodtrykk>();
        BindingList<Respirasjonsrate> resplist = new BindingList<Respirasjonsrate>();
        BindingList<Alarm> alarmlist = new BindingList<Alarm>();
        DateTime _start;
        DateTime _stopp;
        ListPasient pList;


        public Klokke(DateTime start, DateTime stopp, ListPasient p)
        {
            InitializeComponent();
            listKroppstemperaturBindingSource.DataSource = templist;
            listPulsfrekvensBindingSource.DataSource = pulslist;
            listBlodtrykkBindingSource.DataSource = blodtrykksliste;
            listRespirasjonsrateBindingSource.DataSource = resplist;
            listAlarmBindingSource.DataSource = alarmlist;
            _start = start;
            _stopp = stopp;
            pList = p;
        }

        private void Klokke_Load(object sender, EventArgs e)
        {
            foreach (Kroppstemperaturx k in pList.ListKroppstemperatur)
            {
                if (k.DatoTid < _stopp && k.DatoTid > _start)
                {
                    templist.Add(k);
                }
            }
            foreach (Pulsfrekvens p in pList.ListPulsfrekvens)
            {
                if (p.DatoTid < _stopp && p.DatoTid > _start)
                {
                    pulslist.Add(p);
                }
            }
            foreach (Blodtrykk b in pList.ListBlodtrykk)
            {
                if (b.DatoTid < _stopp && b.DatoTid > _start)
                {
                    blodtrykksliste.Add(b);
                }
            }
            foreach (Respirasjonsrate r in pList.ListRespirasjonsrate)
            {
                if (r.DatoTid < _stopp && r.DatoTid > _start)
                {
                    resplist.Add(r);
                }
            }
            foreach (Respirasjonsrate p in pList.ListRespirasjonsrate)
            {
                if (p.DatoTid < _stopp && p.DatoTid > _start)
                {
                    resplist.Add(p);
                }
            }
            foreach (Alarm a in pList.ListAlarm)
            {
                if (a.datoTid < _stopp && a.datoTid > _start)
                {
                    alarmlist.Add(a);
                }
            }
        }
    }


}

