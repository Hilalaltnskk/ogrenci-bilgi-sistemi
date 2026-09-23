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

    public partial class Ogretmenler : Form
    {
        string conneciton = "Server=localhost;uid=root;password=123Hilal123.;database=ogrencibilgisistemi";
        MySqlConnection baglanti = new MySqlConnection();

        public Ogretmenler()
        {
            InitializeComponent();
            baglanti.ConnectionString = conneciton;
            listele();

        }

        public string dosyayolu;

        void listele()
        {


            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = "Select  * from ogretmenler";

                MySqlCommand cmd = new MySqlCommand(query, baglanti);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgv_ogretmenbilgi.DataSource = dataTable;
                baglanti.Close();
            }



        }
        void ilekle()
        {
            baglanti.Open();
            string query = "Select  * from il";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbx_il.Items.Add(reader.GetString(1));

            }
            baglanti.Close();
        }
        void bransekle()
        {
            baglanti.Open();
            string query = "Select  * from brans";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbx_brans.Items.Add(reader.GetString(1));

            }
            baglanti.Close();
        }
        void temizle()
        {
            txt_ıd.Text = null;
            txt_ad.Text = null;
            txt_soyad.Text = null;
            txt_tc.Text = null;
            txt_tel.Text = null;
            txt_mail.Text = null;
            cmbx_il.Text = null;
            cmbx_ilce.Text = null;
            cmbx_brans.Text = null;
            rxhtxt_adres.Text = null;
            pctrbx_ogretmenresim.ImageLocation = null;
        }

        private void Ogretmenler_Load(object sender, EventArgs e)
        {
            dtgv_ogretmenbilgi.Columns[0].Visible = false;
            dtgv_ogretmenbilgi.Columns["ogretmenID"].HeaderText = "ID";
            dtgv_ogretmenbilgi.Columns["ogretmenAD"].HeaderText = "Ad";
            dtgv_ogretmenbilgi.Columns["ogretmenSOYAD"].HeaderText = "Soyad";
            dtgv_ogretmenbilgi.Columns["ogretmenTC"].HeaderText = "TC Kimlik No";
            dtgv_ogretmenbilgi.Columns["ogretmenTEL"].HeaderText = "Telefon";
            dtgv_ogretmenbilgi.Columns["ogretmenMAIL"].HeaderText = "E-Posta";
            dtgv_ogretmenbilgi.Columns["ogretmenIL"].HeaderText = "İl";
            dtgv_ogretmenbilgi.Columns["ogretmenILCE"].HeaderText = "İlçe";
            dtgv_ogretmenbilgi.Columns["ogretmenADRES"].HeaderText = "Adres";
            dtgv_ogretmenbilgi.Columns["ogretmenBRANS"].HeaderText = "Branş";
            dtgv_ogretmenbilgi.Columns["ogretmenFOTO"].HeaderText = "Fotoğraf";
            ilekle();
            bransekle();
        }

        private void dtgv_ogretmenbilgi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_ıd.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[0].Value.ToString();

        }

        private void cmbx_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_ilce.Items.Clear();
            string connectionString = "Server=localhost;Database=ogrencibilgisistemi;Uid=root;Pwd=123Hilal123.;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM ilce WHERE il_no = @p1";
            MySqlCommand komut = new MySqlCommand(query, connection);
            komut.Parameters.AddWithValue("@p1", cmbx_il.SelectedIndex + 1);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbx_ilce.Items.Add(dr["isim"].ToString());
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
                        if (!String.IsNullOrEmpty(txt_ıd.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE ogretmenler SET ogretmenAD=@p1, ogretmenSOYAD=@p2, ogretmenTC=@p3, ogretmenTEL=@p4, ogretmenMAIL=@p5, ogretmenIL=@p6, ogretmenILCE=@p7, ogretmenADRES=@p8, ogretmenBRANS=@p9, ogretmenFOTO=@p10 WHERE ogretmenID=@p11";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_tc.Text);
                                komut.Parameters.AddWithValue("@p4", txt_tel.Text);
                                komut.Parameters.AddWithValue("@p5", txt_mail.Text);
                                komut.Parameters.AddWithValue("@p6", cmbx_il.Text);
                                komut.Parameters.AddWithValue("@p7", cmbx_ilce.Text);
                                komut.Parameters.AddWithValue("@p8", rxhtxt_adres.Text);
                                komut.Parameters.AddWithValue("@p9", cmbx_brans.Text);
                                komut.Parameters.AddWithValue("@p10", dosyayolu);
                                komut.Parameters.AddWithValue("@p11", txt_ıd.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                temizle();
                            }
                           
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO ogretmenler (ogretmenAD, ogretmenSOYAD, ogretmenTC, ogretmenTEL, ogretmenMAIL, ogretmenIL, ogretmenILCE, ogretmenADRES, ogretmenBRANS, ogretmenFOTO) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9,@p10)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_tc.Text);
                                komut.Parameters.AddWithValue("@p4", txt_tel.Text);
                                komut.Parameters.AddWithValue("@p5", txt_mail.Text);
                                komut.Parameters.AddWithValue("@p6", cmbx_il.Text);
                                komut.Parameters.AddWithValue("@p7", cmbx_ilce.Text);
                                komut.Parameters.AddWithValue("@p8", rxhtxt_adres.Text);
                                komut.Parameters.AddWithValue("@p9", cmbx_brans.Text);
                                komut.Parameters.AddWithValue("@p10", dosyayolu);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                temizle();
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

        

        private void dtgv_ogretmenbilgi_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_ogretmenbilgi.CurrentRow != null)
            {
                txt_ıd.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[0].Value.ToString();
                txt_ad.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[2].Value.ToString();
                txt_tc.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[3].Value.ToString();
                txt_tel.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[4].Value.ToString();
                cmbx_il.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[6].Value.ToString();
                cmbx_ilce.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[7].Value.ToString();
                cmbx_brans.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[9].Value.ToString();
                txt_mail.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[5].Value.ToString();
                rxhtxt_adres.Text = dtgv_ogretmenbilgi.CurrentRow.Cells[8].Value.ToString();
                pctrbx_ogretmenresim.ImageLocation = dtgv_ogretmenbilgi.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void btn_resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            dosyayolu = dosya.FileName;
            pctrbx_ogretmenresim.ImageLocation = dosyayolu;
        }


        private void Ogretmenler_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtgv_ogretmenbilgi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dtgv_ogretmenbilgi.SelectedRows[0].Cells["ogretmenID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM ogretmenler WHERE ogretmenID = @ogretmenID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@ogretmenID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dtgv_ogretmenbilgi.Rows.RemoveAt(dtgv_ogretmenbilgi.SelectedRows[0].Index);
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
    










