namespace Monitor
{
    partial class Pasientmonitor
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
            this.registrerPasientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velgComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_cbComPorter = new System.Windows.Forms.ToolStripComboBox();
            this.kobleTilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kobleTilSentralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBlodtrykk2 = new System.Windows.Forms.TextBox();
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
            this.txtAlarmHendelse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSentralInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComInfo = new System.Windows.Forms.TextBox();
            this.txtSisteStatus = new System.Windows.Forms.TextBox();
            this.btnGrense = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasientNavn = new System.Windows.Forms.TextBox();
            this.txtPasientAlder = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 98;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtBlodtrykk2);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaxResp);
            this.splitContainer1.Panel1.Controls.Add(this.labelMinResp);
            this.splitContainer1.Panel1.Controls.Add(this.txtResp);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaxTemp);
            this.splitContainer1.Panel1.Controls.Add(this.labelMinTemp);
            this.splitContainer1.Panel1.Controls.Add(this.txtTemp);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaxBlod);
            this.splitContainer1.Panel1.Controls.Add(this.labelMinBlod);
            this.splitContainer1.Panel1.Controls.Add(this.txtBlodtrykk);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaxPuls);
            this.splitContainer1.Panel1.Controls.Add(this.labelMinPuls);
            this.splitContainer1.Panel1.Controls.Add(this.txtPuls);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtAlarmHendelse);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.txtSentralInfo);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtComInfo);
            this.splitContainer1.Panel2.Controls.Add(this.txtSisteStatus);
            this.splitContainer1.Panel2.Controls.Add(this.btnGrense);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlarm);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtPasientNavn);
            this.splitContainer1.Panel2.Controls.Add(this.txtPasientAlder);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Size = new System.Drawing.Size(492, 372);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 107;
            // 
            // txtBlodtrykk2
            // 
            this.txtBlodtrykk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlodtrykk2.Location = new System.Drawing.Point(30, 142);
            this.txtBlodtrykk2.Name = "txtBlodtrykk2";
            this.txtBlodtrykk2.Size = new System.Drawing.Size(192, 38);
            this.txtBlodtrykk2.TabIndex = 123;
            // 
            // labelMaxResp
            // 
            this.labelMaxResp.AutoSize = true;
            this.labelMaxResp.Location = new System.Drawing.Point(228, 311);
            this.labelMaxResp.Name = "labelMaxResp";
            this.labelMaxResp.Size = new System.Drawing.Size(13, 13);
            this.labelMaxResp.TabIndex = 122;
            this.labelMaxResp.Text = "--";
            // 
            // labelMinResp
            // 
            this.labelMinResp.AutoSize = true;
            this.labelMinResp.Location = new System.Drawing.Point(228, 286);
            this.labelMinResp.Name = "labelMinResp";
            this.labelMinResp.Size = new System.Drawing.Size(13, 13);
            this.labelMinResp.TabIndex = 121;
            this.labelMinResp.Text = "--";
            // 
            // txtResp
            // 
            this.txtResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp.Location = new System.Drawing.Point(30, 286);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(192, 38);
            this.txtResp.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 119;
            this.label13.Text = "Respirasjonrate:";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Location = new System.Drawing.Point(228, 237);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(13, 13);
            this.labelMaxTemp.TabIndex = 118;
            this.labelMaxTemp.Text = "--";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Location = new System.Drawing.Point(228, 212);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(13, 13);
            this.labelMinTemp.TabIndex = 117;
            this.labelMinTemp.Text = "--";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(30, 212);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(192, 38);
            this.txtTemp.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "Kroppstemperatur:";
            // 
            // labelMaxBlod
            // 
            this.labelMaxBlod.AutoSize = true;
            this.labelMaxBlod.Location = new System.Drawing.Point(228, 151);
            this.labelMaxBlod.Name = "labelMaxBlod";
            this.labelMaxBlod.Size = new System.Drawing.Size(13, 13);
            this.labelMaxBlod.TabIndex = 114;
            this.labelMaxBlod.Text = "--";
            // 
            // labelMinBlod
            // 
            this.labelMinBlod.AutoSize = true;
            this.labelMinBlod.Location = new System.Drawing.Point(228, 121);
            this.labelMinBlod.Name = "labelMinBlod";
            this.labelMinBlod.Size = new System.Drawing.Size(13, 13);
            this.labelMinBlod.TabIndex = 113;
            this.labelMinBlod.Text = "--";
            // 
            // txtBlodtrykk
            // 
            this.txtBlodtrykk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlodtrykk.Location = new System.Drawing.Point(30, 103);
            this.txtBlodtrykk.Name = "txtBlodtrykk";
            this.txtBlodtrykk.Size = new System.Drawing.Size(192, 38);
            this.txtBlodtrykk.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Blodtrykk:";
            // 
            // labelMaxPuls
            // 
            this.labelMaxPuls.AutoSize = true;
            this.labelMaxPuls.Location = new System.Drawing.Point(228, 58);
            this.labelMaxPuls.Name = "labelMaxPuls";
            this.labelMaxPuls.Size = new System.Drawing.Size(13, 13);
            this.labelMaxPuls.TabIndex = 110;
            this.labelMaxPuls.Text = "--";
            // 
            // labelMinPuls
            // 
            this.labelMinPuls.AutoSize = true;
            this.labelMinPuls.Location = new System.Drawing.Point(228, 33);
            this.labelMinPuls.Name = "labelMinPuls";
            this.labelMinPuls.Size = new System.Drawing.Size(13, 13);
            this.labelMinPuls.TabIndex = 109;
            this.labelMinPuls.Text = "--";
            // 
            // txtPuls
            // 
            this.txtPuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuls.Location = new System.Drawing.Point(30, 33);
            this.txtPuls.Name = "txtPuls";
            this.txtPuls.Size = new System.Drawing.Size(192, 38);
            this.txtPuls.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Pulsfrekvens:";
            // 
            // txtAlarmHendelse
            // 
            this.txtAlarmHendelse.Location = new System.Drawing.Point(37, 241);
            this.txtAlarmHendelse.Name = "txtAlarmHendelse";
            this.txtAlarmHendelse.Size = new System.Drawing.Size(100, 20);
            this.txtAlarmHendelse.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 117;
            this.label11.Text = "Sentral:";
            // 
            // txtSentralInfo
            // 
            this.txtSentralInfo.Location = new System.Drawing.Point(92, 317);
            this.txtSentralInfo.Name = "txtSentralInfo";
            this.txtSentralInfo.Size = new System.Drawing.Size(100, 20);
            this.txtSentralInfo.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 115;
            this.label9.Text = "Com port:";
            // 
            // txtComInfo
            // 
            this.txtComInfo.Location = new System.Drawing.Point(92, 291);
            this.txtComInfo.Name = "txtComInfo";
            this.txtComInfo.Size = new System.Drawing.Size(100, 20);
            this.txtComInfo.TabIndex = 113;
            // 
            // txtSisteStatus
            // 
            this.txtSisteStatus.Location = new System.Drawing.Point(37, 157);
            this.txtSisteStatus.Name = "txtSisteStatus";
            this.txtSisteStatus.Size = new System.Drawing.Size(147, 20);
            this.txtSisteStatus.TabIndex = 112;
            // 
            // btnGrense
            // 
            this.btnGrense.Location = new System.Drawing.Point(37, 183);
            this.btnGrense.Name = "btnGrense";
            this.btnGrense.Size = new System.Drawing.Size(122, 23);
            this.btnGrense.TabIndex = 111;
            this.btnGrense.Text = "UTENFOR GRENSE";
            this.btnGrense.UseVisualStyleBackColor = true;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(37, 212);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(122, 23);
            this.btnAlarm.TabIndex = 110;
            this.btnAlarm.Text = "Alarm ";
            this.btnAlarm.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Siste status mottatt:";
            // 
            // txtPasientNavn
            // 
            this.txtPasientNavn.Enabled = false;
            this.txtPasientNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasientNavn.Location = new System.Drawing.Point(37, 33);
            this.txtPasientNavn.Name = "txtPasientNavn";
            this.txtPasientNavn.Size = new System.Drawing.Size(100, 26);
            this.txtPasientNavn.TabIndex = 109;
            // 
            // txtPasientAlder
            // 
            this.txtPasientAlder.Enabled = false;
            this.txtPasientAlder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasientAlder.Location = new System.Drawing.Point(37, 82);
            this.txtPasientAlder.Name = "txtPasientAlder";
            this.txtPasientAlder.Size = new System.Drawing.Size(100, 26);
            this.txtPasientAlder.TabIndex = 108;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 107;
            this.label18.Text = "Alder:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 106;
            this.label17.Text = "Pasient navn:";
            // 
            // Pasientmonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 396);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Pasientmonitor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem registrerPasientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velgComPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ts_cbComPorter;
        private System.Windows.Forms.ToolStripMenuItem kobleTilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kobleTilSentralToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtBlodtrykk2;
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
        private System.Windows.Forms.TextBox txtAlarmHendelse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSentralInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComInfo;
        private System.Windows.Forms.TextBox txtSisteStatus;
        private System.Windows.Forms.Button btnGrense;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasientNavn;
        private System.Windows.Forms.TextBox txtPasientAlder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

