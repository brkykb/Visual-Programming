using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Odev4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int krSaat = 0;
        int krDakika = 0;
        int krSaniye = 0;
        int krSalise = 0;
        int krSayac = 0;
        public static string Results = "Kronometre Values: " + System.Environment.NewLine;
        public static SaveFileDialog sfd = new SaveFileDialog();

        int tmSaat = 0;
        int tmDakika = 0;
        int tmSaniye = 0;
        int tmSalise = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString("dd MMM yyyy");
            label16.Text = DateTime.Now.ToString("HH:mm:ss");
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            krSalise++;
            if (krSalise == 60)
            {
                krSalise = 0;
                krSaniye++;
            }
            if (krSaniye == 60)
            {
                krSaniye = 0;
                krDakika++;
            }
            if (krDakika == 60)
            {
                krDakika = 0;
                krSaat++;
            }

            label9.Text = krSalise.ToString();
            label8.Text = krSaniye.ToString();
            label7.Text = krDakika.ToString();
            label6.Text = krSaat.ToString();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {


        }

        private void label15_Click(object sender, EventArgs e)
        {
            

        }

        private void label16_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            krSalise = 0;
            krSaniye = 0;
            krDakika = 0;
            krSaat = 0;

            label9.Text = "00";
            label8.Text = "00";
            label7.Text = "00";
            label6.Text = "00";



        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label6.Text + ":" + label7.Text + ":" + label8.Text + ":" + label9.Text);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            Results = Results + listBox1.GetItemText(listBox1.SelectedItem) + System.Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Results = Results + System.Environment.NewLine + System.DateTime.Now + System.Environment.NewLine;
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "Results";
            sfd.Title = "Result Save File";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {

                string path = sfd.FileName;
                StreamWriter stW = new StreamWriter(File.Create(path));
                stW.Write(Results);
                stW.Dispose();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;

            tmSaat = 0;
            tmDakika = 0;
            tmSaniye = 0;
            tmSalise = 0;

            label17.Text = String.Format("{0:00}", tmSaat);
            label18.Text = String.Format("{0:00}", tmDakika);
            label19.Text = String.Format("{0:00}", tmSaniye);
            label27.Text = String.Format("{0:00}", tmSalise);

            timer2.Stop();



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
            


        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tmSaat = Convert.ToInt32(numericUpDown1.Value);
            tmDakika = Convert.ToInt32(numericUpDown2.Value);
            tmSaniye = Convert.ToInt32(numericUpDown3.Value);
            timer2.Start();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(tmSaat == 0 && tmDakika == 0 && tmSaniye == 0 &&tmSalise == 0)
            {
                timer2.Stop();
                MessageBox.Show("Time is up!");
            }
            else
            {
                tmSalise--;
                if (tmSalise == -1)
                {
                    tmSalise = 59;
                    tmSaniye--;
                }
                if (tmSaniye == -1)
                {
                    tmSaniye = 59;
                    tmDakika--;
                }
                if (tmDakika == -1)
                {
                    tmDakika = 59;
                    tmSaat--;
                }

                label27.Text = tmSalise.ToString();
                label19.Text = tmSaniye.ToString();
                label18.Text = tmDakika.ToString();
                label17.Text = tmSaat.ToString();
            }
        }
    }
}
