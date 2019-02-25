using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
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
            var username = tbUsername.Text;
            var password = tbPassword.Text;


            //Declare an object of the database Model
            var datactx = new VTDI_GLog_DbEntities();

           /*Validate input at the application level
            * Credits Balamurugan1989 Codeproject.com
            * Credits Trevoir Williams *Var
            */

         if(username == "")
            {
                String theusername = String.Empty;

                MessageBox.Show("User Name is required");
            }
         else if(password == "")
            {
                String thepassword = String.Empty;
                MessageBox.Show("Pass Code is required");
            }
        else
            {

            //Lambda Expression to check if username and password exists
             var userCount = datactx.Users.Count(q => q.username == username && q.password == password);

        if      (userCount != 1)
            {
                MessageBox.Show("Invalid Credentials");
            }
        else
            {
               this.Hide();
               btnLogin.Show();
               MessageBox.Show($"Welcome {username}");
            }

            }

            }
       // Set Error Icons For Username and password Boxes
        void TbUsername_Validating(object sender, CancelEventArgs e)
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                ErrorProvider errorProvider2 = new ErrorProvider();
                ErrorProvider errorProvider3 = new ErrorProvider();

                var username = tbUsername;
            if (username.Text == String.Empty)
            {
                errorProvider1.SetError(username, "Please enter User name");
                errorProvider2.SetError(username, "");
                errorProvider3.SetError(username, "");
            }
            else
            {
                errorProvider1.SetError(username, "");
                errorProvider2.SetError(username, "");
                errorProvider3.SetError(username, "user name Entered");
            {
            }

            }

        }

        private void TbPassword_Validated(object sender, EventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            ErrorProvider errorProvider2 = new ErrorProvider();
            ErrorProvider errorProvider3 = new ErrorProvider();
            var password = tbPassword;
            if (password.Text == String.Empty)
            {
                errorProvider1.SetError(password, "Please enter Pass word");
                errorProvider2.SetError(password, "");
                errorProvider3.SetError(password, "");
            }
            else
            {
                errorProvider1.SetError(password, "");
                errorProvider2.SetError(password, "");
                errorProvider3.SetError(password, "A password was Entered");
                {
                }
            }
        }
     }
   }
//
