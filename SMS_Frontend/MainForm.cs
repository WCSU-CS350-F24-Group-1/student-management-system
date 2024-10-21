using System;
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
        private bool LogoutClicked = false;
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!LogoutClicked) DialogResult = DialogResult.Cancel; // the dialogresult will only be Cancel if the logout button wasn't clicked
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Continue;
            LogoutClicked = true;
            Close();
        }
    }
}
