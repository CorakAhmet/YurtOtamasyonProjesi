﻿namespace YurtOtamasyonProjesi
{
    partial class FrmGiderLİstesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderLİstesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurt_OtomasyonuDataSet9 = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet9();
            this.odemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odemelerTableAdapter = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet9TableAdapters.OdemelerTableAdapter();
            this.odemeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınternetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeidDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.ınternetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemelerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurt_OtomasyonuDataSet9
            // 
            this.yurt_OtomasyonuDataSet9.DataSetName = "Yurt_OtomasyonuDataSet9";
            this.yurt_OtomasyonuDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odemelerBindingSource
            // 
            this.odemelerBindingSource.DataMember = "Odemeler";
            this.odemelerBindingSource.DataSource = this.yurt_OtomasyonuDataSet9;
            // 
            // odemelerTableAdapter
            // 
            this.odemelerTableAdapter.ClearBeforeFill = true;
            // 
            // odemeidDataGridViewTextBoxColumn
            // 
            this.odemeidDataGridViewTextBoxColumn.DataPropertyName = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.HeaderText = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeidDataGridViewTextBoxColumn.Name = "odemeidDataGridViewTextBoxColumn";
            this.odemeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            this.elektrikDataGridViewTextBoxColumn.Width = 125;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            this.dogalgazDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınternetDataGridViewTextBoxColumn
            // 
            this.ınternetDataGridViewTextBoxColumn.DataPropertyName = "Internet";
            this.ınternetDataGridViewTextBoxColumn.HeaderText = "Internet";
            this.ınternetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınternetDataGridViewTextBoxColumn.Name = "ınternetDataGridViewTextBoxColumn";
            this.ınternetDataGridViewTextBoxColumn.Width = 125;
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            this.gıdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            this.personelDataGridViewTextBoxColumn.Width = 125;
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            this.digerDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmGiderLİstesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1053, 453);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderLİstesi";
            this.Text = "Gider Lİstesi";
            this.Load += new System.EventHandler(this.FrmGiderLİstesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Yurt_OtomasyonuDataSet9 yurt_OtomasyonuDataSet9;
        private System.Windows.Forms.BindingSource odemelerBindingSource;
        private Yurt_OtomasyonuDataSet9TableAdapters.OdemelerTableAdapter odemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınternetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}