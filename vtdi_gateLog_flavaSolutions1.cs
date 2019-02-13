using System;
using System.Windows.Forms;

namespace VTDI_Gate_Log1_flavaSolutions
{
    public partial class vtdi_gateLog_flavaSolutions1 : Form
    {
        public vtdi_gateLog_flavaSolutions1()
        {
            InitializeComponent();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Users Button Clicked");
        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Button Clicked");
        }

        private void GateLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Gate Logs Button Clicked");
        }

        private void GuestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Guest List Button Clicked");
        }

        private void GateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gateInOut Form = new gateInOut();
            
            // this.Hide();
            Form.Show();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports Button Clicked");
        }

        private void GateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Reports Button Clicked");
        }

        private void UserLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Logs Button Clicked");
        }

        private void SchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Schedules Button Clicked");
        }

        private void Vtdi_gateLog_flavaSolutions1_Load(object sender, EventArgs e)
        {

        }
    }
}
