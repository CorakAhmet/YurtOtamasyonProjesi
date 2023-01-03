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
    public partial class FrmGelirİstatistikleri : Form
    {
        public FrmGelirİstatistikleri()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();
        private void FrmGelirİstatistikleri_Load(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select Sum(OdemeMiktarı) from Kasa", bgl.baglanti());
            SqlDataReader oku= komut.ExecuteReader();
            while(oku.Read())
            {
                lblPara.Text = oku[0].ToString()+ " ₺";
            }
            bgl.baglanti().Close();

            //tekrarsız< olarak ayları listeleme
            SqlCommand komut2=  new SqlCommand("select distinct(OdemeAy) from Kasa",bgl.baglanti());
            SqlDataReader oku2=komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();

            //Grafiklere veri tabanından veri çekme

            SqlCommand komutgrafik = new SqlCommand("select OdemeAy, sum(OdemeMiktarı) from Kasa group by OdemeAy",bgl.baglanti());
            SqlDataReader oku3 = komutgrafik.ExecuteReader();
            while (oku3.Read()) 
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);

            }
            bgl.baglanti().Close();
        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktarı) From Kasa where OdemeAy=@a1", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1",CmbAy.Text);
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            { 
                lblAyKazanc.Text=oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
