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
    public partial class Form2 : Form
    {
        char _proces_type;
        bool _clear_screen;
        int _first_number;

        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Screen_Label.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int second_number = Convert.ToInt16(Screen_Label.Text);
            double result;

            switch (_proces_type)
            {
                case '+':
                    result = _first_number + second_number;
                    break;
                case '-':
                    result = _first_number - second_number;
                    break;
                case '*':
                    result = _first_number * second_number;
                    break;
                case '/':
                    result = _first_number / second_number;
                    break;
                default:
                    result = 0;
                    break;
            }
            Screen_Label.Text = Convert.ToString(result);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _proces_type = '/';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_Label.Text);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            _proces_type = '*';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_Label.Text);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            _proces_type = '-';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_Label.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            _proces_type = '+';
            _clear_screen = true;
            _first_number = Convert.ToInt32(Screen_Label.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clear_screen == true)
            {
                Screen_Label.Text = "";
                _clear_screen = false;
            }
            if (Screen_Label.Text == "0") Screen_Label.Text = "";
            Screen_Label.Text += "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
