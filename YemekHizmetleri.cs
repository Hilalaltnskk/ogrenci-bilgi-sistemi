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

namespace OgrenciBilgiSistemi.cs
{
    public partial class YemekHizmetleri : Form
    {
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public YemekHizmetleri()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }

        private void YemekHizmetleri_Load(object sender, EventArgs e)
        {
            listele();
            dgv_yemekhizmetleri.Columns[0].Visible = false;
            dgv_yemekhizmetleri.Columns["yemekTARİH"].HeaderText = "Tarih";
            dgv_yemekhizmetleri.Columns["personelgider"].HeaderText = "Personel Gider";
            dgv_yemekhizmetleri.Columns["malzemegider"].HeaderText = "Malzeme Gider";
            dgv_yemekhizmetleri.Columns["beslenmedanisman"].HeaderText = "Danışman";
            dgv_yemekhizmetleri.Columns["yemekservis"].HeaderText = "Yemek Servis";
            dgv_yemekhizmetleri.Columns["ikramlar"].HeaderText = "İkramlar";
            dgv_yemekhizmetleri.Columns["toplam"].HeaderText = "Toplam";
        }
        void listele()
        {
            baglanti.Open();

            string query = "SELECT * FROM yemekhizmetleri";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_yemekhizmetleri.DataSource = datatable;

            baglanti.Close();


        }
        void ToollarıTemizle()
        {
            txt_id.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txt_personelgider.Clear();
            txt_gida.Clear();
            txt_beslenme.Clear();
            txt_yemekservis.Clear();
            txt_ikramlar.Clear();
            txt_toplam.Clear();
            cbx_personelgider.Checked = false;
            cbx_gida.Checked = false;
            cbx_beslenme.Checked = false;
            cbx_yemekservis.Checked = false;
            cbx_ikramlar.Checked = false;
        }

        private void dgv_yemekhizmetleri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yemekhizmetleri.CurrentRow != null)
            {
                txt_id.Text = dgv_yemekhizmetleri.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dgv_yemekhizmetleri.CurrentRow.Cells[1].Value.ToString();
                txt_personelgider.Text = dgv_yemekhizmetleri.CurrentRow.Cells[2].Value.ToString();
                txt_gida.Text = dgv_yemekhizmetleri.CurrentRow.Cells[3].Value.ToString();
                txt_beslenme.Text = dgv_yemekhizmetleri.CurrentRow.Cells[4].Value.ToString();
                txt_yemekservis.Text = dgv_yemekhizmetleri.CurrentRow.Cells[5].Value.ToString();
                txt_ikramlar.Text = dgv_yemekhizmetleri.CurrentRow.Cells[6].Value.ToString();
                txt_toplam.Text = dgv_yemekhizmetleri.CurrentRow.Cells[7].Value.ToString();
            }
           
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double personelgider = (cbx_personelgider.Checked) ? Convert.ToDouble(txt_personelgider.Text) : 0.00;
            double gida = (cbx_gida.Checked) ? Convert.ToDouble(txt_gida.Text) : 0.00;
            double beslenme = (cbx_beslenme.Checked) ? Convert.ToDouble(txt_beslenme.Text) : 0.00;
            double yemekservis = (cbx_yemekservis.Checked) ? Convert.ToDouble(txt_yemekservis.Text) : 0.00;
            double ikramlar = (cbx_ikramlar.Checked) ? Convert.ToDouble(txt_ikramlar.Text) : 0.00;

            double gider = 0; // Toplam giderleri başlat
            if (cbx_personelgider.Checked)
            {

                gider += personelgider;
            }

            if (cbx_gida.Checked)
            {

                gider += gida;
            }
            if (cbx_beslenme.Checked)
            {

                gider += beslenme;
            }
            if (cbx_yemekservis.Checked)
            {

                gider += yemekservis;
            }
            if (cbx_ikramlar.Checked)
            { 

                gider += ikramlar;
            }

            double ort = gider;
            txt_toplam.Text = " " + ort.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                {
                    if (ogrid.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_id.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE yemekhizmetleri SET yemekTARİH=@p1, personelgider=@p2, malzemegider=@p3, beslenmedanisman=@p4, yemekservis=@p5, ikramlar=@p6, toplam=@p7  WHERE yemekhizmetleriID=@p8";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_personelgider.Text);
                                komut.Parameters.AddWithValue("@p3", txt_gida.Text);
                                komut.Parameters.AddWithValue("@p4", txt_beslenme.Text);
                                komut.Parameters.AddWithValue("@p5", txt_yemekservis.Text);
                                komut.Parameters.AddWithValue("@p6", txt_ikramlar.Text);
                                double ortalama = 0.0;
                                if (double.TryParse(txt_toplam.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p7", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p7", DBNull.Value);
                                }

                                komut.Parameters.AddWithValue("@p8", txt_id.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                ToollarıTemizle();
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO yemekhizmetleri (yemekTARİH,personelgider,malzemegider,beslenmedanisman,yemekservis,ikramlar,toplam) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_personelgider.Text);
                                komut.Parameters.AddWithValue("@p3", txt_gida.Text);
                                komut.Parameters.AddWithValue("@p4", txt_beslenme.Text);
                                komut.Parameters.AddWithValue("@p5", txt_yemekservis.Text);
                                komut.Parameters.AddWithValue("@p6", txt_ikramlar.Text);

                                double ortalama = 0.0;
                                if (double.TryParse(txt_toplam.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p7", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p7", DBNull.Value);
                                }


                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Giderlere Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                ToollarıTemizle();
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
          
        

        private void cbx_personelgider_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_personelgider.Checked)
            {
                txt_personelgider.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_personelgider.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_gida_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_gida.Checked)
            {
                txt_gida.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_gida.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_beslenme_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_beslenme.Checked)
            {
                txt_beslenme.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_beslenme.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_yemekservis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_yemekservis.Checked)
            {
                txt_yemekservis.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_yemekservis.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_ikramlar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ikramlar.Checked)
            {
                txt_ikramlar.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_ikramlar.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_yemekhizmetleri.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_yemekhizmetleri.SelectedRows[0].Cells["yemekhizmetleriID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM yemekhizmetleri WHERE yemekhizmetleriID = @yemekhizmetleriID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@yemekhizmetleriID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_yemekhizmetleri.Rows.RemoveAt(dgv_yemekhizmetleri.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void YemekHizmetleri_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            ToollarıTemizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToollarıTemizle();
        }
    }
    
}
