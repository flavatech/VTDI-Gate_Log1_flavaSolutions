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

        /*
         * Declare an object of the database global to the class to ensure that it is accessible
         * to the class.
         * This is the code used (private VTDI_GLog_Db_EditedEntities gltx)
         */
        private VTDI_GLog_Db_EditedEntities1 ginctx;
        public gateInOut()
        {
            InitializeComponent();

        }


        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void GateInOut_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet2.Color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.vTDI_GLog_Db_EditedDataSet2.Color);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet1.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter1.Fill(this.vTDI_GLog_Db_EditedDataSet1.Gender);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.vTDI_GLog_Db_EditedDataSet.Gender);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet.ItemsTo_Declare' table. You can move, or remove it, as needed.
            this.itemsTo_DeclareTableAdapter.Fill(this.vTDI_GLog_Db_EditedDataSet.ItemsTo_Declare);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet.Purpose' table. You can move, or remove it, as needed.
            this.purposeTableAdapter.Fill(this.vTDI_GLog_Db_EditedDataSet.Purpose);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet.Visitor_Type' table. You can move, or remove it, as needed.
            this.visitor_TypeTableAdapter.Fill(this.vTDI_GLog_Db_EditedDataSet.Visitor_Type);
            // TODO: This line of code loads data into the 'vTDI_GLog_Db_EditedDataSet.Vehicle_Type' table. You can move, or remove it, as needed.
            this.vehicle_TypeTableAdapter.Fill(this.vTDI_GLog_Db_EditedDataSet.Vehicle_Type);

            //Initialize the object of ginctx for database access
            ginctx = new VTDI_GLog_Db_EditedEntities1();


         }

        private void BtnSubmit_Click(object sender, EventArgs e)

        {
            //Get all the variables from the form interface.  Store in variables for ease of use

            var firstName = tbFname.Text;
            var lastName = tbLname.Text;
            var gender = cbGender.SelectedValue;
            var itemsDeclared = cbItemsDeclared.SelectedValue;
            var purposeOfVisit = cbPurpose.SelectedValue;
            var visitorCategory = cbVisitorCategory.SelectedValue;
            var motorVehicleType = cbMvType.SelectedValue;
            var plateNum = tbMvPlate.Text;
            var Color = cbColor.SelectedValue;
            var TimeIn = DateTime.Now;




            /*

           if (String.IsNullOrEmpty(motorVehicleType))
            {MessageBox.Show("Motor Vehicle Type is Required!");
            }*/
            if (String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(firstName))

            {
                MessageBox.Show("First name and Last Name is Required!");
                this.Show();
            }

            else

            {



                /*Create an variable of the table which you are bout the store
                 the data in. Get this from your database.*/
                //You could also use Gatelog record = new Gatelog();
                //var record = new GateLog();
                GateLog record = new GateLog();

                //Populate the fields in the object
                record.FirstName = firstName;
                record.LastName = lastName;
                record.GenderTypeId = int.Parse(gender.ToString());
                record.ItemsToDeclareId = int.Parse(itemsDeclared.ToString());
                record.PurposeID = int.Parse(purposeOfVisit.ToString());
                record.VisitorTypeId = int.Parse(visitorCategory.ToString());
                record.VehicleTypeId = int.Parse(motorVehicleType.ToString());
                record.MotorVehicleRegistration = plateNum;
                record.ColorID = int.Parse(Color.ToString());
                record.TimeIn = TimeIn;
                string s = TimeIn.ToString(); // dd/MM/yyyy hh:mm

                //Add the record (or object) to the table and save changes
                ginctx.GateLogs.Add(record);
                ginctx.SaveChanges();
                clear();
                MessageBox.Show("Data Entered Successfully");

                }

            }

        void clear()

        { //Use Var to  enable use of user friendly names in clear command below.
             var Firstname = tbFname;
             var Lastname =  tbLname;
             var Gender = cbGender;
             var Items = cbItemsDeclared;
             var Purpose = cbPurpose;
             var VisitorCategory =  cbVisitorCategory;
             var MotorVehicleType = cbMvType;
             var plateNum = tbMvPlate;
             var Color = cbColor;


            Firstname.Clear();
            Lastname.Clear();
            Items.Text = "";
            Gender.Text = "";
            Purpose.Text = "";
            VisitorCategory.Text = "";
            MotorVehicleType.Text = "";
            plateNum.Clear();
            Color.Text = "";
            Firstname.Focus();



        }
        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
            MessageBox.Show("Form Cleared Successfully");
        }

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.gateLogTableAdapter.FillBy(this.gDataSetForAll.GateLog, motorVehicleRegistrationToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
