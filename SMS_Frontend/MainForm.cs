﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Frontend
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }
    }
}
