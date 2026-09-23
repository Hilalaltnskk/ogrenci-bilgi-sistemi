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
using MySqlX.XDevAPI.Relational;

namespace OgrenciBilgiSistemi.cs
{
    public partial class NotGiris : Form
    {
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public NotGiris()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;

        }
        private void NotGiris_Load_1(object sender, EventArgs e)
        {
            listele();
            sınıfgetir();
            bransekle();
           
            dgv_9sinifnotgiris.Columns[0].Visible = false;
            dgv_10sinifnotgiris.Columns[0].Visible = false;
            dgv_11sinifnotgiris.Columns[0].Visible=false;
            dgv_12sinifnotgiris.Columns[0].Visible=false;
            
            
            lbl_ogretmenad.Text = GirisYapanBilgileri.AdSoyad;
            lbl_brans.Text = GirisYapanBilgileri.Brans;
            lbl_tc.Text = GirisYapanBilgileri.TC;
            pictureBox1.ImageLocation = GirisYapanBilgileri.Foto;
        }
        void listele()
        {



            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string query = "Select * From notlar where notSİNİF='9.Sınıf'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                //9.Sınıf
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_9sinifnotgiris.DataSource = dataTable;

                //10.Sınıf
                string query1 = "Select * From notlar where notSİNİF='10.Sınıf'";

                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, baglanti);
                DataTable dataTable2 = new DataTable();
                adapter1.Fill(dataTable2);
                dgv_10sinifnotgiris.DataSource = dataTable2;

