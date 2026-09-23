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
    public partial class AnaModul : Form
    {
        private List<Form> openForms = new List<Form>();
        private Form currentChildForm;
        public AnaModul()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        
       
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenForm(Form form)
        {
            
            if (!openForms.Contains(form))
            {
                openForms.Add(form); 
                form.FormClosed += (s, args) => openForms.Remove(form); 
                form.Show();
            }
        }

        private void AnaModul_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ogretmenler_Click(object sender, EventArgs e)
        {
            //Ogretmenler formogretmen = new Ogretmenler();
            //Ogretmenler(formogretmen);
            //formogretmen.TopLevel = false;
            //panel2.Controls.Add(formogretmen);
            //formogretmen.BringToFront();
            //formogretmen.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            
            OpenChildForm(new Ogretmenler());
            UpdateFormLabel("Ogretmenler");
        }


        private void btn_ogrenciler_Click(object sender, EventArgs e)
        {
            //Ogrenciler formogrenci = new Ogrenciler();
            //Ogrenciler(formogrenci);
            //formogrenci.TopLevel = false;
            //panel2.Controls.Add(formogrenci);
            //formogrenci.BringToFront();
            //formogrenci.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Ogrenciler());
            UpdateFormLabel("Ogrenciler");
        }

        private void btn_veliler_Click(object sender, EventArgs e)
        {

            //Veliler formveliler = new Veliler();
            //Veliler(formveliler);
            //formveliler.TopLevel = false;
            //panel2.Controls.Add(formveliler);
            //formveliler.BringToFront();
            //formveliler.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Veliler());
            UpdateFormLabel("Veliler");
        }
        

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            //Ayarlar formayarlar = new Ayarlar();
            //Ayarlar(formayarlar);
            //formayarlar.TopLevel = false;
            //panel2.Controls.Add(formayarlar);
            //formayarlar.BringToFront();
            //formayarlar.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Ayarlar());
            UpdateFormLabel("Ayarlar");
        }

       
        
        private void btn_notgiris_Click(object sender, EventArgs e)
        {
            //NotGiris formnotgiris = new NotGiris();
            //NotGiris(formnotgiris);
            //formnotgiris.TopLevel = false;
            //panel2.Controls.Add(formnotgiris);
            //formnotgiris.BringToFront();
            //formnotgiris.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new NotGiris());
            UpdateFormLabel("NotGiris");
        }
      

        private void bnt_istatistik_Click(object sender, EventArgs e)
        {
            //İstatistikler formistatistikler = new İstatistikler();
            //İstatistikler(formistatistikler);
            //formistatistikler.TopLevel = false;
            //panel2.Controls.Add(formistatistikler);
            //formistatistikler.BringToFront();
            //formistatistikler.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new İstatistikler());
            UpdateFormLabel("İstatistikler");
        }
       

        private void btn_devamsızlık_Click(object sender, EventArgs e)
        {
            //Devamsızlıklar formdevamsızlıklar = new Devamsızlıklar();
            //Devamsızlıklar(formdevamsızlıklar);
            //formdevamsızlıklar.TopLevel = false;
            //panel2.Controls.Add(formdevamsızlıklar);
            //formdevamsızlıklar.BringToFront();
            //formdevamsızlıklar.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Devamsızlıklar());
            UpdateFormLabel("Devamsızlıklar");
        }
       
        

        private void btn_rehber_Click(object sender, EventArgs e)
        {

            //Rehber formrehber = new Rehber();
            //Rehber(formrehber);
            //formrehber.TopLevel = false;
            //panel2.Controls.Add(formrehber);
            //formrehber.BringToFront();
            //formrehber.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Rehber());
            UpdateFormLabel("Rehber");
        }
       

        private void btn_giderler_Click(object sender, EventArgs e)
        {
            //Giderler formgiderler = new Giderler();
            //Giderler(formgiderler);
            //formgiderler.TopLevel = false;
            //panel2.Controls.Add(formgiderler);
            //formgiderler.BringToFront();
            //formgiderler.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Giderler());
            UpdateFormLabel("Giderler");
        }
        

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            //Duyurular formduyurular = new Duyurular();
            //Duyurular(formduyurular);
            //formduyurular.TopLevel = false;
            //panel2.Controls.Add(formduyurular);
            //formduyurular.BringToFront();
            //formduyurular.Show();
            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
            OpenChildForm(new Duyurular());
            UpdateFormLabel("Duyurular");
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateFormLabel(string formName)
        {
            label1.Text = formName;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}

