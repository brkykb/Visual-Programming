﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id, name, surname, p_number, job;
            Id = textBox1.Text;
            name = textBox2.Text;
            surname = textBox3.Text;
            p_number = textBox4.Text;
            job = textBox5.Text;

            string[] colum = {Id, name, surname, p_number, job };
            ListViewItem records = new ListViewItem(colum);
            listView1.Items.Add(records);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
