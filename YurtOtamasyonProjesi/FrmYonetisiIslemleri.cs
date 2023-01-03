using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace YurtOtamasyonProjesi
{
    public partial class FrmYonetisiIslemleri : Form
    {
        public FrmYonetisiIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();

        private void FrmYonetisiIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_OtomasyonuDataSet12.Yonetici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yoneticiTableAdapter.Fill(this.yurt_OtomasyonuDataSet12.Yonetici);

        }

        private void pictureEkle_Click(object sender, EventArgs e)
        {
            try
            {

            
            SqlCommand komut = new SqlCommand("insert into Yonetici(YoneticiAd,YoneticiSifre) values (@y1,@y2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@y1", TxtyoneticiAd.Text);
            komut.Parameters.AddWithValue("@y2", Txtyoneticisifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.yoneticiTableAdapter.Fill(this.yurt_OtomasyonuDataSet12.Yonetici);
            }
            catch (Exception)
            {

                MessageBox.Show("Yönetici ekleme işlemi gerçekleştirilemedi");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            Txtyoneticiid.Text = id;
            TxtyoneticiAd.Text = ad;
            Txtyoneticisifre.Text= sifre;
        }

        private void pictureSil_Click(object sender, EventArgs e)
        {
            try
            {

            
            SqlCommand komut = new SqlCommand("delete from yonetici where YoneticiAd=@y1",bgl.baglanti());
            komut.Parameters.AddWithValue("@y1", TxtyoneticiAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme gerçekleşti.");
            this.yoneticiTableAdapter.Fill(this.yurt_OtomasyonuDataSet12.Yonetici);
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi gerçekleştirilemedi.");
            }
        }

        private void pictureDuzenle_Click(object sender, EventArgs e)
        {
            try 
            { 
             SqlCommand komut = new SqlCommand("update Yonetici set YoneticiAd=@y1,YoneticiSifre=@y2,Yoneticiid=@y3", bgl.baglanti());
             komut.Parameters.AddWithValue("@y1", TxtyoneticiAd.Text);
             komut.Parameters.AddWithValue("@y2", Txtyoneticisifre.Text);
             komut.Parameters.AddWithValue("@y3", Txtyoneticiid.Text);
             komut.ExecuteNonQuery();
             bgl.baglanti().Close();
             MessageBox.Show("Güncelleme gerçekleştirildi.");
             this.yoneticiTableAdapter.Fill(this.yurt_OtomasyonuDataSet12.Yonetici);
            }
           catch (Exception)
            {

                MessageBox.Show("Güncelleme işlemi gerçekleştirilemedi.");
            }
}
    }
}
