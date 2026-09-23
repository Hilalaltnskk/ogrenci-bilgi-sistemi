using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.IO;

namespace OgrenciBilgiSistemi.cs
{
    public partial class Giris : Form
    {
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public Giris()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                string query = "SELECT ogretmenler.ogretmenTC, ogretmenayarlar.ogretmenayarlarSIFRE, " +
                               "ogretmenler.ogretmenAD, ogretmenler.ogretmenSOYAD, ogretmenler.ogretmenBRANS, ogretmenler.ogretmenFOTO " +
                               "FROM ogretmenayarlar " +
                               "INNER JOIN ogretmenler ON ogretmenayarlar.ogretmenayarlarID = ogretmenler.ogretmenID " +
                               "WHERE ogretmenler.ogretmenTC = @ogretmenTC AND ogretmenayarlar.ogretmenayarlarSIFRE = @ogretmenayarlarSIFRE";
                MySqlCommand komut = new MySqlCommand(query, baglanti);

                komut.Parameters.AddWithValue("@ogretmenTC", txt_kullanici.Text);
                komut.Parameters.AddWithValue("@ogretmenayarlarSIFRE", txt_sifre.Text);

                MySqlDataReader adapter = komut.ExecuteReader();

                while (adapter.Read())
                {
                    GirisYapanBilgileri.AdSoyad = adapter["ogretmenAD"].ToString() + " " + adapter["ogretmenSOYAD"].ToString();
                    GirisYapanBilgileri.TC = adapter["ogretmenTC"].ToString();
                    GirisYapanBilgileri.Brans = adapter["ogretmenBRANS"].ToString();
                    GirisYapanBilgileri.Foto = adapter["ogretmenFOTO"].ToString();

                    AnaModul anaModul = new AnaModul();
                    anaModul.Show();
                    this.Hide();
                }

                
                if (!adapter.HasRows)
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                    txt_kullanici.Text = string.Empty;
                    txt_sifre.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btn_ogretmen_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                string query = "SELECT ogretmenler.ogretmenTC, ogretmenayarlar.ogretmenayarlarSIFRE, " +
                               "ogretmenler.ogretmenAD, ogretmenler.ogretmenSOYAD, ogretmenler.ogretmenBRANS, ogretmenler.ogretmenFOTO " +
                               "FROM ogretmenayarlar " +
                               "INNER JOIN ogretmenler ON ogretmenayarlar.ogretmenayarlarID = ogretmenler.ogretmenID " +
                               "WHERE ogretmenler.ogretmenTC = @ogretmenTC AND ogretmenayarlar.ogretmenayarlarSIFRE = @ogretmenayarlarSIFRE";
                MySqlCommand komut = new MySqlCommand(query, baglanti);

                komut.Parameters.AddWithValue("@ogretmenTC", txt_kullanici.Text);
                komut.Parameters.AddWithValue("@ogretmenayarlarSIFRE", txt_sifre.Text);

                MySqlDataReader adapter = komut.ExecuteReader();

                while (adapter.Read())
                {
                    GirisYapanBilgileri.AdSoyad = adapter["ogretmenAD"].ToString() + " " + adapter["ogretmenSOYAD"].ToString();
                    GirisYapanBilgileri.TC = adapter["ogretmenTC"].ToString();
                    GirisYapanBilgileri.Brans = adapter["ogretmenBRANS"].ToString();
                    GirisYapanBilgileri.Foto = adapter["ogretmenFOTO"].ToString();

                    OgretmenAnaModul anaModul = new OgretmenAnaModul();
                    anaModul.Show();
                    this.Hide();
                }


                if (!adapter.HasRows)
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                    txt_kullanici.Text = string.Empty;
                    txt_sifre.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                string query = "SELECT ogrenciler.ogrenciTC, ogrenciayarlar.ogrenciayarlarSİFRE, " +
              "ogrenciler.ogrenciAD, ogrenciler.ogrenciSOYAD, ogrenciler.ogrenciSINIF, ogrenciler.ogrenciFOTO " +
              "FROM ogrenciayarlar " +
              "INNER JOIN ogrenciler ON ogrenciayarlar.ogrenciayarlarID = ogrenciler.ogrenciID " +
              "WHERE ogrenciler.ogrenciTC = @ogrenciTC AND ogrenciayarlar.ogrenciayarlarSİFRE = @ogrenciayarlarSİFRE";
                MySqlCommand komut = new MySqlCommand(query, baglanti);

                komut.Parameters.AddWithValue("@ogrenciTC", txt_kullanici.Text);
                komut.Parameters.AddWithValue("@ogrenciayarlarSİFRE", txt_sifre.Text);

                MySqlDataReader adapter = komut.ExecuteReader();

                while (adapter.Read())
                {
                    GirisYapanBilgileri.OgrenciAdSoyad = adapter["ogrenciAD"].ToString() + " " + adapter["ogrenciSOYAD"].ToString();
                    GirisYapanBilgileri.OgrenciTC = adapter["ogrenciTC"].ToString();
                    GirisYapanBilgileri.OgrenciSinif = adapter["ogrenciSINIF"].ToString();
                    GirisYapanBilgileri.OgrenciFoto = adapter["ogrenciFOTO"].ToString();

                    OgrencilerAnaModul anaModul = new OgrencilerAnaModul();
                    anaModul.Show();
                    this.Hide();
                }


                if (!adapter.HasRows)
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                    txt_kullanici.Text = string.Empty;
                    txt_sifre.Text = string.Empty;
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
            }
            finally
            {

                baglanti.Close();
            }
        }
    }
}
