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
    public partial class Giderler : Form
    {
        private Form oncekiForm = null;
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public Giderler()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
            
        }
       
        void listele()
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                //BinaKiraBakim
                string query = "SELECT * FROM binakirabakim";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_kirabakim.DataSource = dataTable;

                //OgrenciEgitimMalzemeleri
                string query1 = "SELECT * FROM ogrencimalzeme";

                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, baglanti);
                DataTable dataTable2 = new DataTable();
                adapter1.Fill(dataTable2);
                dgv_ogrenciekipman.DataSource = dataTable2;

                //YemekHizmetleri
                string query2 = "SELECT * FROM yemekhizmetleri";

                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, baglanti);
                DataTable dataTable3 = new DataTable();
                adapter2.Fill(dataTable3);
                dgv_yemek.DataSource = dataTable3;

                //YonetimVeOfis
                string query3 = "SELECT * FROM yonetimveofis";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(query3, baglanti);
                DataTable dataTable4 = new DataTable();
                adapter3.Fill(dataTable4);
                dgv_yonetimofis.DataSource = dataTable4;
                baglanti.Close();
            }
        }
        private void btn_kirabina_Click(object sender, EventArgs e)
        {
            //KiraVeBinaBakim formbinabakim = new KiraVeBinaBakim();
            ////KiraVeBinaBakim(formbinabakim);
            //formbinabakim.TopLevel = false;
            //panel2.Controls.Add(formbinabakim);
            //formbinabakim.BringToFront();
            //formbinabakim.Show();

            if (oncekiForm != null && !oncekiForm.IsDisposed)
            {
                oncekiForm.Close();
            }

            KiraVeBinaBakim yeniForm = new KiraVeBinaBakim();
            yeniForm.TopLevel = false; 
            yeniForm.AutoScroll = true; 
            panel2.Controls.Add(yeniForm); 
            yeniForm.BringToFront();
            yeniForm.FormClosed += (s, args) => { oncekiForm = null; };
            oncekiForm = yeniForm;
            yeniForm.Show();
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            listele();

            dgv_kirabakim.Columns[0].Visible = false;
            dgv_ogrenciekipman.Columns[0].Visible = false;
            dgv_yemek.Columns[0].Visible = false;
            dgv_yonetimofis.Columns[0].Visible = false;

            dgv_kirabakim.Columns["binaTARİH"].HeaderText = "Tarih";
            dgv_kirabakim.Columns["binaKİRA"].HeaderText = "Bina Kirası";
            dgv_kirabakim.Columns["binaBOYA"].HeaderText = "Boya Malzemeleri";
            dgv_kirabakim.Columns["binaTEMİZLİK"].HeaderText = "Temizlik Malzemeleri";
            dgv_kirabakim.Columns["binaASANSOR"].HeaderText = "Asansör Bakım";
            dgv_kirabakim.Columns["binaTASARİM"].HeaderText = "İç Mekan Tasarımı ve Dekorasyon";
            dgv_kirabakim.Columns["binaYANGİNST"].HeaderText = "Yangın Sistemleri";
            dgv_kirabakim.Columns["binaTOPLAM"].HeaderText = "Toplam";

            dgv_ogrenciekipman.Columns["malzemeTARİH"].HeaderText = "Tarih";
            dgv_ogrenciekipman.Columns["malzemeRESİM"].HeaderText = "Resim ve Sanat Malzemeleri";
            dgv_ogrenciekipman.Columns["malzemeSPOR"].HeaderText = "Spor Malzemeleri";
            dgv_ogrenciekipman.Columns["malzemeKUTUPHANE"].HeaderText = "Kütüphane Kaynakları";
            dgv_ogrenciekipman.Columns["malzemeLABORATUVAR"].HeaderText = "Laboratuvar Malzemeleri";
            dgv_ogrenciekipman.Columns["malzemeEGİTİM"].HeaderText = "Eğitim Teknolojileri";
            dgv_ogrenciekipman.Columns["malzemeTOPLAM"].HeaderText = "Toplam";

            dgv_yemek.Columns["yemekTARİH"].HeaderText = "Tarih";
            dgv_yemek.Columns["personelgider"].HeaderText = "Personel Gider";
            dgv_yemek.Columns["malzemegider"].HeaderText = "Malzeme Gider";
            dgv_yemek.Columns["beslenmedanisman"].HeaderText = "Danışman";
            dgv_yemek.Columns["yemekservis"].HeaderText = "Yemek Servis";
            dgv_yemek.Columns["ikramlar"].HeaderText = "İkramlar";
            dgv_yemek.Columns["toplam"].HeaderText = "Toplam";

            dgv_yonetimofis.Columns[0].Visible = false;
            dgv_yonetimofis.Columns["yonetimveofisTARİH"].HeaderText = "Tarih";
            dgv_yonetimofis.Columns["sigorta"].HeaderText = "Sigorta";
            dgv_yonetimofis.Columns["idariyazilim"].HeaderText = "İdari Yazılım";
            dgv_yonetimofis.Columns["toplantiegitim"].HeaderText = "Toplantı Eğitim";
            dgv_yonetimofis.Columns["reklamtanitim"].HeaderText = "Reklam Tanıtım";
            dgv_yonetimofis.Columns["ofismobilya"].HeaderText = "Ofis Mobilya";
            dgv_yonetimofis.Columns["ofistoplam"].HeaderText = "Toplam";
        }

        private void btn_ogrencimalzeme_Click(object sender, EventArgs e)
        {
            //OgrenciMalzeme formogrencibakim = new OgrenciMalzeme();
            ////KiraVeBinaBakim(formbinabakim);
            //formogrencibakim.TopLevel = false;
            //panel2.Controls.Add(formogrencibakim);
            //formogrencibakim.BringToFront();
            //formogrencibakim.Show();
            if (oncekiForm != null && !oncekiForm.IsDisposed)
            {
                oncekiForm.Close();
            }
            OgrenciMalzeme yeniForm = new OgrenciMalzeme();
            yeniForm.TopLevel = false; // Yeni formun ana formun altında olmasını sağla
            yeniForm.AutoScroll = true; // Eğer içerik fazlaysa, otomatik kaydırma eklensin
            panel2.Controls.Add(yeniForm); // Panel içinde yeni formu görüntüle
            yeniForm.FormClosed += (s, args) => { oncekiForm = null; };
            yeniForm.BringToFront();
            oncekiForm = yeniForm;
            yeniForm.Show();

        }

        private void btn_yemek_Click(object sender, EventArgs e)
        {
            //YemekHizmetleri formyemekhizmetleri = new YemekHizmetleri();
            ////KiraVeBinaBakim(formbinabakim);
            //formyemekhizmetleri.TopLevel = false;
            //panel2.Controls.Add(formyemekhizmetleri);
            //formyemekhizmetleri.BringToFront();
            //formyemekhizmetleri.Show();
            if (oncekiForm != null && !oncekiForm.IsDisposed)
            {
                oncekiForm.Close();
            }
            YemekHizmetleri yeniForm = new YemekHizmetleri();
            yeniForm.TopLevel = false; // Yeni formun ana formun altında olmasını sağla
            yeniForm.AutoScroll = true; // Eğer içerik fazlaysa, otomatik kaydırma eklensin
            panel2.Controls.Add(yeniForm); // Panel içinde yeni formu görüntüle
            yeniForm.BringToFront();
            yeniForm.FormClosed += (s, args) => { oncekiForm = null; };
            oncekiForm = yeniForm;
            yeniForm.Show();
        }

        private void btn_yonetim_Click(object sender, EventArgs e)
        {
            //YonetimVeOfis formyonetimveofis = new YonetimVeOfis();
            ////KiraVeBinaBakim(formbinabakim);
            //formyonetimveofis.TopLevel = false;
            //panel2.Controls.Add(formyonetimveofis);
            //formyonetimveofis.BringToFront();
            //formyonetimveofis.Show();
            if (oncekiForm != null && !oncekiForm.IsDisposed)
            {
                oncekiForm.Close();
            }
            YonetimVeOfis yeniForm = new YonetimVeOfis();
            yeniForm.TopLevel = false; // Yeni formun ana formun altında olmasını sağla
            yeniForm.AutoScroll = true; // Eğer içerik fazlaysa, otomatik kaydırma eklensin
            panel2.Controls.Add(yeniForm); // Panel içinde yeni formu görüntüle
            yeniForm.BringToFront();
            yeniForm.FormClosed += (s, args) => { oncekiForm = null; };
            oncekiForm = yeniForm;
            yeniForm.Show();
        }

        private void btn_enerjisu_Click(object sender, EventArgs e)
        {
            //EnerjiVeSu formenerjivesu = new EnerjiVeSu();
            ////KiraVeBinaBakim(formbinabakim);
            //formenerjivesu.TopLevel = false;
            //panel2.Controls.Add(formenerjivesu);
            //formenerjivesu.BringToFront();
            //formenerjivesu.Show();
            //if (formenerjivesu == null || formenerjivesu.IsDisposed)
            //{
            //    formenerjivesu = new EnerjiVeSu();
            //}

            if (oncekiForm != null && !oncekiForm.IsDisposed)
            {
                oncekiForm.Close();
            }

            // Diğer yeni formu aç
            EnerjiVeSu yeniForm = new EnerjiVeSu();
            yeniForm.TopLevel = false; // Yeni formun ana formun altında olmasını sağla
            yeniForm.AutoScroll = true; // Eğer içerik fazlaysa, otomatik kaydırma eklensin
            panel2.Controls.Add(yeniForm); // Panel içinde yeni formu görüntüle
            yeniForm.BringToFront();
            yeniForm.FormClosed += (s, args) => { oncekiForm = null; };
            oncekiForm = yeniForm;
            yeniForm.Show();
        }
    }
}
