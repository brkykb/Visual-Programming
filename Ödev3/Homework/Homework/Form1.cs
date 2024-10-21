using System;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        int number, right = 4;
        Random rand = new Random();
        int guess; 

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
           
            if(right == 0)
                Application.Exit();

            else if (guess == number)
            {
                textBox2.Text = "You are right!";
            }
            else
            {
                textBox2.Text = "You are wrong!";
                right--;
            }
            textBox3.Text = "You have " + (right+1) + " guesses left";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            guess = rand.Next(1, 100);

        }
    }
}
