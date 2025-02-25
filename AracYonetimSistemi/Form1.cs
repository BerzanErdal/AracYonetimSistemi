using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracYonetimSistemi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private void texttemizle()
        {
            textBoxKulaniciAdi.Text = textBoxSifre.Text = "";
            textBoxKulaniciAdi.Focus();
        }
        private void buttonAdminGirisi_Click(object sender, EventArgs e)
        {
            string Adi = "Berzan";
            string Sifre = "123";
            if (textBoxKulaniciAdi.Text == Adi && textBoxSifre.Text == Sifre)
            {
                texttemizle();
                Admin admin = new Admin();
                admin.Show();
                MessageBox.Show($"{Adi} Hoşgeldiniz");
                
            }
            else
            {
                MessageBox.Show("kulanıcı adı veya sifre girişi hatalı lütfen tekrar deneyiniz");
                texttemizle();
            }
        }

        private void buttonKulaniciGirisi_Click(object sender, EventArgs e)
        {
            string Adi = "Ali";
            string Sifre = "12";
            if (textBoxKulaniciAdi.Text == Adi && textBoxSifre.Text == Sifre)
            {
                texttemizle();
                Kulanici kulanici = new Kulanici();
                kulanici.Show();
                MessageBox.Show($"{Adi} Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("kulanıcı adı veya sifre girişi hatalı lütfen tekrar deneyiniz");
                texttemizle();
            }
        }
    }
}
