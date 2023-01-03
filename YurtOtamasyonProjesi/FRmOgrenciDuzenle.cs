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
    public partial class FrmOgrenciDuzenle : Form
    {
        public FrmOgrenciDuzenle()
        {

            InitializeComponent();
        }




        SqlBaglantim bgl = new SqlBaglantim();


        public string id,ad,soyad,tc,telefon,dogumtarihi,bolum,kangrubu,mail,odaNo,adres,veliad,velisoyad,velitelefon;

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci silme işlemi

            SqlCommand komutsil = new SqlCommand("delete from OgrenciBilgisi where ogrid=@s1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@s1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");

            // Silinin öğrenciden dolayı oda kontenjanı düzenleme
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@t1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@t1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
                

        }

        
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update OgrenciBilgisi set OgrAd=@b2,OgrSoyad=@b3,OgrTc=@b4,OgrTelefon=@b5,OgrDogum=@b6,OgrBolum=@b7,OgrOdaNo=@b8,OgrMail=@b9,OgrVeliAd=@b10,OgrVeliTelefon=@b11,OgrAdres=@b12,OgrKanGrubu=@b13,OgrVeliSoyad=@b14 where Ogrid=@b1", bgl.baglanti());
                komut.Parameters.AddWithValue("@b1", Txtid.Text);
                komut.Parameters.AddWithValue("@b2", TxtAd.Text);
                komut.Parameters.AddWithValue("@b3", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@b4", MskTxtTC.Text);
                komut.Parameters.AddWithValue("@b5", MskTxtTelefon.Text);
                komut.Parameters.AddWithValue("@b6", MskTxtDogumTarihi.Text);
                komut.Parameters.AddWithValue("@b7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@b8", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@b9", TxtMail.Text);
                komut.Parameters.AddWithValue("@b10", TxtVeliAd.Text);
                komut.Parameters.AddWithValue("@b11", MskTxtVeliTelefon.Text);
                komut.Parameters.AddWithValue("@b12", TxtAdres.Text);
                komut.Parameters.AddWithValue("@b13", CmbKanGrubu.Text);
                komut.Parameters.AddWithValue("@b14", TxtVeliSoyad.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti();
                MessageBox.Show("Güncelleme başarılı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme kısmında bir hata oluştu. Lütfen tekrer deneyiniz!");
            }

        }

        private void FrmOgrenciDuzenle_Load(object sender, EventArgs e)
        {
            Txtid.Text = id;
            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            MskTxtTC.Text = tc;
            MskTxtTelefon.Text = telefon;
            MskTxtDogumTarihi.Text = dogumtarihi;
            TxtMail.Text = mail;
            CmbBolum.Text = bolum;
            CmbKanGrubu.Text = kangrubu;
            CmbOdaNo.Text = odaNo;
            TxtAdres.Text = adres;
            TxtVeliAd.Text = veliad;
            TxtVeliSoyad.Text = velisoyad;
            MskTxtVeliTelefon.Text = velitelefon;
            
            
        }
    }
}
