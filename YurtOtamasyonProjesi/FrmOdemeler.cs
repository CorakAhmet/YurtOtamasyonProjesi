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

namespace YurtOtamasyonProjesi
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_OtomasyonuDataSet7.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurt_OtomasyonuDataSet7.Borclar);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string  ad, soyad, kalanborc;
            secilen= dataGridView1.SelectedCells[0].RowIndex;
            ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kalanborc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text=soyad;
            TxtKalan.Text = kalanborc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Taksit ödemeleri
            int odenen, kalan,yenikalan;
            odenen=Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yenikalan = kalan - odenen;
            TxtKalan.Text = yenikalan.ToString();



            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@b1 where OgrAd=@b2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b2",TxtAd.Text);
            komut.Parameters.AddWithValue("@b1",TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi.");
            this.borclarTableAdapter.Fill(this.yurt_OtomasyonuDataSet7.Borclar);

            //Kasa Tablosuna EkLeme Yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktarı) values (@a1,@a2)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@a1",TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@a2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
