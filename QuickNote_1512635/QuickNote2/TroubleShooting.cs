﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote2
{
    public partial class TroubleShooting : MetroFramework.Forms.MetroForm
    {
        public TroubleShooting()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("You have not entered a connection string!");
            else
            {
                try {
                    SqlConnection connection = new SqlConnection(textBox1.Text);
                    App.connect = textBox1.Text;
                    MessageBox.Show("You have successfully change this connection string!");
                }
                catch(Exception e1)
                {
                    MessageBox.Show("You have changed the connection string failed!");
                }
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
