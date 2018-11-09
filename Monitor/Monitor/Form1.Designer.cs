namespace Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.txtSentralInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGrense = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.registrerPasientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velgComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_cbComPorter = new System.Windows.Forms.ToolStripComboBox();
            this.kobleTilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasientNavn = new System.Windows.Forms.TextBox();
            this.txtPasientAlder = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelMaxResp = new System.Windows.Forms.Label();
            this.labelMinResp = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMaxBlod = new System.Windows.Forms.Label();
            this.labelMinBlod = new System.Windows.Forms.Label();
            this.txtBlodtrykk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaxPuls = new System.Windows.Forms.Label();
            this.labelMinPuls = new System.Windows.Forms.Label();
            this.txtPuls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kobleTilSentralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWLesData = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Sentral:";
            // 
            // txtSentralInfo
            // 
            this.txtSentralInfo.Location = new System.Drawing.Point(94, 380);
            this.txtSentralInfo.Name = "txtSentralInfo";
            this.txtSentralInfo.Size = new System.Drawing.Size(100, 20);
            this.txtSentralInfo.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Com port:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 100;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 99;
            // 
            // btnGrense
            // 
            this.btnGrense.Location = new System.Drawing.Point(445, 230);
            this.btnGrense.Name = "btnGrense";
            this.btnGrense.Size = new System.Drawing.Size(122, 23);
            this.btnGrense.TabIndex = 97;
            this.btnGrense.Text = "UTENFOR GRENSE";
            this.btnGrense.UseVisualStyleBackColor = true;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(445, 259);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(122, 23);
            this.btnAlarm.TabIndex = 96;
            this.btnAlarm.Text = "Alarm (av)";
            this.btnAlarm.UseVisualStyleBackColor = true;
            // 
            // registrerPasientToolStripMenuItem
            // 
            this.registrerPasientToolStripMenuItem.Name = "registrerPasientToolStripMenuItem";
            this.registrerPasientToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.registrerPasientToolStripMenuItem.Text = "Registrer pasient";
            this.registrerPasientToolStripMenuItem.Click += new System.EventHandler(this.registrerPasientToolStripMenuItem_Click);
            // 
            // velgComPortToolStripMenuItem
            // 
            this.velgComPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_cbComPorter,
            this.kobleTilToolStripMenuItem});
            this.velgComPortToolStripMenuItem.Name = "velgComPortToolStripMenuItem";
            this.velgComPortToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.velgComPortToolStripMenuItem.Text = "com port";
            this.velgComPortToolStripMenuItem.Click += new System.EventHandler(this.velgComPortToolStripMenuItem_Click);
            // 
            // ts_cbComPorter
            // 
            this.ts_cbComPorter.Name = "ts_cbComPorter";
            this.ts_cbComPorter.Size = new System.Drawing.Size(121, 23);
            // 
            // kobleTilToolStripMenuItem
            // 
            this.kobleTilToolStripMenuItem.Name = "kobleTilToolStripMenuItem";
            this.kobleTilToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kobleTilToolStripMenuItem.Text = "Koble til";
            this.kobleTilToolStripMenuItem.Click += new System.EventHandler(this.kobleTilToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Siste status mottatt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Slag/min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Slag/min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Slag/min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Slag/min";
            // 
            // txtPasientNavn
            // 
            this.txtPasientNavn.Enabled = false;
            this.txtPasientNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasientNavn.Location = new System.Drawing.Point(141, 102);
            this.txtPasientNavn.Name = "txtPasientNavn";
            this.txtPasientNavn.Size = new System.Drawing.Size(100, 26);
            this.txtPasientNavn.TabIndex = 91;
            // 
            // txtPasientAlder
            // 
            this.txtPasientAlder.Enabled = false;
            this.txtPasientAlder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasientAlder.Location = new System.Drawing.Point(317, 102);
            this.txtPasientAlder.Name = "txtPasientAlder";
            this.txtPasientAlder.Size = new System.Drawing.Size(100, 26);
            this.txtPasientAlder.TabIndex = 90;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(261, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 89;
            this.label18.Text = "Alder:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(42, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 88;
            this.label17.Text = "Pasient navn:";
            // 
            // labelMaxResp
            // 
            this.labelMaxResp.AutoSize = true;
            this.labelMaxResp.Location = new System.Drawing.Point(387, 262);
            this.labelMaxResp.Name = "labelMaxResp";
            this.labelMaxResp.Size = new System.Drawing.Size(13, 13);
            this.labelMaxResp.TabIndex = 87;
            this.labelMaxResp.Text = "--";
            // 
            // labelMinResp
            // 
            this.labelMinResp.AutoSize = true;
            this.labelMinResp.Location = new System.Drawing.Point(314, 262);
            this.labelMinResp.Name = "labelMinResp";
            this.labelMinResp.Size = new System.Drawing.Size(13, 13);
            this.labelMinResp.TabIndex = 86;
            this.labelMinResp.Text = "--";
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(141, 259);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(91, 20);
            this.txtResp.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 84;
            this.label13.Text = "Respirasjonrate:";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Location = new System.Drawing.Point(387, 226);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(13, 13);
            this.labelMaxTemp.TabIndex = 83;
            this.labelMaxTemp.Text = "--";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Location = new System.Drawing.Point(314, 226);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(13, 13);
            this.labelMinTemp.TabIndex = 82;
            this.labelMinTemp.Text = "--";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(141, 223);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(91, 20);
            this.txtTemp.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Kroppstemperatur:";
            // 
            // labelMaxBlod
            // 
            this.labelMaxBlod.AutoSize = true;
            this.labelMaxBlod.Location = new System.Drawing.Point(387, 189);
            this.labelMaxBlod.Name = "labelMaxBlod";
            this.labelMaxBlod.Size = new System.Drawing.Size(13, 13);
            this.labelMaxBlod.TabIndex = 79;
            this.labelMaxBlod.Text = "--";
            // 
            // labelMinBlod
            // 
            this.labelMinBlod.AutoSize = true;
            this.labelMinBlod.Location = new System.Drawing.Point(314, 189);
            this.labelMinBlod.Name = "labelMinBlod";
            this.labelMinBlod.Size = new System.Drawing.Size(13, 13);
            this.labelMinBlod.TabIndex = 78;
            this.labelMinBlod.Text = "--";
            // 
            // txtBlodtrykk
            // 
            this.txtBlodtrykk.Location = new System.Drawing.Point(141, 186);
            this.txtBlodtrykk.Name = "txtBlodtrykk";
            this.txtBlodtrykk.Size = new System.Drawing.Size(91, 20);
            this.txtBlodtrykk.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Blodtrykk:";
            // 
            // labelMaxPuls
            // 
            this.labelMaxPuls.AutoSize = true;
            this.labelMaxPuls.Location = new System.Drawing.Point(387, 150);
            this.labelMaxPuls.Name = "labelMaxPuls";
            this.labelMaxPuls.Size = new System.Drawing.Size(13, 13);
            this.labelMaxPuls.TabIndex = 75;
            this.labelMaxPuls.Text = "--";
            // 
            // labelMinPuls
            // 
            this.labelMinPuls.AutoSize = true;
            this.labelMinPuls.Location = new System.Drawing.Point(314, 150);
            this.labelMinPuls.Name = "labelMinPuls";
            this.labelMinPuls.Size = new System.Drawing.Size(13, 13);
            this.labelMinPuls.TabIndex = 74;
            this.labelMinPuls.Text = "--";
            // 
            // txtPuls
            // 
            this.txtPuls.Location = new System.Drawing.Point(141, 147);
            this.txtPuls.Name = "txtPuls";
            this.txtPuls.Size = new System.Drawing.Size(91, 20);
            this.txtPuls.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Pulsfrekvens:";
            // 
            // kobleTilSentralToolStripMenuItem
            // 
            this.kobleTilSentralToolStripMenuItem.Name = "kobleTilSentralToolStripMenuItem";
            this.kobleTilSentralToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.kobleTilSentralToolStripMenuItem.Text = "Koble til sentral";
            this.kobleTilSentralToolStripMenuItem.Click += new System.EventHandler(this.kobleTilSentralToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrerPasientToolStripMenuItem,
            this.velgComPortToolStripMenuItem,
            this.kobleTilSentralToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 98;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSentralInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGrense);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasientNavn);
            this.Controls.Add(this.txtPasientAlder);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelMaxResp);
            this.Controls.Add(this.labelMinResp);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelMaxBlod);
            this.Controls.Add(this.labelMinBlod);
            this.Controls.Add(this.txtBlodtrykk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMaxPuls);
            this.Controls.Add(this.labelMinPuls);
            this.Controls.Add(this.txtPuls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSentralInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGrense;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.ToolStripMenuItem registrerPasientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velgComPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ts_cbComPorter;
        private System.Windows.Forms.ToolStripMenuItem kobleTilToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasientNavn;
        private System.Windows.Forms.TextBox txtPasientAlder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelMaxResp;
        private System.Windows.Forms.Label labelMinResp;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMaxBlod;
        private System.Windows.Forms.Label labelMinBlod;
        private System.Windows.Forms.TextBox txtBlodtrykk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaxPuls;
        private System.Windows.Forms.Label labelMinPuls;
        private System.Windows.Forms.TextBox txtPuls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem kobleTilSentralToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgWLesData;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

