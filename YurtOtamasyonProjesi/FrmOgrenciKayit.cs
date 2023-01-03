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
using System.IO;
using System.Data.SqlTypes;

namespace YurtOtamasyonProjesi
{
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();

        }

        SqlBaglantim bgl=new SqlBaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bölümler için listeleme komutları
            //bgl.baglanti().Open();
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            

            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Kan Gruplarını Görmek için.
           // bgl.baglanti().Open();
            SqlCommand komut1 = new SqlCommand("Select KanGrubu From KanGrubu", bgl.baglanti());
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                CmbKanGrubu.Items.Add(oku1[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş odaların görünmesi için listeleme komutları
           // bgl.baglanti().Open();
            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite > OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgileri Kaydetme
            try
            {
              //  bgl.baglanti().Open();
                SqlCommand komutKaydet = new SqlCommand("Insert into OgrenciBilgisi(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrKanGrubu,OgrMail,OgrOdaNo,OgrAdres,OgrVeliAd,OgrVeliSoyad,OgrVeliTelefon) values (@n1,@n2,@n3,@n4,@n5,@n6,@n7,@n8,@n9,@n10,@n11,@n12,@n13)", bgl.baglanti());
                komutKaydet.Parameters.AddWithValue("@n1", TxtAd.Text);
                komutKaydet.Parameters.AddWithValue("@n2", TxtSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@n3", MskTxtTC.Text);
                komutKaydet.Parameters.AddWithValue("@n4", MskTxtTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@n5", MskTxtDogumTarihi.Text);
                komutKaydet.Parameters.AddWithValue("@n6", CmbBolum.Text);
                komutKaydet.Parameters.AddWithValue("@n7", CmbKanGrubu.Text);
                komutKaydet.Parameters.AddWithValue("@n8", TxtMail.Text);
                komutKaydet.Parameters.AddWithValue("@n9", CmbOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@n10", TxtAdres.Text);
                komutKaydet.Parameters.AddWithValue("@n11", TxtVeliAd.Text);
                komutKaydet.Parameters.AddWithValue("@n12", TxtVeliSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@n13", MskTxtVeliTelefon.Text);
                komutKaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı.");

                //Öğenci id Labele Çekme
               // bgl.baglanti().Open();
                SqlCommand komut = new SqlCommand("select ogrid from ogrencibilgisi", bgl.baglanti());
                SqlDataReader dr1 = komut.ExecuteReader();
                while (dr1.Read())
                {
                    label16.Text = dr1[0].ToString();
                }
                bgl.baglanti().Close();

                // Öğrenci borç alanı kısmı
               //  bgl.baglanti().Open();
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@m1,@m2,@m3)",bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@m1",label16.Text);
                komutkaydet2.Parameters.AddWithValue("@m2",TxtAd.Text);
                komutkaydet2.Parameters.AddWithValue("@m3",TxtSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen tekrar deneyin!");
            }

            //Öğrenci kontenjanı azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNO=@o1",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@o1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            
        }

    }
}
//Data Source=LENOVO\SQLEXPRESS;Initial Catalog="Yurt Otomasyonu";Integrated Security=True
