using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string name;
        string surname;
        string country;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            textBox3.BackColor = colorDialog.Color;
            colorDialog.Reset(); 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            name = inputText;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox2.Text;
            surname = inputText;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            country = selectedItem;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string selectedOption = "";
            
            selectedOption = radioButton1.Text;
            
            

   
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string selectedOption = "";

            selectedOption = radioButton2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string selectedOptions2 = "";
            selectedOptions2 += checkBox1.Text + ", ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string selectedOptions2 = "";
            selectedOptions2 += checkBox2.Text + ", ";
     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int totalSelections = 0; // Toplam seçim sayısı
            int currentProgress = 0; // Mevcut ilerleme

            // Hangi CheckBox'ların seçildiğini kontrol et
           
            if (checkBox1.Checked)
            {
                totalSelections++;
            }
            else if (checkBox2.Checked)
            {
                totalSelections++;
            }
            if (radioButton1.Checked)
            {
                totalSelections++;
            }
            else if (radioButton2.Checked)
            {
                totalSelections++;
            }


            // Seçim sayısına göre ProgressBar'ı güncelle
            if (totalSelections > 0)
            {
                currentProgress = (totalSelections * 100) / 3; // 3 toplam seçim
                progressBar1.Value = currentProgress; // ProgressBar'ı güncelle
            }
        }
    }
}
