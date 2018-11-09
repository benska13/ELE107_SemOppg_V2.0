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
            this.listPulsfrekvensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listKroppstemperaturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabtemp = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPuls = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabblodtrykk = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.listBlodtrykkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabResp = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.listRespirasjonsrateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAlarm = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.listAlarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listPulsfrekvensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabtemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPuls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // listPulsfrekvensBindingSource
            // 
            this.listPulsfrekvensBindingSource.AllowNew = true;
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
            this.tabtemp.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabtemp.Location = new System.Drawing.Point(4, 22);
            this.tabtemp.Margin = new System.Windows.Forms.Padding(2);
            this.tabtemp.Name = "tabtemp";
            this.tabtemp.Padding = new System.Windows.Forms.Padding(2);
            this.tabtemp.Size = new System.Drawing.Size(792, 424);
            this.tabtemp.TabIndex = 0;
            this.tabtemp.Text = "Temp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.listKroppstemperaturBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 420);
            this.dataGridView1.TabIndex = 6;
            // 
            // tabPuls
            // 
            this.tabPuls.Controls.Add(this.dataGridView2);
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
            this.dataGridView2.DataSource = this.listPulsfrekvensBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(788, 420);
            this.dataGridView2.TabIndex = 0;
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
            this.dataGridView3.DataSource = this.listBlodtrykkBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(2, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(788, 420);
            this.dataGridView3.TabIndex = 0;
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
            this.dataGridView4.DataSource = this.listRespirasjonsrateBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(2, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(788, 420);
            this.dataGridView4.TabIndex = 0;
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
            this.dataGridView5.DataSource = this.listAlarmBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(792, 424);
            this.dataGridView5.TabIndex = 0;
            // 
            // Klokke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Klokke";
            this.Text = "Klokke";
            ((System.ComponentModel.ISupportInitialize)(this.listPulsfrekvensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKroppstemperaturBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabtemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPuls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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

        private System.Windows.Forms.BindingSource listPulsfrekvensBindingSource;
        private System.Windows.Forms.BindingSource listKroppstemperaturBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabtemp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPuls;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabblodtrykk;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource listBlodtrykkBindingSource;
        private System.Windows.Forms.TabPage tabResp;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource listRespirasjonsrateBindingSource;
        private System.Windows.Forms.TabPage tabAlarm;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource listAlarmBindingSource;
    }
}