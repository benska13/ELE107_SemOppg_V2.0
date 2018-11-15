namespace Sentral2
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.bgwVentPaKlient = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgwPasienter = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPasientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonwatchdog = new System.Windows.Forms.Button();
            this.txtboxwatchdog = new System.Windows.Forms.TextBox();
            this.buttonAvslutt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxResp = new System.Windows.Forms.GroupBox();
            this.lblBx4Enhet = new System.Windows.Forms.Label();
            this.lblBx4Max = new System.Windows.Forms.Label();
            this.txtBx4Verdi = new System.Windows.Forms.TextBox();
            this.lblBx4Min = new System.Windows.Forms.Label();
            this.gbxBlod = new System.Windows.Forms.GroupBox();
            this.lblBx3Enhet1 = new System.Windows.Forms.Label();
            this.txtBx3Verdi1 = new System.Windows.Forms.TextBox();
            this.lblBx3Enhet2 = new System.Windows.Forms.Label();
            this.lblBx3Max = new System.Windows.Forms.Label();
            this.txtBx3Verdi2 = new System.Windows.Forms.TextBox();
            this.lblBx3Min = new System.Windows.Forms.Label();
            this.gbxPuls = new System.Windows.Forms.GroupBox();
            this.lblBx2Enhet = new System.Windows.Forms.Label();
            this.lblBx2Max = new System.Windows.Forms.Label();
            this.txtBx2Verdi = new System.Windows.Forms.TextBox();
            this.lblBx2Min = new System.Windows.Forms.Label();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.lblBx1Enhet = new System.Windows.Forms.Label();
            this.lblBx1Max = new System.Windows.Forms.Label();
            this.txtBx1Verdi = new System.Windows.Forms.TextBox();
            this.lblBx1Min = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.Intervall = new System.Windows.Forms.Button();
            this.textBoxTidMaal = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTemp = new System.Windows.Forms.TabPage();
            this.listKroppstemperaturDataGridView = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listKroppstemperaturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpPuls = new System.Windows.Forms.TabPage();
            this.listKroppstemperaturDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpResp = new System.Windows.Forms.TabPage();
            this.listKroppstemperaturDataGridView2 = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRespirasjonsrateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpBlod = new System.Windows.Forms.TabPage();
            this.listKroppstemperaturDataGridView3 = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBlodtrykkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpAlarm = new System.Windows.Forms.TabPage();
            this.listAlarmDataGridView = new System.Windows.Forms.DataGridView();
            this.listPulsfrekvensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAlarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datoTidDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPasienter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPasientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxResp.SuspendLayout();
            this.gbxBlod.SuspendLayout();
            this.gbxPuls.SuspendLayout();
            this.gbxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturBindingSource)).BeginInit();
            this.tpPuls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView1)).BeginInit();
            this.tpResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRespirasjonsrateBindingSource)).BeginInit();
            this.tpBlod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBlodtrykkBindingSource)).BeginInit();
            this.tpAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarmDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPulsfrekvensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(226, 16);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // bgwVentPaKlient
            // 
            this.bgwVentPaKlient.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwVentPaKlient_DoWork);
            this.bgwVentPaKlient.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwVentPaKlient_RunWorkerCompleted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgwPasienter);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonwatchdog);
            this.splitContainer3.Panel2.Controls.Add(this.txtboxwatchdog);
            this.splitContainer3.Panel2.Controls.Add(this.buttonAvslutt);
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Size = new System.Drawing.Size(301, 450);
            this.splitContainer3.SplitterDistance = 185;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgwPasienter
            // 
            this.dgwPasienter.AllowUserToAddRows = false;
            this.dgwPasienter.AllowUserToDeleteRows = false;
            this.dgwPasienter.AutoGenerateColumns = false;
            this.dgwPasienter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPasienter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.navnDataGridViewTextBoxColumn,
            this.alderDataGridViewTextBoxColumn});
            this.dgwPasienter.DataSource = this.listPasientBindingSource;
            this.dgwPasienter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPasienter.Location = new System.Drawing.Point(0, 0);
            this.dgwPasienter.Name = "dgwPasienter";
            this.dgwPasienter.ReadOnly = true;
            this.dgwPasienter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPasienter.Size = new System.Drawing.Size(301, 185);
            this.dgwPasienter.TabIndex = 0;
            this.dgwPasienter.SelectionChanged += new System.EventHandler(this.dgwPasienter_SelectionChanged_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // navnDataGridViewTextBoxColumn
            // 
            this.navnDataGridViewTextBoxColumn.DataPropertyName = "Navn";
            this.navnDataGridViewTextBoxColumn.HeaderText = "Navn";
            this.navnDataGridViewTextBoxColumn.Name = "navnDataGridViewTextBoxColumn";
            this.navnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alderDataGridViewTextBoxColumn
            // 
            this.alderDataGridViewTextBoxColumn.DataPropertyName = "Alder";
            this.alderDataGridViewTextBoxColumn.HeaderText = "Alder";
            this.alderDataGridViewTextBoxColumn.Name = "alderDataGridViewTextBoxColumn";
            this.alderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listPasientBindingSource
            // 
            this.listPasientBindingSource.DataSource = typeof(LibaryPasient.ListPasient);
            // 
            // buttonwatchdog
            // 
            this.buttonwatchdog.BackColor = System.Drawing.Color.Lime;
            this.buttonwatchdog.Location = new System.Drawing.Point(11, 80);
            this.buttonwatchdog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonwatchdog.Name = "buttonwatchdog";
            this.buttonwatchdog.Size = new System.Drawing.Size(45, 43);
            this.buttonwatchdog.TabIndex = 3;
            this.buttonwatchdog.UseVisualStyleBackColor = false;
            // 
            // txtboxwatchdog
            // 
            this.txtboxwatchdog.Location = new System.Drawing.Point(83, 92);
            this.txtboxwatchdog.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxwatchdog.Name = "txtboxwatchdog";
            this.txtboxwatchdog.Size = new System.Drawing.Size(182, 20);
            this.txtboxwatchdog.TabIndex = 2;
            this.txtboxwatchdog.Text = "Manglet Signal fra Monitor X i over 20 sek";
            // 
            // buttonAvslutt
            // 
            this.buttonAvslutt.Location = new System.Drawing.Point(160, 32);
            this.buttonAvslutt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAvslutt.Name = "buttonAvslutt";
            this.buttonAvslutt.Size = new System.Drawing.Size(56, 19);
            this.buttonAvslutt.TabIndex = 1;
            this.buttonAvslutt.Text = "Avslutt";
            this.buttonAvslutt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(495, 450);
            this.splitContainer2.SplitterDistance = 121;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gbxResp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxBlod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxPuls, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxTemp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 121);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbxResp
            // 
            this.gbxResp.Controls.Add(this.lblBx4Enhet);
            this.gbxResp.Controls.Add(this.lblBx4Max);
            this.gbxResp.Controls.Add(this.txtBx4Verdi);
            this.gbxResp.Controls.Add(this.lblBx4Min);
            this.gbxResp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxResp.Location = new System.Drawing.Point(249, 3);
            this.gbxResp.Name = "gbxResp";
            this.gbxResp.Size = new System.Drawing.Size(117, 115);
            this.gbxResp.TabIndex = 3;
            this.gbxResp.TabStop = false;
            this.gbxResp.Text = "resp";
            this.gbxResp.MouseCaptureChanged += new System.EventHandler(this.gbxResp_MouseCaptureChanged);
            // 
            // lblBx4Enhet
            // 
            this.lblBx4Enhet.AutoSize = true;
            this.lblBx4Enhet.Location = new System.Drawing.Point(79, 49);
            this.lblBx4Enhet.Name = "lblBx4Enhet";
            this.lblBx4Enhet.Size = new System.Drawing.Size(41, 13);
            this.lblBx4Enhet.TabIndex = 3;
            this.lblBx4Enhet.Text = "label10";
            // 
            // lblBx4Max
            // 
            this.lblBx4Max.AutoSize = true;
            this.lblBx4Max.Location = new System.Drawing.Point(16, 69);
            this.lblBx4Max.Name = "lblBx4Max";
            this.lblBx4Max.Size = new System.Drawing.Size(41, 13);
            this.lblBx4Max.TabIndex = 2;
            this.lblBx4Max.Text = "label11";
            // 
            // txtBx4Verdi
            // 
            this.txtBx4Verdi.Location = new System.Drawing.Point(15, 46);
            this.txtBx4Verdi.Name = "txtBx4Verdi";
            this.txtBx4Verdi.Size = new System.Drawing.Size(57, 20);
            this.txtBx4Verdi.TabIndex = 1;
            // 
            // lblBx4Min
            // 
            this.lblBx4Min.AutoSize = true;
            this.lblBx4Min.Location = new System.Drawing.Point(16, 30);
            this.lblBx4Min.Name = "lblBx4Min";
            this.lblBx4Min.Size = new System.Drawing.Size(41, 13);
            this.lblBx4Min.TabIndex = 0;
            this.lblBx4Min.Text = "label12";
            // 
            // gbxBlod
            // 
            this.gbxBlod.Controls.Add(this.lblBx3Enhet1);
            this.gbxBlod.Controls.Add(this.txtBx3Verdi1);
            this.gbxBlod.Controls.Add(this.lblBx3Enhet2);
            this.gbxBlod.Controls.Add(this.lblBx3Max);
            this.gbxBlod.Controls.Add(this.txtBx3Verdi2);
            this.gbxBlod.Controls.Add(this.lblBx3Min);
            this.gbxBlod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBlod.Location = new System.Drawing.Point(372, 3);
            this.gbxBlod.Name = "gbxBlod";
            this.gbxBlod.Size = new System.Drawing.Size(120, 115);
            this.gbxBlod.TabIndex = 2;
            this.gbxBlod.TabStop = false;
            this.gbxBlod.Text = "blod";
            this.gbxBlod.MouseCaptureChanged += new System.EventHandler(this.gbxBlod_MouseCaptureChanged);
            // 
            // lblBx3Enhet1
            // 
            this.lblBx3Enhet1.AutoSize = true;
            this.lblBx3Enhet1.Location = new System.Drawing.Point(69, 46);
            this.lblBx3Enhet1.Name = "lblBx3Enhet1";
            this.lblBx3Enhet1.Size = new System.Drawing.Size(41, 13);
            this.lblBx3Enhet1.TabIndex = 5;
            this.lblBx3Enhet1.Text = "label13";
            // 
            // txtBx3Verdi1
            // 
            this.txtBx3Verdi1.Location = new System.Drawing.Point(6, 42);
            this.txtBx3Verdi1.Name = "txtBx3Verdi1";
            this.txtBx3Verdi1.Size = new System.Drawing.Size(57, 20);
            this.txtBx3Verdi1.TabIndex = 4;
            // 
            // lblBx3Enhet2
            // 
            this.lblBx3Enhet2.AutoSize = true;
            this.lblBx3Enhet2.Location = new System.Drawing.Point(69, 68);
            this.lblBx3Enhet2.Name = "lblBx3Enhet2";
            this.lblBx3Enhet2.Size = new System.Drawing.Size(35, 13);
            this.lblBx3Enhet2.TabIndex = 3;
            this.lblBx3Enhet2.Text = "label7";
            // 
            // lblBx3Max
            // 
            this.lblBx3Max.AutoSize = true;
            this.lblBx3Max.Location = new System.Drawing.Point(7, 88);
            this.lblBx3Max.Name = "lblBx3Max";
            this.lblBx3Max.Size = new System.Drawing.Size(35, 13);
            this.lblBx3Max.TabIndex = 2;
            this.lblBx3Max.Text = "label8";
            // 
            // txtBx3Verdi2
            // 
            this.txtBx3Verdi2.Location = new System.Drawing.Point(6, 65);
            this.txtBx3Verdi2.Name = "txtBx3Verdi2";
            this.txtBx3Verdi2.Size = new System.Drawing.Size(57, 20);
            this.txtBx3Verdi2.TabIndex = 1;
            // 
            // lblBx3Min
            // 
            this.lblBx3Min.AutoSize = true;
            this.lblBx3Min.Location = new System.Drawing.Point(7, 29);
            this.lblBx3Min.Name = "lblBx3Min";
            this.lblBx3Min.Size = new System.Drawing.Size(35, 13);
            this.lblBx3Min.TabIndex = 0;
            this.lblBx3Min.Text = "label9";
            // 
            // gbxPuls
            // 
            this.gbxPuls.Controls.Add(this.lblBx2Enhet);
            this.gbxPuls.Controls.Add(this.lblBx2Max);
            this.gbxPuls.Controls.Add(this.txtBx2Verdi);
            this.gbxPuls.Controls.Add(this.lblBx2Min);
            this.gbxPuls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPuls.Location = new System.Drawing.Point(3, 3);
            this.gbxPuls.Name = "gbxPuls";
            this.gbxPuls.Size = new System.Drawing.Size(117, 115);
            this.gbxPuls.TabIndex = 1;
            this.gbxPuls.TabStop = false;
            this.gbxPuls.Text = "puls";
            this.gbxPuls.MouseCaptureChanged += new System.EventHandler(this.gbxPuls_MouseCaptureChanged);
            // 
            // lblBx2Enhet
            // 
            this.lblBx2Enhet.AutoSize = true;
            this.lblBx2Enhet.Location = new System.Drawing.Point(81, 49);
            this.lblBx2Enhet.Name = "lblBx2Enhet";
            this.lblBx2Enhet.Size = new System.Drawing.Size(35, 13);
            this.lblBx2Enhet.TabIndex = 3;
            this.lblBx2Enhet.Text = "label4";
            // 
            // lblBx2Max
            // 
            this.lblBx2Max.AutoSize = true;
            this.lblBx2Max.Location = new System.Drawing.Point(19, 69);
            this.lblBx2Max.Name = "lblBx2Max";
            this.lblBx2Max.Size = new System.Drawing.Size(35, 13);
            this.lblBx2Max.TabIndex = 2;
            this.lblBx2Max.Text = "label5";
            // 
            // txtBx2Verdi
            // 
            this.txtBx2Verdi.Location = new System.Drawing.Point(18, 46);
            this.txtBx2Verdi.Name = "txtBx2Verdi";
            this.txtBx2Verdi.Size = new System.Drawing.Size(57, 20);
            this.txtBx2Verdi.TabIndex = 1;
            // 
            // lblBx2Min
            // 
            this.lblBx2Min.AutoSize = true;
            this.lblBx2Min.Location = new System.Drawing.Point(19, 30);
            this.lblBx2Min.Name = "lblBx2Min";
            this.lblBx2Min.Size = new System.Drawing.Size(35, 13);
            this.lblBx2Min.TabIndex = 0;
            this.lblBx2Min.Text = "label6";
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.lblBx1Enhet);
            this.gbxTemp.Controls.Add(this.lblBx1Max);
            this.gbxTemp.Controls.Add(this.txtBx1Verdi);
            this.gbxTemp.Controls.Add(this.lblBx1Min);
            this.gbxTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTemp.Location = new System.Drawing.Point(126, 3);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(117, 115);
            this.gbxTemp.TabIndex = 0;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "temp";
            this.gbxTemp.MouseCaptureChanged += new System.EventHandler(this.gbxTemp_MouseCaptureChanged);
            // 
            // lblBx1Enhet
            // 
            this.lblBx1Enhet.AutoSize = true;
            this.lblBx1Enhet.Location = new System.Drawing.Point(80, 49);
            this.lblBx1Enhet.Name = "lblBx1Enhet";
            this.lblBx1Enhet.Size = new System.Drawing.Size(35, 13);
            this.lblBx1Enhet.TabIndex = 3;
            this.lblBx1Enhet.Text = "label3";
            // 
            // lblBx1Max
            // 
            this.lblBx1Max.AutoSize = true;
            this.lblBx1Max.Location = new System.Drawing.Point(18, 69);
            this.lblBx1Max.Name = "lblBx1Max";
            this.lblBx1Max.Size = new System.Drawing.Size(35, 13);
            this.lblBx1Max.TabIndex = 2;
            this.lblBx1Max.Text = "label2";
            // 
            // txtBx1Verdi
            // 
            this.txtBx1Verdi.Location = new System.Drawing.Point(17, 46);
            this.txtBx1Verdi.Name = "txtBx1Verdi";
            this.txtBx1Verdi.Size = new System.Drawing.Size(57, 20);
            this.txtBx1Verdi.TabIndex = 1;
            // 
            // lblBx1Min
            // 
            this.lblBx1Min.AutoSize = true;
            this.lblBx1Min.Location = new System.Drawing.Point(18, 30);
            this.lblBx1Min.Name = "lblBx1Min";
            this.lblBx1Min.Size = new System.Drawing.Size(35, 13);
            this.lblBx1Min.TabIndex = 0;
            this.lblBx1Min.Text = "label1";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer4.Panel1.Controls.Add(this.dateTimePicker3);
            this.splitContainer4.Panel1.Controls.Add(this.Intervall);
            this.splitContainer4.Panel1.Controls.Add(this.textBoxTidMaal);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer4.Size = new System.Drawing.Size(495, 325);
            this.splitContainer4.SplitterDistance = 48;
            this.splitContainer4.TabIndex = 6;
            // 
            // Intervall
            // 
            this.Intervall.Location = new System.Drawing.Point(410, 16);
            this.Intervall.Name = "Intervall";
            this.Intervall.Size = new System.Drawing.Size(75, 23);
            this.Intervall.TabIndex = 2;
            this.Intervall.Text = "Intervall";
            this.Intervall.UseVisualStyleBackColor = true;
            this.Intervall.Click += new System.EventHandler(this.Intervall_Click);
            // 
            // textBoxTidMaal
            // 
            this.textBoxTidMaal.Location = new System.Drawing.Point(0, 2);
            this.textBoxTidMaal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTidMaal.Name = "textBoxTidMaal";
            this.textBoxTidMaal.Size = new System.Drawing.Size(76, 20);
            this.textBoxTidMaal.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTemp);
            this.tabControl1.Controls.Add(this.tpPuls);
            this.tabControl1.Controls.Add(this.tpResp);
            this.tabControl1.Controls.Add(this.tpBlod);
            this.tabControl1.Controls.Add(this.tpAlarm);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTemp
            // 
            this.tpTemp.Controls.Add(this.listKroppstemperaturDataGridView);
            this.tpTemp.Location = new System.Drawing.Point(4, 22);
            this.tpTemp.Name = "tpTemp";
            this.tpTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tpTemp.Size = new System.Drawing.Size(487, 247);
            this.tpTemp.TabIndex = 0;
            this.tpTemp.Text = "temp";
            this.tpTemp.UseVisualStyleBackColor = true;
            // 
            // listKroppstemperaturDataGridView
            // 
            this.listKroppstemperaturDataGridView.AutoGenerateColumns = false;
            this.listKroppstemperaturDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listKroppstemperaturDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn,
            this.enhetDataGridViewTextBoxColumn,
            this.datoTidDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.listKroppstemperaturDataGridView.DataSource = this.listKroppstemperaturBindingSource;
            this.listKroppstemperaturDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKroppstemperaturDataGridView.Location = new System.Drawing.Point(3, 3);
            this.listKroppstemperaturDataGridView.Name = "listKroppstemperaturDataGridView";
            this.listKroppstemperaturDataGridView.Size = new System.Drawing.Size(481, 241);
            this.listKroppstemperaturDataGridView.TabIndex = 0;
            // 
            // verdiDataGridViewTextBoxColumn
            // 
            this.verdiDataGridViewTextBoxColumn.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn.Name = "verdiDataGridViewTextBoxColumn";
            this.verdiDataGridViewTextBoxColumn.Width = 50;
            // 
            // enhetDataGridViewTextBoxColumn
            // 
            this.enhetDataGridViewTextBoxColumn.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn.Name = "enhetDataGridViewTextBoxColumn";
            this.enhetDataGridViewTextBoxColumn.ReadOnly = true;
            this.enhetDataGridViewTextBoxColumn.Width = 50;
            // 
            // datoTidDataGridViewTextBoxColumn
            // 
            this.datoTidDataGridViewTextBoxColumn.DataPropertyName = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn.HeaderText = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn.Name = "datoTidDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.Width = 50;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.Width = 50;
            // 
            // listKroppstemperaturBindingSource
            // 
            this.listKroppstemperaturBindingSource.DataSource = typeof(LibaryPasient.Kroppstemperaturx);
            // 
            // tpPuls
            // 
            this.tpPuls.Controls.Add(this.listKroppstemperaturDataGridView1);
            this.tpPuls.Location = new System.Drawing.Point(4, 22);
            this.tpPuls.Name = "tpPuls";
            this.tpPuls.Padding = new System.Windows.Forms.Padding(3);
            this.tpPuls.Size = new System.Drawing.Size(487, 247);
            this.tpPuls.TabIndex = 1;
            this.tpPuls.Text = "puls";
            this.tpPuls.UseVisualStyleBackColor = true;
            // 
            // listKroppstemperaturDataGridView1
            // 
            this.listKroppstemperaturDataGridView1.AutoGenerateColumns = false;
            this.listKroppstemperaturDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listKroppstemperaturDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn1,
            this.enhetDataGridViewTextBoxColumn1,
            this.datoTidDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.listKroppstemperaturDataGridView1.DataSource = this.listPulsfrekvensBindingSource;
            this.listKroppstemperaturDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKroppstemperaturDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.listKroppstemperaturDataGridView1.Name = "listKroppstemperaturDataGridView1";
            this.listKroppstemperaturDataGridView1.Size = new System.Drawing.Size(481, 241);
            this.listKroppstemperaturDataGridView1.TabIndex = 0;
            // 
            // tpResp
            // 
            this.tpResp.Controls.Add(this.listKroppstemperaturDataGridView2);
            this.tpResp.Location = new System.Drawing.Point(4, 22);
            this.tpResp.Name = "tpResp";
            this.tpResp.Padding = new System.Windows.Forms.Padding(3);
            this.tpResp.Size = new System.Drawing.Size(487, 247);
            this.tpResp.TabIndex = 2;
            this.tpResp.Text = "resp";
            this.tpResp.UseVisualStyleBackColor = true;
            // 
            // listKroppstemperaturDataGridView2
            // 
            this.listKroppstemperaturDataGridView2.AutoGenerateColumns = false;
            this.listKroppstemperaturDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listKroppstemperaturDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn2,
            this.enhetDataGridViewTextBoxColumn2,
            this.datoTidDataGridViewTextBoxColumn2,
            this.minDataGridViewTextBoxColumn2,
            this.maxDataGridViewTextBoxColumn2});
            this.listKroppstemperaturDataGridView2.DataSource = this.listRespirasjonsrateBindingSource;
            this.listKroppstemperaturDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKroppstemperaturDataGridView2.Location = new System.Drawing.Point(3, 3);
            this.listKroppstemperaturDataGridView2.Name = "listKroppstemperaturDataGridView2";
            this.listKroppstemperaturDataGridView2.Size = new System.Drawing.Size(481, 241);
            this.listKroppstemperaturDataGridView2.TabIndex = 0;
            // 
            // verdiDataGridViewTextBoxColumn2
            // 
            this.verdiDataGridViewTextBoxColumn2.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn2.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn2.Name = "verdiDataGridViewTextBoxColumn2";
            this.verdiDataGridViewTextBoxColumn2.Width = 50;
            // 
            // enhetDataGridViewTextBoxColumn2
            // 
            this.enhetDataGridViewTextBoxColumn2.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn2.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn2.Name = "enhetDataGridViewTextBoxColumn2";
            this.enhetDataGridViewTextBoxColumn2.ReadOnly = true;
            this.enhetDataGridViewTextBoxColumn2.Width = 50;
            // 
            // datoTidDataGridViewTextBoxColumn2
            // 
            this.datoTidDataGridViewTextBoxColumn2.DataPropertyName = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn2.HeaderText = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn2.Name = "datoTidDataGridViewTextBoxColumn2";
            // 
            // minDataGridViewTextBoxColumn2
            // 
            this.minDataGridViewTextBoxColumn2.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn2.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn2.Name = "minDataGridViewTextBoxColumn2";
            this.minDataGridViewTextBoxColumn2.Width = 50;
            // 
            // maxDataGridViewTextBoxColumn2
            // 
            this.maxDataGridViewTextBoxColumn2.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn2.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn2.Name = "maxDataGridViewTextBoxColumn2";
            this.maxDataGridViewTextBoxColumn2.Width = 50;
            // 
            // listRespirasjonsrateBindingSource
            // 
            this.listRespirasjonsrateBindingSource.DataSource = typeof(LibaryPasient.Respirasjonsrate);
            // 
            // tpBlod
            // 
            this.tpBlod.AutoScroll = true;
            this.tpBlod.Controls.Add(this.listKroppstemperaturDataGridView3);
            this.tpBlod.Location = new System.Drawing.Point(4, 22);
            this.tpBlod.Name = "tpBlod";
            this.tpBlod.Padding = new System.Windows.Forms.Padding(3);
            this.tpBlod.Size = new System.Drawing.Size(487, 247);
            this.tpBlod.TabIndex = 3;
            this.tpBlod.Text = "blod";
            this.tpBlod.UseVisualStyleBackColor = true;
            // 
            // listKroppstemperaturDataGridView3
            // 
            this.listKroppstemperaturDataGridView3.AutoGenerateColumns = false;
            this.listKroppstemperaturDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listKroppstemperaturDataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn3,
            this.enhetDataGridViewTextBoxColumn3,
            this.datoTidDataGridViewTextBoxColumn3,
            this.minDataGridViewTextBoxColumn3,
            this.maxDataGridViewTextBoxColumn3});
            this.listKroppstemperaturDataGridView3.DataSource = this.listBlodtrykkBindingSource;
            this.listKroppstemperaturDataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKroppstemperaturDataGridView3.Location = new System.Drawing.Point(3, 3);
            this.listKroppstemperaturDataGridView3.Name = "listKroppstemperaturDataGridView3";
            this.listKroppstemperaturDataGridView3.Size = new System.Drawing.Size(481, 241);
            this.listKroppstemperaturDataGridView3.TabIndex = 0;
            // 
            // verdiDataGridViewTextBoxColumn3
            // 
            this.verdiDataGridViewTextBoxColumn3.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn3.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn3.Name = "verdiDataGridViewTextBoxColumn3";
            this.verdiDataGridViewTextBoxColumn3.Width = 50;
            // 
            // enhetDataGridViewTextBoxColumn3
            // 
            this.enhetDataGridViewTextBoxColumn3.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn3.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn3.Name = "enhetDataGridViewTextBoxColumn3";
            this.enhetDataGridViewTextBoxColumn3.ReadOnly = true;
            this.enhetDataGridViewTextBoxColumn3.Width = 50;
            // 
            // datoTidDataGridViewTextBoxColumn3
            // 
            this.datoTidDataGridViewTextBoxColumn3.DataPropertyName = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn3.HeaderText = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn3.Name = "datoTidDataGridViewTextBoxColumn3";
            // 
            // minDataGridViewTextBoxColumn3
            // 
            this.minDataGridViewTextBoxColumn3.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn3.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn3.Name = "minDataGridViewTextBoxColumn3";
            this.minDataGridViewTextBoxColumn3.Width = 50;
            // 
            // maxDataGridViewTextBoxColumn3
            // 
            this.maxDataGridViewTextBoxColumn3.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn3.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn3.Name = "maxDataGridViewTextBoxColumn3";
            this.maxDataGridViewTextBoxColumn3.Width = 50;
            // 
            // listBlodtrykkBindingSource
            // 
            this.listBlodtrykkBindingSource.DataSource = typeof(LibaryPasient.Blodtrykk);
            // 
            // tpAlarm
            // 
            this.tpAlarm.AutoScroll = true;
            this.tpAlarm.Controls.Add(this.listAlarmDataGridView);
            this.tpAlarm.Location = new System.Drawing.Point(4, 22);
            this.tpAlarm.Name = "tpAlarm";
            this.tpAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlarm.Size = new System.Drawing.Size(487, 247);
            this.tpAlarm.TabIndex = 4;
            this.tpAlarm.Text = "Alarm";
            this.tpAlarm.UseVisualStyleBackColor = true;
            // 
            // listAlarmDataGridView
            // 
            this.listAlarmDataGridView.AutoGenerateColumns = false;
            this.listAlarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAlarmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datoTidDataGridViewTextBoxColumn4,
            this.idDataGridViewTextBoxColumn1});
            this.listAlarmDataGridView.DataSource = this.listAlarmBindingSource;
            this.listAlarmDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAlarmDataGridView.Location = new System.Drawing.Point(3, 3);
            this.listAlarmDataGridView.Name = "listAlarmDataGridView";
            this.listAlarmDataGridView.Size = new System.Drawing.Size(481, 241);
            this.listAlarmDataGridView.TabIndex = 0;
            // 
            // listPulsfrekvensBindingSource
            // 
            this.listPulsfrekvensBindingSource.DataMember = "ListPulsfrekvens";
            this.listPulsfrekvensBindingSource.DataSource = this.listPasientBindingSource;
            // 
            // verdiDataGridViewTextBoxColumn1
            // 
            this.verdiDataGridViewTextBoxColumn1.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn1.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn1.Name = "verdiDataGridViewTextBoxColumn1";
            // 
            // enhetDataGridViewTextBoxColumn1
            // 
            this.enhetDataGridViewTextBoxColumn1.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn1.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn1.Name = "enhetDataGridViewTextBoxColumn1";
            this.enhetDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datoTidDataGridViewTextBoxColumn1
            // 
            this.datoTidDataGridViewTextBoxColumn1.DataPropertyName = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn1.HeaderText = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn1.Name = "datoTidDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            // 
            // listAlarmBindingSource
            // 
            this.listAlarmBindingSource.DataMember = "ListAlarm";
            this.listAlarmBindingSource.DataSource = this.listPasientBindingSource;
            // 
            // datoTidDataGridViewTextBoxColumn4
            // 
            this.datoTidDataGridViewTextBoxColumn4.DataPropertyName = "datoTid";
            this.datoTidDataGridViewTextBoxColumn4.HeaderText = "datoTid";
            this.datoTidDataGridViewTextBoxColumn4.Name = "datoTidDataGridViewTextBoxColumn4";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPasienter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPasientBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxResp.ResumeLayout(false);
            this.gbxResp.PerformLayout();
            this.gbxBlod.ResumeLayout(false);
            this.gbxBlod.PerformLayout();
            this.gbxPuls.ResumeLayout(false);
            this.gbxPuls.PerformLayout();
            this.gbxTemp.ResumeLayout(false);
            this.gbxTemp.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturBindingSource)).EndInit();
            this.tpPuls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView1)).EndInit();
            this.tpResp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRespirasjonsrateBindingSource)).EndInit();
            this.tpBlod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBlodtrykkBindingSource)).EndInit();
            this.tpAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listAlarmDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPulsfrekvensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.ComponentModel.BackgroundWorker bgwVentPaKlient;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgwPasienter;
        private System.Windows.Forms.Button buttonwatchdog;
        private System.Windows.Forms.TextBox txtboxwatchdog;
        private System.Windows.Forms.Button buttonAvslutt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button Intervall;
        private System.Windows.Forms.TextBox textBoxTidMaal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTemp;
        private System.Windows.Forms.DataGridView listKroppstemperaturDataGridView;
        private System.Windows.Forms.TabPage tpPuls;
        private System.Windows.Forms.DataGridView listKroppstemperaturDataGridView1;
        private System.Windows.Forms.TabPage tpResp;
        private System.Windows.Forms.DataGridView listKroppstemperaturDataGridView2;
        private System.Windows.Forms.TabPage tpBlod;
        private System.Windows.Forms.DataGridView listKroppstemperaturDataGridView3;
        private System.Windows.Forms.TabPage tpAlarm;
        private System.Windows.Forms.BindingSource listPasientBindingSource;
        private System.Windows.Forms.BindingSource listKroppstemperaturBindingSource;
        private System.Windows.Forms.BindingSource listRespirasjonsrateBindingSource;
        private System.Windows.Forms.BindingSource listBlodtrykkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alderDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxResp;
        private System.Windows.Forms.Label lblBx4Enhet;
        private System.Windows.Forms.Label lblBx4Max;
        private System.Windows.Forms.TextBox txtBx4Verdi;
        private System.Windows.Forms.Label lblBx4Min;
        private System.Windows.Forms.GroupBox gbxBlod;
        private System.Windows.Forms.Label lblBx3Enhet1;
        private System.Windows.Forms.TextBox txtBx3Verdi1;
        private System.Windows.Forms.Label lblBx3Enhet2;
        private System.Windows.Forms.Label lblBx3Max;
        private System.Windows.Forms.TextBox txtBx3Verdi2;
        private System.Windows.Forms.Label lblBx3Min;
        private System.Windows.Forms.GroupBox gbxPuls;
        private System.Windows.Forms.Label lblBx2Enhet;
        private System.Windows.Forms.Label lblBx2Max;
        private System.Windows.Forms.TextBox txtBx2Verdi;
        private System.Windows.Forms.Label lblBx2Min;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.Label lblBx1Enhet;
        private System.Windows.Forms.Label lblBx1Max;
        private System.Windows.Forms.TextBox txtBx1Verdi;
        private System.Windows.Forms.Label lblBx1Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource listPulsfrekvensBindingSource;
        private System.Windows.Forms.DataGridView listAlarmDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource listAlarmBindingSource;
    }
}

