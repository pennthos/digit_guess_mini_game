using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntpoyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            static int[,] dizi = new int[3, 3];
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> dizi2 = new List<int>();
            dizi2.Add(1);
            dizi2.Add(2);
            dizi2.Add(3);
            dizi2.Add(4);
            dizi2.Add(5);
            dizi2.Add(6);
            dizi2.Add(7);
            dizi2.Add(8);
            dizi2.Add(9);
            int say = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int sayi= rnd.Next(1, say);
                    dizi[i, j] = dizi2[sayi-1];
                    dizi2.Remove(dizi2[sayi-1]);
                    say--;
                    

                }
            }
            label1.Text = (dizi[0, 0] + dizi[1, 0] + dizi[2, 0]).ToString();
            label2.Text = (dizi[1, 1] + dizi[0, 1] + dizi[2, 1]).ToString();
            label3.Text = (dizi[0, 2] + dizi[1, 2] + dizi[2, 2]).ToString();
            label6.Text = (dizi[0, 0] + dizi[0, 1] + dizi[0, 2]).ToString();
            label5.Text = (dizi[1, 0] + dizi[1, 1] + dizi[1, 2]).ToString();
            label4.Text = (dizi[2, 0] + dizi[2, 1] + dizi[2, 2]).ToString();
            textBox1.Text = dizi[0, 0].ToString();
            textBox2.Text = dizi[0, 1].ToString();
            textBox3.Text = dizi[0, 2].ToString();
            textBox4.Text = dizi[1, 0].ToString();
            textBox5.Text = dizi[1, 1].ToString();
            textBox6.Text = dizi[1, 2].ToString();
            textBox7.Text = dizi[2, 0].ToString();
            textBox8.Text = dizi[2, 1].ToString();
            textBox9.Text = dizi[2, 2].ToString();
            int sayac = 1;
            while (sayac < 6)
            {
                int sayi=rnd.Next(1, 9);
                string isim = "textBox" + sayi;
                foreach (Control item in Controls)
                {
                    if (item is TextBox && item.Name==isim && item.Text!="")
                    {
                        item.Text = "";
                        sayac++;
                    }
                }
                
            }
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != dizi[0, 0].ToString())
            {
                textBox1.ForeColor = Color.Red;
            }
            if (textBox2.Text != dizi[0, 1].ToString())
            {
                textBox2.ForeColor = Color.Red;
            }
            if (textBox3.Text != dizi[0, 2].ToString())
            {
                textBox3.ForeColor = Color.Red;
            }
            if (textBox4.Text != dizi[1, 0].ToString())
            {
                textBox4.ForeColor = Color.Red;
            }
            if (textBox5.Text != dizi[1, 1].ToString())
            {
                textBox5.ForeColor = Color.Red;
            }
            if (textBox6.Text != dizi[1, 2].ToString())
            {
                textBox6.ForeColor = Color.Red;
            }
            if (textBox7.Text != dizi[2, 0].ToString())
            {
                textBox7.ForeColor = Color.Red;
            }
            if (textBox8.Text != dizi[2, 1].ToString())
            {
                textBox8.ForeColor = Color.Red;
            }
            if (textBox9.Text != dizi[2, 2].ToString())
            {
                textBox9.ForeColor = Color.Red;
            }
            int say = 0;
            foreach (Control item in Controls)
            {
                if (item is TextBox && item.ForeColor==Color.Red)
                {
                    say++;
                }
            }
            if (say == 0)
            {
                MessageBox.Show("Başardınız");
            }
            else
            {
                MessageBox.Show("Lütfen hatalarını düzeltiniz");
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
