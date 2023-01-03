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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();



        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_OtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurt_OtomasyonuDataSet.Bolumler);

        }
        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumid.Text = id;
            TxtBolumAd.Text = bolumad;
            

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.bolumlerTableAdapter.Fill(this.yurt_OtomasyonuDataSet.Bolumler);
                MessageBox.Show("Bölüm Başarıyla Eklendi.");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyiniz!");
            }
            
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@n2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@n2", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Silindi.");
                this.bolumlerTableAdapter.Fill(this.yurt_OtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata tespit edildiğinden dolayı işlem gerçekleştirilemedi!");
            }
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut3 = new SqlCommand("update Bolumler Set BolumAd=@n1 where Bolumid=@n2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@n2", TxtBolumid.Text);
                komut3.Parameters.AddWithValue("@n1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı bir şekilde güncelleme gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurt_OtomasyonuDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme gerçekleştirilemedi!");
            }

        }
    }
}
