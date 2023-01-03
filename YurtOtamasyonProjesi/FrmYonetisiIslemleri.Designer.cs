namespace YurtOtamasyonProjesi
{
    partial class FrmYonetisiIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetisiIslemleri));
            this.Txtyoneticiid = new System.Windows.Forms.TextBox();
            this.lblyoneticiid = new System.Windows.Forms.Label();
            this.TxtyoneticiAd = new System.Windows.Forms.TextBox();
            this.lblKullanıcıadı = new System.Windows.Forms.Label();
            this.Txtyoneticisifre = new System.Windows.Forms.TextBox();
            this.lblyoneticisifre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurt_OtomasyonuDataSet12 = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet12();
            this.yoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yoneticiTableAdapter = new YurtOtamasyonProjesi.Yurt_OtomasyonuDataSet12TableAdapters.YoneticiTableAdapter();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDuzenle = new System.Windows.Forms.PictureBox();
            this.pictureSil = new System.Windows.Forms.PictureBox();
            this.pictureEkle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtyoneticiid
            // 
            this.Txtyoneticiid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtyoneticiid.Location = new System.Drawing.Point(175, 36);
            this.Txtyoneticiid.Name = "Txtyoneticiid";
            this.Txtyoneticiid.Size = new System.Drawing.Size(239, 30);
            this.Txtyoneticiid.TabIndex = 3;
            // 
            // lblyoneticiid
            // 
            this.lblyoneticiid.AutoSize = true;
            this.lblyoneticiid.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyoneticiid.Location = new System.Drawing.Point(59, 45);
            this.lblyoneticiid.Name = "lblyoneticiid";
            this.lblyoneticiid.Size = new System.Drawing.Size(102, 21);
            this.lblyoneticiid.TabIndex = 2;
            this.lblyoneticiid.Text = "Yönetici İd:";
            // 
            // TxtyoneticiAd
            // 
            this.TxtyoneticiAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtyoneticiAd.Location = new System.Drawing.Point(175, 82);
            this.TxtyoneticiAd.Name = "TxtyoneticiAd";
            this.TxtyoneticiAd.Size = new System.Drawing.Size(239, 30);
            this.TxtyoneticiAd.TabIndex = 5;
            // 
            // lblKullanıcıadı
            // 
            this.lblKullanıcıadı.AutoSize = true;
            this.lblKullanıcıadı.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıadı.Location = new System.Drawing.Point(42, 91);
            this.lblKullanıcıadı.Name = "lblKullanıcıadı";
            this.lblKullanıcıadı.Size = new System.Drawing.Size(119, 21);
            this.lblKullanıcıadı.TabIndex = 4;
            this.lblKullanıcıadı.Text = "Kullanıcı Adı:";
            // 
            // Txtyoneticisifre
            // 
            this.Txtyoneticisifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtyoneticisifre.Location = new System.Drawing.Point(175, 134);
            this.Txtyoneticisifre.Name = "Txtyoneticisifre";
            this.Txtyoneticisifre.Size = new System.Drawing.Size(239, 30);
            this.Txtyoneticisifre.TabIndex = 7;
            // 
            // lblyoneticisifre
            // 
            this.lblyoneticisifre.AutoSize = true;
            this.lblyoneticisifre.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyoneticisifre.Location = new System.Drawing.Point(108, 143);
            this.lblyoneticisifre.Name = "lblyoneticisifre";
            this.lblyoneticisifre.Size = new System.Drawing.Size(53, 21);
            this.lblyoneticisifre.TabIndex = 6;
            this.lblyoneticisifre.Text = "Şifre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yoneticiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(434, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(476, 278);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurt_OtomasyonuDataSet12
            // 
            this.yurt_OtomasyonuDataSet12.DataSetName = "Yurt_OtomasyonuDataSet12";
            this.yurt_OtomasyonuDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoneticiBindingSource
            // 
            this.yoneticiBindingSource.DataMember = "Yonetici";
            this.yoneticiBindingSource.DataSource = this.yurt_OtomasyonuDataSet12;
            // 
            // yoneticiTableAdapter
            // 
            this.yoneticiTableAdapter.ClearBeforeFill = true;
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            this.yoneticiAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            this.yoneticiSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureDuzenle
            // 
            this.pictureDuzenle.Image = global::YurtOtamasyonProjesi.Properties.Resources.kullanıcı_düznleme;
            this.pictureDuzenle.Location = new System.Drawing.Point(314, 184);
            this.pictureDuzenle.Name = "pictureDuzenle";
            this.pictureDuzenle.Size = new System.Drawing.Size(100, 50);
            this.pictureDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDuzenle.TabIndex = 8;
            this.pictureDuzenle.TabStop = false;
            this.pictureDuzenle.Click += new System.EventHandler(this.pictureDuzenle_Click);
            // 
            // pictureSil
            // 
            this.pictureSil.Image = global::YurtOtamasyonProjesi.Properties.Resources.silme_kullanıcı;
            this.pictureSil.Location = new System.Drawing.Point(176, 184);
            this.pictureSil.Name = "pictureSil";
            this.pictureSil.Size = new System.Drawing.Size(100, 50);
            this.pictureSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSil.TabIndex = 8;
            this.pictureSil.TabStop = false;
            this.pictureSil.Click += new System.EventHandler(this.pictureSil_Click);
            // 
            // pictureEkle
            // 
            this.pictureEkle.Image = ((System.Drawing.Image)(resources.GetObject("pictureEkle.Image")));
            this.pictureEkle.Location = new System.Drawing.Point(41, 184);
            this.pictureEkle.Name = "pictureEkle";
            this.pictureEkle.Size = new System.Drawing.Size(100, 50);
            this.pictureEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEkle.TabIndex = 8;
            this.pictureEkle.TabStop = false;
            this.pictureEkle.Click += new System.EventHandler(this.pictureEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(34, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yönetici Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(292, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yönetici Düzenle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(172, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yönetici Sil";
            // 
            // FrmYonetisiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(908, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureDuzenle);
            this.Controls.Add(this.pictureSil);
            this.Controls.Add(this.pictureEkle);
            this.Controls.Add(this.Txtyoneticisifre);
            this.Controls.Add(this.lblyoneticisifre);
            this.Controls.Add(this.TxtyoneticiAd);
            this.Controls.Add(this.lblKullanıcıadı);
            this.Controls.Add(this.Txtyoneticiid);
            this.Controls.Add(this.lblyoneticiid);
            this.Name = "FrmYonetisiIslemleri";
            this.Text = "FrmYonetisiIslemleri";
            this.Load += new System.EventHandler(this.FrmYonetisiIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtyoneticiid;
        private System.Windows.Forms.Label lblyoneticiid;
        private System.Windows.Forms.TextBox TxtyoneticiAd;
        private System.Windows.Forms.Label lblKullanıcıadı;
        private System.Windows.Forms.TextBox Txtyoneticisifre;
        private System.Windows.Forms.Label lblyoneticisifre;
        private System.Windows.Forms.PictureBox pictureEkle;
        private System.Windows.Forms.PictureBox pictureSil;
        private System.Windows.Forms.PictureBox pictureDuzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Yurt_OtomasyonuDataSet12 yurt_OtomasyonuDataSet12;
        private System.Windows.Forms.BindingSource yoneticiBindingSource;
        private Yurt_OtomasyonuDataSet12TableAdapters.YoneticiTableAdapter yoneticiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}