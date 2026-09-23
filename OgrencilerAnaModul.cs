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
    public partial class OgrencilerAnaModul : Form
    {
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public OgrencilerAnaModul()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }

        private void OgrencilerAnaModul_Load(object sender, EventArgs e)
        {
            NotlariGetir();
            devamsizlikgetir();
            lbl_ogrenciadsoyad.Text = GirisYapanBilgileri.OgrenciAdSoyad;
            lbl_sinif.Text = GirisYapanBilgileri.OgrenciSinif;
            lbl_tckimlik.Text = GirisYapanBilgileri.OgrenciTC;
            pictureBox1.ImageLocation = GirisYapanBilgileri.OgrenciFoto;
        }
        void NotlariGetir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

                string query = $"SELECT notBRANS, sinav1, sinav2, sozlu1, sozlu2, sozlu3, ortalama, basaridurum FROM notlar WHERE notTC='{GirisYapanBilgileri.OgrenciTC}'";
                //string query1 = "SELECT notBRANS, sinav1, sinav2, sozlu1, sozlu2, sozlu3, ortalama, basaridurum FROM notlar WHERE notTC='"+GirisYapanBilgileri.OgrenciTC+"'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_ogrencianamodul.DataSource = dataTable;

                baglanti.Close();
            }
            
        }

       void devamsizlikgetir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string query = $"SELECT devamsızlıkTARİH,devamsızlıkDURUM,devamsızlıkTUR FROM devamsızlıklar WHERE devamsızlıkADSOYAD='{GirisYapanBilgileri.OgrenciAdSoyad}'";
                MySqlDataAdapter adapter= new MySqlDataAdapter(query,baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_devamsızlık.DataSource=dataTable;

                baglanti.Close();
            }
        }
    }
}
