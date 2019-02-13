using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_Gate_Log1_flavaSolutions
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbPassword.MaxLength = 20;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            vtdi_gateLog_flavaSolutions1 btnLogin = new vtdi_gateLog_flavaSolutions1();
            this.Hide();
            btnLogin.Show();
        }
    }
}
