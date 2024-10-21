using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double r;
        const double pi = 3.14;
        double result;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            result = 2 * pi * r;
            label3.Text = "Circumference of Circle is " + result;
            MessageBox.Show("Circumference of Circle is " + result);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            result = pi * r * r;
            label3.Text = "Area of Circle is " + result;
            MessageBox.Show("Area of Circle is " + result);
        }
    }
}