                //11.Sınıf
                string query2 = "Select * From notlar where notSİNİF='11.Sınıf'";

                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, baglanti);
                DataTable dataTable3 = new DataTable();
                adapter2.Fill(dataTable3);
                dgv_11sinifnotgiris.DataSource = dataTable3;

                //12.sınıf
                string query3 = "Select * From notlar where notSİNİF='12.Sınıf'";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(query3, baglanti);
                DataTable dataTable4 = new DataTable();
                adapter3.Fill(dataTable4);
                dgv_12sinifnotgiris.DataSource = dataTable4;
                baglanti.Close();
            }

        }
        void bransekle()
        {
            baglanti.Open();
            string query = "SELECT * FROM brans";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_notbrans.Items.Add(reader.GetString(1));

            }
            baglanti.Close();
        }

        void sınıfgetir()
        {
            baglanti.Open();
            string query = "SELECT DISTINCT ogrenciSINIF FROM ogrenciler";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_notsinif.Items.Add(reader.GetString(0));
            }

            baglanti.Close();
        }
        
        void temizle()
        {
            txt_notID.Clear();
            cmb_notsinif.Text = "";
            cmb_notadsoyad.Text = "";
            lbl_tc2.Text = "";
            cmb_notbrans.Text = "";
            txt_sinav1.Clear();
            txt_sinav2.Clear();
            txt_sözlü1.Clear();
            txt_sözlü2.Clear();
            txt_sözlü3.Clear();
            txt_ortalama.Clear();
            checkBox2.Checked = false;
            label2.Text = "";
        }
        private void dgv_9sinifnotgiris_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txt_notID.Text = dgv_9sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_10sinifnotgiris_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            txt_notID.Text = dgv_10sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_11sinifnotgiris_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            txt_notID.Text = dgv_11sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void dgv_12sinifnotgiris_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txt_notID.Text = dgv_12sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void dgv_9sinifnotgiris_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_9sinifnotgiris.CurrentRow != null)
            {
                txt_notID.Text = dgv_9sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
                cmb_notsinif.Text = dgv_9sinifnotgiris.CurrentRow.Cells[1].Value.ToString();
                cmb_notadsoyad.Text = dgv_9sinifnotgiris.CurrentRow.Cells[2].Value.ToString();
                lbl_tc2.Text = dgv_9sinifnotgiris.CurrentRow.Cells[3].Value.ToString();
                cmb_notbrans.Text = dgv_9sinifnotgiris.CurrentRow.Cells[4].Value.ToString();
                txt_sinav1.Text = dgv_9sinifnotgiris.CurrentRow.Cells[5].Value.ToString();
                txt_sinav2.Text = dgv_9sinifnotgiris.CurrentRow.Cells[6].Value.ToString();
                txt_sözlü1.Text = dgv_9sinifnotgiris.CurrentRow.Cells[7].Value.ToString();
                txt_sözlü2.Text = dgv_9sinifnotgiris.CurrentRow.Cells[8].Value.ToString();
                txt_sözlü3.Text = dgv_9sinifnotgiris.CurrentRow.Cells[9].Value.ToString();
                txt_ortalama.Text = dgv_9sinifnotgiris.CurrentRow.Cells[10].Value.ToString();
                label2.Text = dgv_9sinifnotgiris.CurrentRow.Cells[11].Value.ToString();

                dgv_9sinifnotgiris.Columns["notID"].HeaderText = "ID";
                dgv_9sinifnotgiris.Columns["notSİNİF"].HeaderText = "Sınıf";
                dgv_9sinifnotgiris.Columns["notADSOYAD"].HeaderText = "Ad-Soyad";
                dgv_9sinifnotgiris.Columns["notTC"].HeaderText = "T.C. Kimlik";
                dgv_9sinifnotgiris.Columns["notBRANS"].HeaderText = "Branş";
                dgv_9sinifnotgiris.Columns["sinav1"].HeaderText = "Sınav-1";
                dgv_9sinifnotgiris.Columns["sinav2"].HeaderText = "Sınav-2";
                dgv_9sinifnotgiris.Columns["sozlu1"].HeaderText = "Sözlü Notu-1";
                dgv_9sinifnotgiris.Columns["sozlu2"].HeaderText = "Sözlü Notu-2";
                dgv_9sinifnotgiris.Columns["sozlu3"].HeaderText = "Sözlü Notu-";
                dgv_9sinifnotgiris.Columns["ortalama"].HeaderText = "Ortalama";
                dgv_9sinifnotgiris.Columns["basaridurum"].HeaderText = "Başarı Durum";
             }
            

           
            
        }



        private void dgv_10sinifnotgiris_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_10sinifnotgiris.CurrentRow != null)
            {
                txt_notID.Text = dgv_10sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
                cmb_notsinif.Text = dgv_10sinifnotgiris.CurrentRow.Cells[1].Value.ToString();
                cmb_notadsoyad.Text = dgv_10sinifnotgiris.CurrentRow.Cells[2].Value.ToString();
                lbl_tc2.Text = dgv_10sinifnotgiris.CurrentRow.Cells[3].Value.ToString();
                cmb_notbrans.Text = dgv_10sinifnotgiris.CurrentRow.Cells[4].Value.ToString();
                txt_sinav1.Text = dgv_10sinifnotgiris.CurrentRow.Cells[5].Value.ToString();
                txt_sinav2.Text = dgv_10sinifnotgiris.CurrentRow.Cells[6].Value.ToString();
                txt_sözlü1.Text = dgv_10sinifnotgiris.CurrentRow.Cells[7].Value.ToString();
                txt_sözlü2.Text = dgv_10sinifnotgiris.CurrentRow.Cells[8].Value.ToString();
                txt_sözlü3.Text = dgv_10sinifnotgiris.CurrentRow.Cells[9].Value.ToString();
                txt_ortalama.Text = dgv_10sinifnotgiris.CurrentRow.Cells[11].Value.ToString();

                dgv_10sinifnotgiris.Columns["notID"].HeaderText = "ID";
                dgv_10sinifnotgiris.Columns["notSİNİF"].HeaderText = "Sınıf";
                dgv_10sinifnotgiris.Columns["notADSOYAD"].HeaderText = "Ad-Soyad";
                dgv_10sinifnotgiris.Columns["notTC"].HeaderText = "T.C. Kimlik";
                dgv_10sinifnotgiris.Columns["notBRANS"].HeaderText = "Branş";
                dgv_10sinifnotgiris.Columns["sinav1"].HeaderText = "Sınav-1";
                dgv_10sinifnotgiris.Columns["sinav2"].HeaderText = "Sınav-2";
                dgv_10sinifnotgiris.Columns["sozlu1"].HeaderText = "Sözlü Notu-1";
                dgv_10sinifnotgiris.Columns["sozlu2"].HeaderText = "Sözlü Notu-2";
                dgv_10sinifnotgiris.Columns["sozlu3"].HeaderText = "Sözlü Notu-";
                dgv_10sinifnotgiris.Columns["ortalama"].HeaderText = "Ortalama";
                dgv_10sinifnotgiris.Columns["basaridurum"].HeaderText = "Başarı Durum";
            }
           
        }

        private void dgv_11sinifnotgiris_SelectionChanged(object sender, EventArgs e)
        {        
            if (dgv_11sinifnotgiris.CurrentRow != null)
            {
                txt_notID.Text = dgv_11sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
                cmb_notsinif.Text = dgv_11sinifnotgiris.CurrentRow.Cells[1].Value.ToString();
                cmb_notadsoyad.Text = dgv_11sinifnotgiris.CurrentRow.Cells[2].Value.ToString();
                lbl_tc2.Text = dgv_11sinifnotgiris.CurrentRow.Cells[3].Value.ToString();
                cmb_notbrans.Text = dgv_11sinifnotgiris.CurrentRow.Cells[4].Value.ToString();
                txt_sinav1.Text = dgv_11sinifnotgiris.CurrentRow.Cells[5].Value.ToString();
                txt_sinav2.Text = dgv_11sinifnotgiris.CurrentRow.Cells[6].Value.ToString();
                txt_sözlü1.Text = dgv_11sinifnotgiris.CurrentRow.Cells[7].Value.ToString();
                txt_sözlü2.Text = dgv_11sinifnotgiris.CurrentRow.Cells[8].Value.ToString();
                txt_sözlü3.Text = dgv_11sinifnotgiris.CurrentRow.Cells[9].Value.ToString();
                txt_ortalama.Text = dgv_11sinifnotgiris.CurrentRow.Cells[10].Value.ToString();
                label2.Text = dgv_11sinifnotgiris.CurrentRow.Cells[11].Value.ToString();

                dgv_11sinifnotgiris.Columns["notID"].HeaderText = "ID";
                dgv_11sinifnotgiris.Columns["notSİNİF"].HeaderText = "Sınıf";
                dgv_11sinifnotgiris.Columns["notADSOYAD"].HeaderText = "Ad-Soyad";
                dgv_11sinifnotgiris.Columns["notTC"].HeaderText = "T.C. Kimlik";
                dgv_11sinifnotgiris.Columns["notBRANS"].HeaderText = "Branş";
                dgv_11sinifnotgiris.Columns["sinav1"].HeaderText = "Sınav-1";
                dgv_11sinifnotgiris.Columns["sinav2"].HeaderText = "Sınav-2";
                dgv_11sinifnotgiris.Columns["sozlu1"].HeaderText = "Sözlü Notu-1";
                dgv_11sinifnotgiris.Columns["sozlu2"].HeaderText = "Sözlü Notu-2";
                dgv_11sinifnotgiris.Columns["sozlu3"].HeaderText = "Sözlü Notu-";
                dgv_11sinifnotgiris.Columns["ortalama"].HeaderText = "Ortalama";
                dgv_11sinifnotgiris.Columns["basaridurum"].HeaderText = "Başarı Durum";
            }
           
        }

        private void dgv_12sinifnotgiris_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_12sinifnotgiris.CurrentRow != null)
            {
                txt_notID.Text = dgv_12sinifnotgiris.CurrentRow.Cells[0].Value.ToString();
                cmb_notsinif.Text = dgv_12sinifnotgiris.CurrentRow.Cells[1].Value.ToString();
                cmb_notadsoyad.Text = dgv_12sinifnotgiris.CurrentRow.Cells[2].Value.ToString();
                lbl_tc2.Text = dgv_12sinifnotgiris.CurrentRow.Cells[3].Value.ToString();
                cmb_notbrans.Text = dgv_12sinifnotgiris.CurrentRow.Cells[4].Value.ToString();
                txt_sinav1.Text = dgv_12sinifnotgiris.CurrentRow.Cells[5].Value.ToString();
                txt_sinav2.Text = dgv_12sinifnotgiris.CurrentRow.Cells[6].Value.ToString();
                txt_sözlü1.Text = dgv_12sinifnotgiris.CurrentRow.Cells[7].Value.ToString();
                txt_sözlü2.Text = dgv_12sinifnotgiris.CurrentRow.Cells[8].Value.ToString();
                txt_sözlü3.Text = dgv_12sinifnotgiris.CurrentRow.Cells[9].Value.ToString();
                txt_ortalama.Text = dgv_12sinifnotgiris.CurrentRow.Cells[10].Value.ToString();
                label2.Text = dgv_12sinifnotgiris.CurrentRow.Cells[11].Value.ToString();

                dgv_12sinifnotgiris.Columns["notID"].HeaderText = "ID";
                dgv_12sinifnotgiris.Columns["notSİNİF"].HeaderText = "Sınıf";
                dgv_12sinifnotgiris.Columns["notADSOYAD"].HeaderText = "Ad-Soyad";
                dgv_12sinifnotgiris.Columns["notTC"].HeaderText = "T.C. Kimlik";
                dgv_12sinifnotgiris.Columns["notBRANS"].HeaderText = "Branş";
                dgv_12sinifnotgiris.Columns["sinav1"].HeaderText = "Sınav-1";
                dgv_12sinifnotgiris.Columns["sinav2"].HeaderText = "Sınav-2";
                dgv_12sinifnotgiris.Columns["sozlu1"].HeaderText = "Sözlü Notu-1";
                dgv_12sinifnotgiris.Columns["sozlu2"].HeaderText = "Sözlü Notu-2";
                dgv_12sinifnotgiris.Columns["sozlu3"].HeaderText = "Sözlü Notu-";
                dgv_12sinifnotgiris.Columns["ortalama"].HeaderText = "Ortalama";
                dgv_12sinifnotgiris.Columns["basaridurum"].HeaderText = "Başarı Durum";
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_sözlü3.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_sözlü3.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double sinav1 = Convert.ToDouble(txt_sinav1.Text);
            double sinav2 = Convert.ToDouble(txt_sinav2.Text);
            double sozlu1 = Convert.ToDouble(txt_sözlü1.Text);
            double sozlu2 = Convert.ToDouble(txt_sözlü2.Text);
            double sozlu3 = (checkBox1.Checked) ? Convert.ToDouble(txt_sözlü3.Text) : 0.00;// CheckBox seçiliyse sözlü3 değerini al, değilse 0 olarak kabul et

            // Ortalamayı hesapla
            int toplamNotSayisi = 4 + (checkBox1.Checked ? +1 : 0); // Sınavlar + Sözlü notları (sözlü3 seçiliyse 1 azalt)
            double toplamNot = sinav1 + sinav2 + sozlu1 + sozlu2 + sozlu3;
            double ortalama = toplamNot / toplamNotSayisi;

            // Ortalamayı Textbox'a yazdır
            txt_ortalama.Text = " " + ortalama.ToString();
            // Ortalama 49'dan büyükse "Geçti" yazdır
            if (ortalama > 49)
            {
                label2.Text = "Geçti";
                checkBox2.Checked = true; // CheckBox'ı işaretle
            }
            else
            {
                label2.Text = "Kaldı"; // 49'dan küçükse kaldı yaz
                checkBox2.Checked = false; // CheckBox'ı işaretsiz bırak
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                if (ogrid.Text == "0")
                {
                    if (!String.IsNullOrEmpty(txt_notID.Text))
                    {
                        DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            string query = "UPDATE notlar SET notSİNİF=@p1, notADSOYAD=@p2,  notTC=@p3, notBRANS=@p4, sinav1=@p5, sinav2=@p6, sozlu1=@p7,sozlu2=@p8, sozlu3=@p9,  ortalama=@p10, basaridurum=@p11 WHERE notID=@p12";
                            MySqlCommand komut = new MySqlCommand(query, baglanti);
                            komut.Parameters.AddWithValue("@p1", cmb_notsinif.Text);
                            komut.Parameters.AddWithValue("@p2", cmb_notadsoyad.Text);
                            komut.Parameters.AddWithValue("@p3", lbl_tc2.Text);
                            komut.Parameters.AddWithValue("@p4", cmb_notbrans.Text);
                            komut.Parameters.AddWithValue("@p5", txt_sinav1.Text);
                            komut.Parameters.AddWithValue("@p6", txt_sinav2.Text);
                            komut.Parameters.AddWithValue("@p7", txt_sözlü1.Text);
                            komut.Parameters.AddWithValue("@p8", txt_sözlü2.Text);
                            komut.Parameters.AddWithValue("@p9", string.IsNullOrEmpty(txt_sözlü3.Text) ? DBNull.Value : (object)txt_sözlü3.Text);

                            // txt_ortalama.Text değerini uygun bir ondalık sayıya dönüştürün
                            double ortalama = 0.0; // Varsayılan bir değer atayın
                            if (double.TryParse(txt_ortalama.Text, out ortalama))
                            {
                                // Dönüşüm başarılı oldu, ortalama değeri artık uygun bir ondalık sayıdır.
                                komut.Parameters.AddWithValue("@p10", ortalama);
                            }
                            else
                            {
                                // Dönüşüm başarısız oldu, hata işleme kodunu burada ele alın veya uygun bir değer atayın.
                                komut.Parameters.AddWithValue("@p10", DBNull.Value);
                            }

                            komut.Parameters.AddWithValue("@p11", label2.Text);
                            komut.Parameters.AddWithValue("@p12", txt_notID.Text);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listele();
                            temizle();
                        }

                     }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string queryy = "SELECT COUNT(*) FROM notlar WHERE notADSOYAD = @p2 AND notBRANS = @p4";
                                MySqlCommand komutt = new MySqlCommand(queryy, baglanti);
                                komutt.Parameters.AddWithValue("@p2", cmb_notadsoyad.Text);
                                komutt.Parameters.AddWithValue("@p4", cmb_notbrans.Text);
                                int kayitSayisi = Convert.ToInt32(komutt.ExecuteScalar());
                                if (kayitSayisi > 0)
                                {
                                    MessageBox.Show("Bu öğrenci ve dersle daha önce kayıt yapılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    baglanti.Close();
                                    return; // İşlemi sonlandır
                                }
                                string query = "INSERT INTO notlar (notSİNİF, notADSOYAD, notTC, notBRANS, sinav1, sinav2,sozlu1, sozlu2, sozlu3, ortalama, basaridurum) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9,@p10,@p11)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", cmb_notsinif.Text);
                                komut.Parameters.AddWithValue("@p2", cmb_notadsoyad.Text);
                                komut.Parameters.AddWithValue("@p3", lbl_tc2.Text);
                                komut.Parameters.AddWithValue("@p4", cmb_notbrans.Text);
                                komut.Parameters.AddWithValue("@p5", txt_sinav1.Text);
                                komut.Parameters.AddWithValue("@p6", txt_sinav2.Text);
                                komut.Parameters.AddWithValue("@p7", txt_sözlü1.Text);
                                komut.Parameters.AddWithValue("@p8", txt_sözlü2.Text);
                                komut.Parameters.AddWithValue("@p9", string.IsNullOrEmpty(txt_sözlü3.Text) ? DBNull.Value : (object)txt_sözlü3.Text);


                                double ortalama = 0.0;
                                if (double.TryParse(txt_ortalama.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p10", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p10", DBNull.Value);
                                }

                                komut.Parameters.AddWithValue("@p11", label2.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Not Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                temizle();
                        }
                            
                        }
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_notsinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open) 
            {
                baglanti.Open();
            }
            cmb_notadsoyad.Items.Clear();
           
            string selectedSinif = cmb_notsinif.SelectedItem.ToString();
            string query = "SELECT CONCAT(ogrenciAD, ' ', ogrenciSOYAD) AS ogrenciADSOYAD, ogrenciTC FROM ogrenciler WHERE ogrenciSINIF = @sinif";
            MySqlCommand komut = new MySqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@sinif", selectedSinif);

            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_notadsoyad.Items.Add(dr["ogrenciADSOYAD"].ToString());
                
            }
            dr.Close();
            baglanti.Close(); 



        }

        private void cmb_notadsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
          
            string selectedAdSoyad = cmb_notadsoyad.SelectedItem.ToString();
            string query = "SELECT ogrenciTC FROM ogrenciler WHERE CONCAT(ogrenciAD, ' ', ogrenciSOYAD) = @adsoyad";
            MySqlCommand komut = new MySqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@adsoyad", selectedAdSoyad);

            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_tc2.Text = dr["ogrenciTC"].ToString();
            }
            dr.Close();
            baglanti.Close();
        }


        private void NotGiris_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_9sinifnotgiris.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_9sinifnotgiris.SelectedRows[0].Cells["notID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM notlar WHERE notID = @notID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@notID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_9sinifnotgiris.Rows.RemoveAt(dgv_9sinifnotgiris.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgv_10sinifnotgiris.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_10sinifnotgiris.SelectedRows[0].Cells["notID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM notlar WHERE notID = @notID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@notID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_10sinifnotgiris.Rows.RemoveAt(dgv_10sinifnotgiris.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dgv_11sinifnotgiris.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_11sinifnotgiris.SelectedRows[0].Cells["notID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM notlar WHERE notID = @notID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@notID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_11sinifnotgiris.Rows.RemoveAt(dgv_11sinifnotgiris.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (dgv_12sinifnotgiris.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_12sinifnotgiris.SelectedRows[0].Cells["notID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM notlar WHERE notID = @notID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@notID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_12sinifnotgiris.Rows.RemoveAt(dgv_12sinifnotgiris.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

    
    
