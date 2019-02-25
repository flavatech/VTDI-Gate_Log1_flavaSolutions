using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace VTDI_Gate_Log1_flavaSolutions
{
    public partial class gateInOut : Form
    {
        public gateInOut()
        {
            InitializeComponent();
        }
        /// Create Connection



        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)

        {
         //var recordDate = DateTime.Now; gets the current date and time.
            //Data Validation
            var recordDate = DateTime.Now;
            var FirstName = tbFname.Text;
            var lastName = tbLname.Text;
            var plateNumber = tbGender.Text;
            var motorVehicleType = cbMvType.SelectedItem.ToString();
            var visitorId = tbVisitorId.Text;
            var itemsDeclared = cbItemsDeclared.SelectedItem.ToString();
            var purposeOfVisit = cbPurpose.SelectedItem.ToString();
            /* var VisitorCategory = cbVisitorCategory.ToString();

           if (String.IsNullOrEmpty(motorVehicleType))
            {MessageBox.Show("Motor Vehicle Type is Required!");
            }*/
            if (String .IsNullOrEmpty(lastName))

            {
                MessageBox.Show("Last Name is Required!");
            }

            {

            }
            MessageBox.Show($"First Name: {FirstName}\r \n" +
                $"Last Name: {lastName}\r \n" +
                $"Plate Number: {plateNumber}\r \n" +
                $"Motor Vehicle Type: {motorVehicleType}\r \n" +
                $"Visitor ID: {visitorId}\r \n" +
                $"Items Declared: {itemsDeclared} \r \n" +
                $"Purpose of Visit: {purposeOfVisit}\r \n" +
               $"Date and Time In: {recordDate}");

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void PBVisitorImage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
