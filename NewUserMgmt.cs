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
    public partial class NewUserMgmt : Form
    {
        public NewUserMgmt()
        {
            InitializeComponent();
        }

        private void UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vTDI_GLog_Db_Users_DataSources);

        }

        private void NewUserMgmt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_Users_DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.vTDI_GLog_Db_Users_DataSet.Users);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_Users_DataSources.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.vTDI_GLog_Db_Users_DataSources.Gender);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_Users_DataSources.Users' table. You can move, or remove it, as needed.



        }



        private void BtnSave_Click(object sender, EventArgs e)

        {

        }
        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }


        private void BtnNew_Click(object sender, EventArgs e)
        {

        }
    }


    }

