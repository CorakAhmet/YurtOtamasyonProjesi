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
    public partial class FrmAdminGiris : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from Yonetici where yoneticiAd=@y1 and yoneticisifre=@y2",bgl.baglanti());
            komut.Parameters.AddWithValue("@y1",TxtKullanici.Text);
            komut.Parameters.AddWithValue("@y2", TxtSifre.Text);
            SqlDataReader oku= komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyiniz.");
                TxtKullanici.Clear();
                TxtSifre.Clear();
                TxtKullanici.Focus();
            }
            bgl.baglanti().Close();
           
        }
        
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
