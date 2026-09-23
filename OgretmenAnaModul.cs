using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.cs
{
    public partial class OgretmenAnaModul : Form
    {
        public OgretmenAnaModul()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void OgretmenAnaModul_Load(object sender, EventArgs e)
        {

        }


        void Ogretmenler(Form Ogretmenler)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == Ogretmenler.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                Ogretmenler.MdiParent = this;
                Ogretmenler.Show();
            }
        }
        private void btn_ogretmenler_Click(object sender, EventArgs e)
        {
            Ogretmenler formogretmen = new Ogretmenler();
            Ogretmenler(formogretmen);
            formogretmen.TopLevel = false;
            panel2.Controls.Add(formogretmen);
            formogretmen.BringToFront();
            formogretmen.Show();
        }
        private void btn_ogrenciler_Click(object sender, EventArgs e)
        {
            Ogrenciler formogrenci = new Ogrenciler();
            Ogrenciler(formogrenci);
            formogrenci.TopLevel = false;
            panel2.Controls.Add(formogrenci);
            formogrenci.BringToFront();
            formogrenci.Show();
        }
        void Ogrenciler(Form Ogrenciler)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == Ogrenciler.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                Ogrenciler.MdiParent = this;
                Ogrenciler.Show();
            }
        }

        private void btn_veliler_Click(object sender, EventArgs e)
        {
            Veliler formveliler = new Veliler();
            Veliler(formveliler);
            formveliler.TopLevel = false;
            panel2.Controls.Add(formveliler);
            formveliler.BringToFront();
            formveliler.Show();
        }
        void Veliler(Form Veliler)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == Veliler.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                Veliler.MdiParent = this;
                Veliler.Show();
            }
        }


        private void btn_notgiris_Click(object sender, EventArgs e)
        {
            NotGiris formnotgiris = new NotGiris();
            NotGiris(formnotgiris);
            formnotgiris.TopLevel = false;
            panel2.Controls.Add(formnotgiris);
            formnotgiris.BringToFront();
            formnotgiris.Show();
        }
        void NotGiris(Form NotGiris)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == NotGiris.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                NotGiris.MdiParent = this;
                NotGiris.Show();
            }
        }


        private void bnt_istatistik_Click_1(object sender, EventArgs e)
        {
            İstatistikler formistatistikler = new İstatistikler();
            İstatistikler(formistatistikler);
            formistatistikler.TopLevel = false;
            panel2.Controls.Add(formistatistikler);
            formistatistikler.BringToFront();
            formistatistikler.Show();
        }
        void İstatistikler(Form İstatistikler)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == İstatistikler.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                İstatistikler.MdiParent = this;
                İstatistikler.Show();
            }
        }

        private void btn_devamsızlık_Click(object sender, EventArgs e)
        {
            Devamsızlıklar formdevamsızlıklar = new Devamsızlıklar();
            Devamsızlıklar(formdevamsızlıklar);
            formdevamsızlıklar.TopLevel = false;
            panel2.Controls.Add(formdevamsızlıklar);
            formdevamsızlıklar.BringToFront();
            formdevamsızlıklar.Show();
        }
        void Devamsızlıklar(Form Devamsızlıklar)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == Devamsızlıklar.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                Devamsızlıklar.MdiParent = this;
                Devamsızlıklar.Show();
            }
        }

        private void btn_rehber_Click(object sender, EventArgs e)
        {
            Rehber formrehber = new Rehber();
            Rehber(formrehber);
            formrehber.TopLevel = false;
            panel2.Controls.Add(formrehber);
            formrehber.BringToFront();
            formrehber.Show();
        }
        void Rehber(Form Rehber)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == Rehber.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (!durum)
            {
                Rehber.MdiParent = this;
                Rehber.Show();
            }
        }
    }
}