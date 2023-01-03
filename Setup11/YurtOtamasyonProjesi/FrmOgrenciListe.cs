using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtamasyonProjesi
{
    public partial class FrmOgrenciListe : Form
    {
        public FrmOgrenciListe()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_OtomasyonuDataSet8.OgrenciBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciBilgisiTableAdapter.Fill(this.yurt_OtomasyonuDataSet8.OgrenciBilgisi);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrenciDuzenle fr=new FrmOgrenciDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad=   dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.tc=dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon=dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogumtarihi=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum=dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.kangrubu=dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            fr.mail=dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.odaNo=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.adres=dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.veliad=dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.velisoyad=dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            fr.velitelefon=dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.Show();
        }
    }
}
