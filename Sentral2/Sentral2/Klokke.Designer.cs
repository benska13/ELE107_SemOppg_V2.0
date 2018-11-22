namespace Sentral2
{
    partial class Klokke
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabtemp = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listKroppstemperaturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPuls = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPulsfrekvensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabblodtrykk = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verdi2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBlodtrykkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabResp = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.verdiDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enhetDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRespirasjonsrateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAlarm = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.grenseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alarmmDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hendelseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoTidDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAlarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabtemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturBindingSource)).BeginInit();
            this.tabPuls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPulsfrekvensBindingSource)).BeginInit();
            this.tabblodtrykk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBlodtrykkBindingSource)).BeginInit();
            this.tabResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRespirasjonsrateBindingSource)).BeginInit();
            this.tabAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabtemp);
            this.tabControl1.Controls.Add(this.tabPuls);
            this.tabControl1.Controls.Add(this.tabblodtrykk);
            this.tabControl1.Controls.Add(this.tabResp);
            this.tabControl1.Controls.Add(this.tabAlarm);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 9;
            // 
            // tabtemp
            // 
            this.tabtemp.BackColor = System.Drawing.Color.Transparent;
            this.tabtemp.Controls.Add(this.dataGridView1);
            this.tabtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabtemp.Location = new System.Drawing.Point(4, 22);
            this.tabtemp.Margin = new System.Windows.Forms.Padding(2);
            this.tabtemp.Name = "tabtemp";
            this.tabtemp.Padding = new System.Windows.Forms.Padding(2);
            this.tabtemp.Size = new System.Drawing.Size(792, 424);
            this.tabtemp.TabIndex = 0;
            this.tabtemp.Text = "Temp";
            this.tabtemp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn,
            this.enhetDataGridViewTextBoxColumn,
            this.datoTidDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listKroppstemperaturBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 420);
            this.dataGridView1.TabIndex = 6;
            // 
            // verdiDataGridViewTextBoxColumn
            // 
            this.verdiDataGridViewTextBoxColumn.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn.Name = "verdiDataGridViewTextBoxColumn";
            // 
            // enhetDataGridViewTextBoxColumn
            // 
            this.enhetDataGridViewTextBoxColumn.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn.Name = "enhetDataGridViewTextBoxColumn";
            this.enhetDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // listKroppstemperaturBindingSource
            // 
            this.listKroppstemperaturBindingSource.DataSource = typeof(LibaryPasient.Kroppstemperaturx);
            // 
            // tabPuls
            // 
            this.tabPuls.Controls.Add(this.dataGridView2);
            this.tabPuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPuls.Location = new System.Drawing.Point(4, 22);
            this.tabPuls.Margin = new System.Windows.Forms.Padding(2);
            this.tabPuls.Name = "tabPuls";
            this.tabPuls.Padding = new System.Windows.Forms.Padding(2);
            this.tabPuls.Size = new System.Drawing.Size(792, 424);
            this.tabPuls.TabIndex = 1;
            this.tabPuls.Text = "Puls";
            this.tabPuls.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn1,
            this.enhetDataGridViewTextBoxColumn1,
            this.datoTidDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.listPulsfrekvensBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(788, 420);
            this.dataGridView2.TabIndex = 0;
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
            // listPulsfrekvensBindingSource
            // 
            this.listPulsfrekvensBindingSource.DataSource = typeof(LibaryPasient.Pulsfrekvens);
            // 
            // tabblodtrykk
            // 
            this.tabblodtrykk.Controls.Add(this.dataGridView3);
            this.tabblodtrykk.Location = new System.Drawing.Point(4, 22);
            this.tabblodtrykk.Margin = new System.Windows.Forms.Padding(2);
            this.tabblodtrykk.Name = "tabblodtrykk";
            this.tabblodtrykk.Padding = new System.Windows.Forms.Padding(2);
            this.tabblodtrykk.Size = new System.Drawing.Size(792, 424);
            this.tabblodtrykk.TabIndex = 2;
            this.tabblodtrykk.Text = "Blodtrykk";
            this.tabblodtrykk.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn2,
            this.enhetDataGridViewTextBoxColumn2,
            this.verdi2DataGridViewTextBoxColumn,
            this.datoTidDataGridViewTextBoxColumn2,
            this.minDataGridViewTextBoxColumn2,
            this.maxDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.listBlodtrykkBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(2, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(788, 420);
            this.dataGridView3.TabIndex = 0;
            // 
            // verdiDataGridViewTextBoxColumn2
            // 
            this.verdiDataGridViewTextBoxColumn2.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn2.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn2.Name = "verdiDataGridViewTextBoxColumn2";
            // 
            // enhetDataGridViewTextBoxColumn2
            // 
            this.enhetDataGridViewTextBoxColumn2.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn2.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn2.Name = "enhetDataGridViewTextBoxColumn2";
            this.enhetDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // verdi2DataGridViewTextBoxColumn
            // 
            this.verdi2DataGridViewTextBoxColumn.DataPropertyName = "Verdi2";
            this.verdi2DataGridViewTextBoxColumn.HeaderText = "Verdi2";
            this.verdi2DataGridViewTextBoxColumn.Name = "verdi2DataGridViewTextBoxColumn";
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
            // 
            // maxDataGridViewTextBoxColumn2
            // 
            this.maxDataGridViewTextBoxColumn2.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn2.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn2.Name = "maxDataGridViewTextBoxColumn2";
            // 
            // listBlodtrykkBindingSource
            // 
            this.listBlodtrykkBindingSource.DataSource = typeof(LibaryPasient.Blodtrykk);
            // 
            // tabResp
            // 
            this.tabResp.Controls.Add(this.dataGridView4);
            this.tabResp.Location = new System.Drawing.Point(4, 22);
            this.tabResp.Margin = new System.Windows.Forms.Padding(2);
            this.tabResp.Name = "tabResp";
            this.tabResp.Padding = new System.Windows.Forms.Padding(2);
            this.tabResp.Size = new System.Drawing.Size(792, 424);
            this.tabResp.TabIndex = 3;
            this.tabResp.Text = "Resp";
            this.tabResp.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verdiDataGridViewTextBoxColumn3,
            this.enhetDataGridViewTextBoxColumn3,
            this.datoTidDataGridViewTextBoxColumn3,
            this.minDataGridViewTextBoxColumn3,
            this.maxDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.listRespirasjonsrateBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(2, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(788, 420);
            this.dataGridView4.TabIndex = 0;
            // 
            // verdiDataGridViewTextBoxColumn3
            // 
            this.verdiDataGridViewTextBoxColumn3.DataPropertyName = "Verdi";
            this.verdiDataGridViewTextBoxColumn3.HeaderText = "Verdi";
            this.verdiDataGridViewTextBoxColumn3.Name = "verdiDataGridViewTextBoxColumn3";
            // 
            // enhetDataGridViewTextBoxColumn3
            // 
            this.enhetDataGridViewTextBoxColumn3.DataPropertyName = "Enhet";
            this.enhetDataGridViewTextBoxColumn3.HeaderText = "Enhet";
            this.enhetDataGridViewTextBoxColumn3.Name = "enhetDataGridViewTextBoxColumn3";
            this.enhetDataGridViewTextBoxColumn3.ReadOnly = true;
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
            // 
            // maxDataGridViewTextBoxColumn3
            // 
            this.maxDataGridViewTextBoxColumn3.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn3.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn3.Name = "maxDataGridViewTextBoxColumn3";
            // 
            // listRespirasjonsrateBindingSource
            // 
            this.listRespirasjonsrateBindingSource.DataSource = typeof(LibaryPasient.Respirasjonsrate);
            // 
            // tabAlarm
            // 
            this.tabAlarm.Controls.Add(this.dataGridView5);
            this.tabAlarm.Location = new System.Drawing.Point(4, 22);
            this.tabAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlarm.Name = "tabAlarm";
            this.tabAlarm.Size = new System.Drawing.Size(792, 424);
            this.tabAlarm.TabIndex = 4;
            this.tabAlarm.Text = "Alarm ";
            this.tabAlarm.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grenseDataGridViewCheckBoxColumn,
            this.alarmmDataGridViewCheckBoxColumn,
            this.hendelseDataGridViewTextBoxColumn,
            this.datoTidDataGridViewTextBoxColumn4});
            this.dataGridView5.DataSource = this.listAlarmBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(792, 424);
            this.dataGridView5.TabIndex = 0;
            // 
            // grenseDataGridViewCheckBoxColumn
            // 
            this.grenseDataGridViewCheckBoxColumn.DataPropertyName = "Grense";
            this.grenseDataGridViewCheckBoxColumn.HeaderText = "Grense";
            this.grenseDataGridViewCheckBoxColumn.Name = "grenseDataGridViewCheckBoxColumn";
            // 
            // alarmmDataGridViewCheckBoxColumn
            // 
            this.alarmmDataGridViewCheckBoxColumn.DataPropertyName = "Alarmm";
            this.alarmmDataGridViewCheckBoxColumn.HeaderText = "Alarmm";
            this.alarmmDataGridViewCheckBoxColumn.Name = "alarmmDataGridViewCheckBoxColumn";
            // 
            // hendelseDataGridViewTextBoxColumn
            // 
            this.hendelseDataGridViewTextBoxColumn.DataPropertyName = "Hendelse";
            this.hendelseDataGridViewTextBoxColumn.HeaderText = "Hendelse";
            this.hendelseDataGridViewTextBoxColumn.Name = "hendelseDataGridViewTextBoxColumn";
            // 
            // datoTidDataGridViewTextBoxColumn4
            // 
            this.datoTidDataGridViewTextBoxColumn4.DataPropertyName = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn4.HeaderText = "DatoTid";
            this.datoTidDataGridViewTextBoxColumn4.Name = "datoTidDataGridViewTextBoxColumn4";
            // 
            // listAlarmBindingSource
            // 
            this.listAlarmBindingSource.DataSource = typeof(LibaryPasient.Alarm);
            // 
            // Klokke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Klokke";
            this.Text = "Klokke";
            this.tabControl1.ResumeLayout(false);
            this.tabtemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturBindingSource)).EndInit();
            this.tabPuls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPulsfrekvensBindingSource)).EndInit();
            this.tabblodtrykk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBlodtrykkBindingSource)).EndInit();
            this.tabResp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRespirasjonsrateBindingSource)).EndInit();
            this.tabAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabtemp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPuls;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabblodtrykk;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabResp;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabAlarm;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource listPulsfrekvensBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdi2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhet2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource listBlodtrykkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource listRespirasjonsrateBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grenseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alarmmDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hendelseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource listAlarmBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enhetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoTidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listKroppstemperaturBindingSource;
    }
}