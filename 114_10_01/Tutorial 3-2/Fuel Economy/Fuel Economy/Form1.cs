﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers
                ;
            double liters;
            double kmpl;

            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);


            kmpl = kilometers / liters;

            mpgLabel.Text = kmpl.ToString("n2") + " 公里/公升";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
