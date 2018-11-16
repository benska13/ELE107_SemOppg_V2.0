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

            OppdaterForm();
        }

        private void OppdaterForm()
        {
            foreach (Kroppstemperaturx k in pList.ListKroppstemperatur)
            {
                int starttid = DateTime.Compare(k.DatoTid, _start);
                int stopptid = DateTime.Compare(k.DatoTid, _stopp);
                if (starttid >= 0 && stopptid <= 0)
                {

                    templist.Add(k);
                }
            }
            foreach (Pulsfrekvens p in pList.ListPulsfrekvens)
            {
                int starttid = DateTime.Compare(p.DatoTid, _start);
                int stopptid = DateTime.Compare(p.DatoTid, _stopp);
                if (starttid >= 0 && stopptid <= 0)
                {
                    pulslist.Add(p);
                }
            }
            foreach (Blodtrykk b in pList.ListBlodtrykk)
            {
                int starttid = DateTime.Compare(b.DatoTid, _start);
                int stopptid = DateTime.Compare(b.DatoTid, _stopp);
                if (starttid >= 0 && stopptid <= 0)
                {
                    blodtrykksliste.Add(b);
                }
            }
            foreach (Respirasjonsrate r in pList.ListRespirasjonsrate)
            {
                int starttid = DateTime.Compare(r.DatoTid, _start);
                int stopptid = DateTime.Compare(r.DatoTid, _stopp);
                if (starttid >= 0 && stopptid <= 0)
                {
                    resplist.Add(r);
                }
            }
            foreach (Alarm a in pList.ListAlarm)
            {
                int starttid = DateTime.Compare(a.DatoTid, _start);
                int stopptid = DateTime.Compare(a.DatoTid, _stopp);
                if (starttid >= 0 && stopptid <= 0)
                {
                    alarmlist.Add(a);
                }
            }
        }

        private void Klokke_Load(object sender, EventArgs e)
        {

        }
    }


}

