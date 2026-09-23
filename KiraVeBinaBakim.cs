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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OgrenciBilgiSistemi.cs
{
    public partial class KiraVeBinaBakim : Form
    {
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti=new MySqlConnection();
        public KiraVeBinaBakim()
        {
            InitializeComponent();
            baglanti.ConnectionString=connection;
        }

        private void KiraVeBinaBakim_Load(object sender, EventArgs e)
        {
            listele();
            dgv_binabakim.Columns[0].Visible = false;
            dgv_binabakim.Columns["binaTARİH"].HeaderText = "Tarih";
            dgv_binabakim.Columns["binaKİRA"].HeaderText = "Bina Kirası";
            dgv_binabakim.Columns["binaBOYA"].HeaderText = "Boya Malzemeleri";
            dgv_binabakim.Columns["binaTEMİZLİK"].HeaderText = "Temizlik Malzemeleri";
            dgv_binabakim.Columns["binaASANSOR"].HeaderText = "Asansör Bakım";
            dgv_binabakim.Columns["binaTASARİM"].HeaderText = "İç Mekan Tasarımı ve Dekorasyon";
            dgv_binabakim.Columns["binaYANGİNST"].HeaderText = "Yangın Sistemleri";
            dgv_binabakim.Columns["binaTOPLAM"].HeaderText = "Toplam";
        }
        void listele()
        {
            baglanti.Open();
            string query = "SELECT * FROM binakirabakim";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable datatable=new DataTable();
            adapter.Fill(datatable);
            dgv_binabakim.DataSource= datatable;
            baglanti.Close();
        }
        void Temizle()
        {
            txt_id.Clear();
            dateTimePicker1.Value= DateTime.Now;
            txt_binakira.Clear();
            txt_boya.Clear();
            txt_temizlik.Clear();
            txt_asansor.Clear();
            txt_dekorasyon.Clear();
            txt_yangin.Clear();
            txt_toplam.Clear();
            cbx_kira.Checked = false;
            cbx_boya.Checked = false;
            cbx_temizlik.Checked = false;
            cbx_asansor.Checked = false;
            cbx_dekorasyon.Checked = false;
            cbx_yangin.Checked = false;

        }
        private void dgv_binabakim_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_binabakim.CurrentRow != null)
            { 
                txt_id.Text = dgv_binabakim.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dgv_binabakim.CurrentRow.Cells[1].Value.ToString();
                txt_binakira.Text = dgv_binabakim.CurrentRow.Cells[2].Value.ToString();
                txt_boya.Text = dgv_binabakim.CurrentRow.Cells[3].Value.ToString();
                txt_temizlik.Text = dgv_binabakim.CurrentRow.Cells[4].Value.ToString();
                txt_asansor.Text = dgv_binabakim.CurrentRow.Cells[5].Value.ToString();
                txt_dekorasyon.Text = dgv_binabakim.CurrentRow.Cells[6].Value.ToString();
                txt_yangin.Text = dgv_binabakim.CurrentRow.Cells[7].Value.ToString();
                txt_toplam.Text = dgv_binabakim.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double kira = (cbx_kira.Checked) ? Convert.ToDouble(txt_binakira.Text) : 0.00;
            double boya = (cbx_boya.Checked) ? Convert.ToDouble(txt_boya.Text) : 0.00;
            double temizlik = (cbx_temizlik.Checked) ? Convert.ToDouble(txt_temizlik.Text) : 0.00;
            double asansor = (cbx_asansor.Checked) ? Convert.ToDouble(txt_asansor.Text) : 0.00;
            double dekorasyon = (cbx_dekorasyon.Checked) ? Convert.ToDouble(txt_dekorasyon.Text) : 0.00;
            double yangin = (cbx_yangin.Checked) ? Convert.ToDouble(txt_yangin.Text) : 0.00;

            
            double gider = 0; // Toplam giderleri başlat
            if (cbx_kira.Checked)
            {
                
                gider += kira;
            }

            if (cbx_boya.Checked)
            {
                
                gider += boya;
            }
            if (cbx_temizlik.Checked)
            {
                
                gider += temizlik;
            }
            if (cbx_asansor.Checked)
            {
               
                gider+=asansor;
            }
           
            if (cbx_dekorasyon.Checked)
            {
                
                gider += dekorasyon;
            }
            if (cbx_yangin.Checked)
            {
               
                gider += yangin;
            }
            double ortalama = gider;
            txt_toplam.Text = " " + ortalama.ToString();
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
                                string query = "UPDATE binakirabakim SET binaTARİH=@p1, binaKİRA=@p2, binaBOYA=@p3, binaTEMİZLİK=@p4, binaASANSOR=@p5, binaTASARİM=@p6, binaYANGİNST=@p7, binaTOPLAM=@p8 WHERE binaID=@p9";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_binakira.Text);
                                komut.Parameters.AddWithValue("@p3", txt_boya.Text);
                                komut.Parameters.AddWithValue("@p4", txt_temizlik.Text);
                                komut.Parameters.AddWithValue("@p5", txt_asansor.Text);
                                komut.Parameters.AddWithValue("@p6", txt_dekorasyon.Text);
                                komut.Parameters.AddWithValue("@p7", txt_yangin.Text);
                                double ortalama = 0.0;
                                if (double.TryParse(txt_toplam.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p8", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p8", DBNull.Value);
                                }

                                komut.Parameters.AddWithValue("@p9", txt_id.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                Temizle();
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO binakirabakim (binaTARİH,binaKİRA,binaBOYA,binaTEMİZLİK,binaASANSOR,binaTASARİM,binaYANGİNST,binaTOPLAM) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_binakira.Text);
                                komut.Parameters.AddWithValue("@p3", txt_boya.Text);
                                komut.Parameters.AddWithValue("@p4", txt_temizlik.Text);
                                komut.Parameters.AddWithValue("@p5", txt_asansor.Text);
                                komut.Parameters.AddWithValue("@p6", txt_dekorasyon.Text);
                                komut.Parameters.AddWithValue("@p7", txt_yangin.Text);




                                double ortalama = 0.0;
                                if (double.TryParse(txt_toplam.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p8", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p8", DBNull.Value);
                                }


                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Giderlere Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                Temizle();
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

        private void cbx_kira_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_kira.Checked)
            {
                txt_binakira.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_binakira.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_boya_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_boya.Checked)
            {
                txt_boya.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_boya.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_temizlik_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_temizlik.Checked)
            {
                txt_temizlik.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_temizlik.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_asansor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_asansor.Checked)
            {
                txt_asansor.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_asansor.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_dekorasyon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_dekorasyon.Checked)
            {
                txt_dekorasyon.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_dekorasyon.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_yangin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_yangin.Checked)
            {
                txt_yangin.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_yangin.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void KiraVeBinaBakim_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            Temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_binabakim.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_binabakim.SelectedRows[0].Cells["binaID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM binakirabakim WHERE binaID = @binaID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@binaID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_binabakim.Rows.RemoveAt(dgv_binabakim.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
