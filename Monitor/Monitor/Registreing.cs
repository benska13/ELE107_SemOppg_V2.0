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

        public string Navn { get; set; }

        public string Alder { get; set; }

        public double MaxPuls { get; set; }

        public double MinPuls { get; set; }

        public double MaxTemp { get; set; }

        public double MinTemp { get; set; }

        public double MaxBlodtrykk { get; set; }

        public double MinBlodtrykk { get; set; }

        public double MaxResp { get; set; }

        public double MinResp { get; set; }

        private void btnOk_Click_3(object sender, EventArgs e)
        {
            Navn = txtNavn.Text;
            Alder = (txtAlder.Text);
            MaxPuls = int.Parse(txtMaxPuls.Text);
            MinPuls = int.Parse(txtMinPuls.Text);
            MaxTemp = int.Parse(txtMaxTemp.Text);
            MinTemp = int.Parse(txtMinTemp.Text);
            MaxBlodtrykk = int.Parse(txtMaxBlodtrykk.Text);
            MinBlodtrykk = int.Parse(txtMinBlodtrykk.Text);
            MaxResp = int.Parse(txtMaxResp.Text);
            MinResp = int.Parse(txtMinResp.Text);

            this.Close();
        }
    }
}
