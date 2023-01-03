namespace YurtOtamasyonProjesi
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİderListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciBilgisiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_OtomasyonuDataSet1 = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet1();
            this.yurt_OtomasyonuDataSet = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet();
            this.ogrenciBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBilgisiTableAdapter = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSetTableAdapters.OgrenciBilgisiTableAdapter();
            this.ogrenciBilgisiTableAdapter1 = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet1TableAdapters.OgrenciBilgisiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btnlink = new System.Windows.Forms.Button();
            this.panelCezeri = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurt_OtomasyonuDataSet13 = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet13();
            this.ogrenciBilgisiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBilgisiTableAdapter2 = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet13TableAdapters.OgrenciBilgisiTableAdapter();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciDüzenleToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci Sil";
            this.öğrenciDüzenleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDüzenleToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenleToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            this.bölümEkleToolStripMenuItem.Click += new System.EventHandler(this.bölümEkleToolStripMenuItem_Click);
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            this.bölümDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bölümDüzenleToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeAlToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            this.ödemeAlToolStripMenuItem.Click += new System.EventHandler(this.ödemeAlToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            this.gelirİstatistikleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİstatistikleriToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gİderEkleToolStripMenuItem,
            this.gİderListeleToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // gİderEkleToolStripMenuItem
            // 
            this.gİderEkleToolStripMenuItem.Name = "gİderEkleToolStripMenuItem";
            this.gİderEkleToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.gİderEkleToolStripMenuItem.Text = "Gider Ekle";
            this.gİderEkleToolStripMenuItem.Click += new System.EventHandler(this.gİderEkleToolStripMenuItem_Click);
            // 
            // gİderListeleToolStripMenuItem
            // 
            this.gİderListeleToolStripMenuItem.Name = "gİderListeleToolStripMenuItem";
            this.gİderListeleToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.gİderListeleToolStripMenuItem.Text = "Gİder Listele";
            this.gİderListeleToolStripMenuItem.Click += new System.EventHandler(this.gİderListeleToolStripMenuItem_Click);
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDüzenlemeToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreDüzenlemeToolStripMenuItem
            // 
            this.şifreDüzenlemeToolStripMenuItem.Name = "şifreDüzenlemeToolStripMenuItem";
            this.şifreDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.şifreDüzenlemeToolStripMenuItem.Text = "Şifre Düzenleme";
            this.şifreDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.şifreDüzenlemeToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ogrenciBilgisiBindingSource1
            // 
            this.ogrenciBilgisiBindingSource1.DataMember = "OgrenciBilgisi";
            this.ogrenciBilgisiBindingSource1.DataSource = this.yurt_OtomasyonuDataSet1;
            // 
            // yurt_OtomasyonuDataSet1
            // 
            this.yurt_OtomasyonuDataSet1.DataSetName = "Yurt_OtomasyonuDataSet1";
            this.yurt_OtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurt_OtomasyonuDataSet
            // 
            this.yurt_OtomasyonuDataSet.DataSetName = "Yurt_OtomasyonuDataSet";
            this.yurt_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBilgisiBindingSource
            // 
            this.ogrenciBilgisiBindingSource.DataMember = "OgrenciBilgisi";
            this.ogrenciBilgisiBindingSource.DataSource = this.yurt_OtomasyonuDataSet;
            // 
            // ogrenciBilgisiTableAdapter
            // 
            this.ogrenciBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciBilgisiTableAdapter1
            // 
            this.ogrenciBilgisiTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci Ara:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(926, 583);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Btnlink
            // 
            this.Btnlink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btnlink.Location = new System.Drawing.Point(762, 253);
            this.Btnlink.Name = "Btnlink";
            this.Btnlink.Size = new System.Drawing.Size(420, 33);
            this.Btnlink.TabIndex = 8;
            this.Btnlink.Text = "EL-CEZERİ KİMDİR?";
            this.Btnlink.UseVisualStyleBackColor = false;
            this.Btnlink.Click += new System.EventHandler(this.Btnlink_Click);
            // 
            // panelCezeri
            // 
            this.panelCezeri.BackgroundImage = global::YurtOtamasyonProjesi.Properties.Resources.indir1;
            this.panelCezeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCezeri.Location = new System.Drawing.Point(762, 29);
            this.panelCezeri.Name = "panelCezeri";
            this.panelCezeri.Size = new System.Drawing.Size(423, 227);
            this.panelCezeri.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::YurtOtamasyonProjesi.Properties.Resources.WhatsApp_Görsel_2023_01_02_saat_16_28_46;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 581);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBilgisiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(654, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 184);
            this.dataGridView1.TabIndex = 10;
            // 
            // yurt_OtomasyonuDataSet13
            // 
            this.yurt_OtomasyonuDataSet13.DataSetName = "Yurt_OtomasyonuDataSet13";
            this.yurt_OtomasyonuDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBilgisiBindingSource2
            // 
            this.ogrenciBilgisiBindingSource2.DataMember = "OgrenciBilgisi";
            this.ogrenciBilgisiBindingSource2.DataSource = this.yurt_OtomasyonuDataSet13;
            // 
            // ogrenciBilgisiTableAdapter2
            // 
            this.ogrenciBilgisiTableAdapter2.ClearBeforeFill = true;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            this.ogrTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            this.ogrTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1182, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelCezeri);
            this.Controls.Add(this.Btnlink);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİderListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private Yurt_OtomasyonuDataSet yurt_OtomasyonuDataSet;
        private System.Windows.Forms.BindingSource ogrenciBilgisiBindingSource;
        private Yurt_OtomasyonuDataSetTableAdapters.OgrenciBilgisiTableAdapter ogrenciBilgisiTableAdapter;
        private Yurt_OtomasyonuDataSet1 yurt_OtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBilgisiBindingSource1;
        private Yurt_OtomasyonuDataSet1TableAdapters.OgrenciBilgisiTableAdapter ogrenciBilgisiTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        
        private System.Windows.Forms.Button Btnlink;
        private System.Windows.Forms.Panel panelCezeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Yurt_OtomasyonuDataSet13 yurt_OtomasyonuDataSet13;
        private System.Windows.Forms.BindingSource ogrenciBilgisiBindingSource2;
        private Yurt_OtomasyonuDataSet13TableAdapters.OgrenciBilgisiTableAdapter ogrenciBilgisiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
    }
}