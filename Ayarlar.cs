using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using Renci.SshNet.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;


namespace OgrenciBilgiSistemi.cs
{
    public partial class Ayarlar : Form
    {
        public string dosyayolu;
        string connection = "Server= localhost;Uid= root;Pwd= 123Hilal123.;Database= ogrencibilgisistemi";
        MySqlConnection baglanti = new MySqlConnection();
        public Ayarlar()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }


        void listele()
        {

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string query = "SELECT oa.ogretmenayarlarID AS oaID, oa.ogretmenayarlarSIFRE,ol.ogretmenBRANS, ol.ogretmenTC, ol.ogretmenAD, ol.ogretmenSOYAD FROM ogretmenayarlar AS oa INNER JOIN ogretmenler AS ol ON oa.ogretmenayarlarID = ol.ogretmenID;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_ogretmenayarlar.DataSource = dataTable;

            baglanti.Close();

        }
        void listele2()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string query = "CALL ogrenciayarlar";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_ogrenciler.DataSource = dataTable;

            baglanti.Close();
        }


        void TemizleOgretmen()
        {
            txt_id.Clear();
            cmb_ogretmenad.Text = "";
            txt_brans.Clear();
            txt_tc.Clear();
            txt_sifre.Clear();
            pctrbx_ogretmenfoto.Image = null;
        }
        void TemizleOgrenci()
        {
            txt_ogrıd.Clear();
            cmb_ogrenciad.Text = null;
            txt_ogrsinif.Clear();
            txt_ogrtc.Clear();
            txt_ogrsifre.Clear();
            pctrbx_ogrenciresim.Image = null;
        }
        void ogretmenadıgetir()
        {

            baglanti.Open();
            string query = "SELECT oa.ogretmenayarlarID AS id, CONCAT(ol.ogretmenAD, ' ', ol.ogretmenSOYAD) AS ogretmenADSOYAD FROM ogretmenayarlar AS oa INNER JOIN ogretmenler AS ol ON oa.ogretmenayarlarID = ol.ogretmenID;";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            List<Ogretmen1> ogretmenListesi = new List<Ogretmen1>();
            foreach (DataRow row in dataTable.Rows)
            {
                Ogretmen1 ogretmen = new Ogretmen1();
                ogretmen.OgretmenID = Convert.ToInt32(row["id"]);
                ogretmen.AdSoyad = row["ogretmenADSOYAD"].ToString();

                ogretmenListesi.Add(ogretmen);
            }

            cmb_ogretmenad.ValueMember = "OgretmenID";
            cmb_ogretmenad.DisplayMember = "AdSoyad";


            cmb_ogretmenad.DataSource = ogretmenListesi;


            baglanti.Close();
        }
        void ogrenciadıgetir()
        {
            baglanti.Open();
            string query = "SELECT ogrenciID, CONCAT(ogrenciAD, ' ', ogrenciSOYAD) AS ogrenciADSOYAD FROM ogrenciler";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            List<Ogrenci1> ogrencilistesi = new List<Ogrenci1>();
            foreach (DataRow row in dataTable.Rows)
            {
                Ogrenci1 ogrenci = new Ogrenci1();
                ogrenci.OgrenciID = Convert.ToInt32(row["ogrenciID"]);
                ogrenci.OgrenciAdSoyad = row["ogrenciADSOYAD"].ToString();

                ogrencilistesi.Add(ogrenci);
            }

            cmb_ogrenciad.ValueMember = "OgrenciID";
            cmb_ogrenciad.DisplayMember = "OgrenciAdSoyad";


            cmb_ogrenciad.DataSource = ogrencilistesi;


            baglanti.Close();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
            
            ogretmenadıgetir();
            ogrenciadıgetir();
            dgv_ogrenciler.Columns[0].Visible = false;
            dgv_ogretmenayarlar.Columns[0].Visible = false;
            dgv_ogretmenayarlar.Columns[0].HeaderText = "ID";
            dgv_ogretmenayarlar.Columns[1].HeaderText = "Ad";
            dgv_ogretmenayarlar.Columns[2].HeaderText = "Branş";
            dgv_ogretmenayarlar.Columns[3].HeaderText = "T.C. Kimlik";
            dgv_ogretmenayarlar.Columns[4].HeaderText = "Şifre";
            dgv_ogretmenayarlar.Columns[5].HeaderText = "Fotoğraf";

            dgv_ogrenciler.Columns[0].HeaderText = "ID";
            dgv_ogrenciler.Columns[1].HeaderText = "Ad";
            dgv_ogrenciler.Columns[2].HeaderText = "Sınıf";
            dgv_ogrenciler.Columns[3].HeaderText = "T.C. Kimlik";
            dgv_ogrenciler.Columns[4].HeaderText = "Şifre";
            dgv_ogrenciler.Columns[5].HeaderText = "Fotoğraf";
        }
        private void dgv_ogretmenayarlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ogrenciler.CurrentRow != null)
            {
                txt_id.Text = dgv_ogretmenayarlar.CurrentRow.Cells[0].Value.ToString();
                cmb_ogretmenad.Text = dgv_ogretmenayarlar.CurrentRow.Cells[1].Value.ToString();
                txt_brans.Text = dgv_ogretmenayarlar.CurrentRow.Cells[2].Value.ToString();
                txt_tc.Text = dgv_ogretmenayarlar.CurrentRow.Cells[3].Value.ToString();
                txt_sifre.Text = dgv_ogretmenayarlar.CurrentRow.Cells[4].Value.ToString();
                pctrbx_ogretmenfoto.ImageLocation = dgv_ogretmenayarlar.CurrentRow.Cells[5].Value.ToString();

                
            }
        }

        


        private void dgv_ogrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ogrenciler.CurrentRow != null)
            {
                txt_ogrıd.Text = dgv_ogrenciler.CurrentRow.Cells[0].Value.ToString();
                cmb_ogrenciad.Text = dgv_ogrenciler.CurrentRow.Cells[1].Value.ToString();
                txt_ogrsinif.Text = dgv_ogrenciler.CurrentRow.Cells[2].Value.ToString();
                txt_ogrtc.Text = dgv_ogrenciler.CurrentRow.Cells[3].Value.ToString();
                txt_ogrsifre.Text = dgv_ogrenciler.CurrentRow.Cells[4].Value.ToString();
                pctrbx_ogrenciresim.ImageLocation = dgv_ogrenciler.CurrentRow.Cells[5].Value.ToString();

             
            }
        }

    

        private void btn_ogrguncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            {
                if (!String.IsNullOrEmpty(txt_ogrıd.Text))
                {
                    string query = "UPDATE ogrenciayarlar SET ogrenciayarlarSİFRE=@p1 WHERE ogrenciayarlarID=@p2";
                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_ogrsifre.Text);
                    komut.Parameters.AddWithValue("@p2", txt_ogrıd.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele2();
                }
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                    if (ogrid.Text == "0")
                    {
                        
                        if (!String.IsNullOrEmpty(txt_id.Text))
                        {

                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = ("UPDATE ogretmenayarlar SET ogretmenayarlarSIFRE=@p1 WHERE ogretmenayarlarID=@p2");
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_sifre.Text);
                                komut.Parameters.AddWithValue("@p2", txt_id.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                TemizleOgretmen();
                            }
                           
                        }
                       
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO ogretmenayarlar (ogretmenayarlarID,ogretmenayarlarSIFRE) VALUES (@p1,@p2)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_id.Text);
                                komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                TemizleOgretmen();
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_ogretmenad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ogretmenad.SelectedIndex != -1)
            {
                // ComboBox'tan seçilen öğenin gerçek ID değerini alın
                int ogretmenID = Convert.ToInt32(cmb_ogretmenad.SelectedValue);

                MySqlConnection baglanti = new MySqlConnection(connection);
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string query = "SELECT ogretmenID, CONCAT(ogretmenAD,' ',ogretmenSOYAD) AS ogretmenADSOYAD, ogretmenBRANS, ogretmenTC,ogretmenFOTO FROM ogretmenler WHERE ogretmenID=@ogretmenID";

                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    MySqlDataReader dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        txt_id.Text = dr["ogretmenID"].ToString();
                        cmb_ogretmenad.Text = dr["ogretmenADSOYAD"].ToString();
                        txt_brans.Text = dr["ogretmenBRANS"].ToString();
                        txt_tc.Text = dr["ogretmenTC"].ToString();
                        pctrbx_ogretmenfoto.ImageLocation = dr["ogretmenFOTO"].ToString();
                       
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        private void cmb_ogrenciad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ogrenciad.SelectedIndex != -1)
            {
                // ComboBox'tan seçilen öğenin gerçek ID değerini alın
                int ogrenciID = Convert.ToInt32(cmb_ogrenciad.SelectedValue);

                MySqlConnection baglanti = new MySqlConnection(connection);
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string query = "SELECT ogrenciID, CONCAT(ogrenciAD,' ',ogrenciSOYAD) AS ogrenciADSOYAD, ogrenciSINIF, ogrenciTC,ogrenciFOTO FROM ogrenciler WHERE ogrenciID=@ogrenciID";

                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    MySqlDataReader dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        txt_ogrıd.Text = dr["ogrenciID"].ToString();
                        cmb_ogrenciad.Text = dr["ogrenciADSOYAD"].ToString();
                        txt_ogrsinif.Text = dr["ogrenciSINIF"].ToString();
                        txt_ogrtc.Text = dr["ogrenciTC"].ToString();
                        pctrbx_ogrenciresim.ImageLocation = dr["ogrenciFOTO"].ToString();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        private void btn_ogrkaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                
            {
                baglanti.Open();
                string query = "INSERT INTO ogrenciayarlar (ogrenciayarlarID,ogrenciayarlarSIFRE) VALUES (@p1,@p2)";
                MySqlCommand komut = new MySqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@p1", txt_ogrıd.Text);
                komut.Parameters.AddWithValue("@p2", txt_ogrsifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele2();

            }
        }

        private void Ayarlar_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            TemizleOgrenci();
            TemizleOgretmen();
            
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            TemizleOgretmen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemizleOgrenci();
        }
    }
}
                
     





