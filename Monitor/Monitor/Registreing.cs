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

namespace Monitor
{
    public partial class RegistrerPM : Form
    {
        string navn;
        string alder;
        int maxPuls;
        int minPuls;
        int maxTemp;
        int minTemp;
        int maxBlodtrykk;
        int minBlodtrykk;
        int maxResp;
        int minResp;

        public RegistrerPM(Pasient pasient)
        {
            InitializeComponent();
            txtMaxPuls.Text = pasient.Pulsfrekvens.Max.ToString();
            txtMinPuls.Text = pasient.Pulsfrekvens.Min.ToString();
            txtMaxBlodtrykk.Text = pasient.Blodtrykk.Max.ToString();
            txtMinBlodtrykk.Text = pasient.Blodtrykk.Min.ToString();
            txtMaxResp.Text = pasient.Respirasjonsrate.Max.ToString();
            txtMinResp.Text = pasient.Respirasjonsrate.Min.ToString();
            txtMaxTemp.Text = pasient.Kroppstemperatur.Max.ToString();
            txtMinTemp.Text = pasient.Kroppstemperatur.Min.ToString();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        public string Navn
        {
            get { return navn; }
        }

        public string Alder
        {
            get { return alder; }
        }

        public double MaxPuls
        {
            get { return maxPuls; }
        }

        public double MinPuls
        {
            get { return minPuls; }
        }

        public double MaxTemp
        {
            get { return maxTemp; }
        }

        public double MinTemp
        {
            get { return minTemp; }
        }

        public double MaxBlodtrykk
        {
            get { return maxBlodtrykk; }
        }

        public double MinBlodtrykk
        {
            get { return minBlodtrykk; }
        }

        public double MaxResp
        {
            get { return maxResp; }
        }

        public double MinResp
        {
            get { return minResp; }
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_2(object sender, EventArgs e)
        {

        }

        private void RegistrerPM_Load(object sender, EventArgs e)
        {

        }
    }
}
