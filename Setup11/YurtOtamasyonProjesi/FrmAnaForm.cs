using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace YurtOtamasyonProjesi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
       
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_OtomasyonuDataSet13.OgrenciBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciBilgisiTableAdapter2.Fill(this.yurt_OtomasyonuDataSet13.OgrenciBilgisi);
            // TODO: Bu kod satırı 'yurt_OtomasyonuDataSet1.OgrenciBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.



        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit fr=new FrmOgrenciKayit();
            fr.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListe fr=new FrmOgrenciListe();
            fr.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListe fr=new FrmOgrenciListe();
            fr.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr=new FrmBolumler();
            fr.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr=new FrmOdemeler();
            fr.Show();
        }

        private void gİderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler fr=new FrmGiderler();
            fr.Show();
        }

        private void gİderListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderLİstesi fr=new FrmGiderLİstesi();
            fr.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistikleri fr=new FrmGelirİstatistikleri();
            fr.Show();

        }

        private void şifreDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYonetisiIslemleri fr = new FrmYonetisiIslemleri();
            fr.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlBaglantim bgl = new SqlBaglantim();
            
            DataTable dt = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select  * from OgrenciBilgisi where OgrAd like'%"+textBox1.Text+"%' ",bgl.baglanti());
            ara.Fill(dt);
            bgl.baglanti().Close();
            dataGridView1.DataSource=dt;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
         
        private void Btnlink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tr.wikipedia.org/wiki/Cezer%C3%AE");
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU OTOMASYON 03 OCAK 2023 TARİHİNDE AHMET ÇORAK TARAFINDAN OLUŞTURULMUŞTUR.");
        }
    }
}
