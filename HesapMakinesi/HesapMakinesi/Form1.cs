using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string username = "Berkay";
        int password = 1234;
        int counter = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username == textBox1.Text && password == Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("Giris Basarili");
                Form1 form1 = new Form1();
                this.Hide();


                Form2 form = new Form2();
                form.Show();


            }
            else
            {
                MessageBox.Show("Kullanici Adi veya Sifre Hatali");
                counter++;
                if (counter == 3)
                {
                    MessageBox.Show("3 Defa Yanlis Giris Yaptiniz.");
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
