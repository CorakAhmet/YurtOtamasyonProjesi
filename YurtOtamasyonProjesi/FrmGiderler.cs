using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtamasyonProjesi
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Odemeler (ELektrik, Su,Dogalgaz, Internet,Gıda,Personel,Diger) Values (@g1,@g2,@g3,@g4,@g5,@g6,@g7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@g1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@g2", TxtSu.Text);
                komut.Parameters.AddWithValue("@g3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@g4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@g5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@g6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@g7", TxtDiger.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydedildi.");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu.");
            }

        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {

        }
    }
}
