using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0, tahmin_sayisi = 0, puan = 1000;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayisi++;
            if (tahmin_sayisi <= 10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin_sayisi.ToString();
                if (sayi < tahmin)
                {
                    label5.Text = "Tahmini Azaltınız";
                    puan = puan - 100;
                    label7.Text = puan.ToString();

                }
                else if (sayi > tahmin)
                {
                    label5.Text = "Tahmini Artırınız";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else
                {
                    label5.Text = "Tebrikler Bildiniz !. " + tahmin_sayisi + " denemede buldunuz." + label7.Text + " puan aldınız";
                    button2.Enabled = true;
                    button1.Enabled = false;

                }
                textBox1.Text = "";

            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin Hakkınız Kalmadı ");
                this.Close();

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random rnd = new Random();
            sayi = rnd.Next(100);
            label8.Text = "İpucu " + sayi.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";

        }


    }
}
