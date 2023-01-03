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
    public partial class FrmGİderGuncelle : Form
    {
        public FrmGİderGuncelle()
        {
            InitializeComponent();
        }
        public string id,elektrik, su,dogalgaz,internet, personel, gida, diger;
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Odemeler set Elektrik=@g1,Su=@g2,Dogalgaz=@g3,Internet=@g4,Gıda=@g5,Personel=@g6,Diger=@g7 where Odemeid=@g8", bgl.baglanti());
                komut.Parameters.AddWithValue("@g1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@g2", TxtSu.Text);
                komut.Parameters.AddWithValue("@g3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@g4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@g5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@g6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@g7", TxtDiger.Text);
                komut.Parameters.AddWithValue("@g8", TxtGiderid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelemede Hata Tespit Edildi!");
            }
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGİderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGiderid.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDogalgaz.Text = dogalgaz; 
            TxtInternet.Text = internet;
            TxtGıda.Text = gida;
            TxtPersonel.Text=personel;
            TxtDiger.Text=diger;



        }
    }
}
