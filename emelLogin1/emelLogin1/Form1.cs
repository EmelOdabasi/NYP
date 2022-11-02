using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emelLogin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sifre  = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==  "kullaniciAdi" && textBox2.Text == "sifre")
            {
                MessageBox.Show("Giriş Yapıldı");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlış Lütfen Yeniden Deneyiniz");
            }
        
        
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
