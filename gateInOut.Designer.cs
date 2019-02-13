namespace VTDI_Gate_Log1_flavaSolutions
{
    partial class gateInOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glblFname = new System.Windows.Forms.Label();
            this.glblLastName = new System.Windows.Forms.Label();
            this.glblMvLic = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbMvLic = new System.Windows.Forms.TextBox();
            this.tbVisitorId = new System.Windows.Forms.TextBox();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.timeIn = new System.Windows.Forms.DateTimePicker();
            this.timeOut = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.cbMotorVehicleType = new System.Windows.Forms.ComboBox();
            this.cbItemsDeclared = new System.Windows.Forms.ComboBox();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // glblFname
            // 
            this.glblFname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.glblFname.AutoSize = true;
            this.glblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblFname.Location = new System.Drawing.Point(3, 15);
            this.glblFname.Name = "glblFname";
            this.glblFname.Size = new System.Drawing.Size(82, 20);
            this.glblFname.TabIndex = 0;
            this.glblFname.Text = "FirstName";
            // 
            // glblLastName
            // 
            this.glblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.glblLastName.AutoSize = true;
            this.glblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblLastName.Location = new System.Drawing.Point(3, 64);
            this.glblLastName.Name = "glblLastName";
            this.glblLastName.Size = new System.Drawing.Size(86, 20);
            this.glblLastName.TabIndex = 0;
            this.glblLastName.Text = "Last Name";
            // 
            // glblMvLic
            // 
            this.glblMvLic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.glblMvLic.AutoSize = true;
            this.glblMvLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblMvLic.Location = new System.Drawing.Point(3, 104);
            this.glblMvLic.Name = "glblMvLic";
            this.glblMvLic.Size = new System.Drawing.Size(110, 40);
            this.glblMvLic.TabIndex = 0;
            this.glblMvLic.Text = "Motor Vehicle Registration";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 219);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(78, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Visitor I.D";
            // 
            // lblItems
            // 
            this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(3, 258);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(73, 40);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items Declared";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.62687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.37313F));
            this.tableLayoutPanel1.Controls.Add(this.cbMotorVehicleType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.glblFname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblItems, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.glblLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.glblMvLic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMvLic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbVisitorId, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDateIn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateIn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDateOut, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dateOut, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblVehicleType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbItemsDeclared, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 393);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbFname
            // 
            this.tbFname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.Location = new System.Drawing.Point(119, 7);
            this.tbFname.Multiline = true;
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(189, 35);
            this.tbFname.TabIndex = 1;
            // 
            // tbLname
            // 
            this.tbLname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLname.Location = new System.Drawing.Point(119, 56);
            this.tbLname.Multiline = true;
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(189, 35);
            this.tbLname.TabIndex = 1;
            // 
            // tbMvLic
            // 
            this.tbMvLic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbMvLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMvLic.Location = new System.Drawing.Point(119, 107);
            this.tbMvLic.Multiline = true;
            this.tbMvLic.Name = "tbMvLic";
            this.tbMvLic.Size = new System.Drawing.Size(189, 35);
            this.tbMvLic.TabIndex = 1;
            // 
            // tbVisitorId
            // 
            this.tbVisitorId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbVisitorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVisitorId.Location = new System.Drawing.Point(119, 214);
            this.tbVisitorId.Multiline = true;
            this.tbVisitorId.Name = "tbVisitorId";
            this.tbVisitorId.Size = new System.Drawing.Size(189, 30);
            this.tbVisitorId.TabIndex = 1;
            // 
            // lblDateIn
            // 
            this.lblDateIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIn.Location = new System.Drawing.Point(3, 313);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(62, 20);
            this.lblDateIn.TabIndex = 0;
            this.lblDateIn.Text = "Date In";
            // 
            // dateIn
            // 
            this.dateIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIn.Location = new System.Drawing.Point(119, 309);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(189, 29);
            this.dateIn.TabIndex = 2;
            // 
            // lblDateOut
            // 
            this.lblDateOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOut.Location = new System.Drawing.Point(3, 358);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(74, 20);
            this.lblDateOut.TabIndex = 0;
            this.lblDateOut.Text = "Date Out";
            // 
            // dateOut
            // 
            this.dateOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOut.Location = new System.Drawing.Point(119, 354);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(189, 29);
            this.dateOut.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(537, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 170);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.lblPurpose, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTimeIn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTimeOut, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.timeIn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.timeOut, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbPurpose, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(440, 296);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 142);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblPurpose
            // 
            this.lblPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(3, 12);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(68, 20);
            this.lblPurpose.TabIndex = 0;
            this.lblPurpose.Text = "Purpose";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.Location = new System.Drawing.Point(3, 57);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(61, 20);
            this.lblTimeIn.TabIndex = 0;
            this.lblTimeIn.Text = "Time In";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.Location = new System.Drawing.Point(3, 106);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(73, 20);
            this.lblTimeOut.TabIndex = 0;
            this.lblTimeOut.Text = "Time Out";
            // 
            // timeIn
            // 
            this.timeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeIn.Location = new System.Drawing.Point(106, 48);
            this.timeIn.Name = "timeIn";
            this.timeIn.ShowUpDown = true;
            this.timeIn.Size = new System.Drawing.Size(189, 29);
            this.timeIn.TabIndex = 1;
            // 
            // timeOut
            // 
            this.timeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeOut.Location = new System.Drawing.Point(106, 93);
            this.timeOut.Name = "timeOut";
            this.timeOut.ShowUpDown = true;
            this.timeOut.Size = new System.Drawing.Size(189, 29);
            this.timeOut.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(652, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(394, 469);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 38);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(3, 157);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(95, 40);
            this.lblVehicleType.TabIndex = 0;
            this.lblVehicleType.Text = "Motor VehicleType";
            // 
            // cbMotorVehicleType
            // 
            this.cbMotorVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotorVehicleType.FormattingEnabled = true;
            this.cbMotorVehicleType.Items.AddRange(new object[] {
            "Honda",
            "Toyota",
            "Suzuki",
            "Kia"});
            this.cbMotorVehicleType.Location = new System.Drawing.Point(119, 154);
            this.cbMotorVehicleType.Name = "cbMotorVehicleType";
            this.cbMotorVehicleType.Size = new System.Drawing.Size(189, 32);
            this.cbMotorVehicleType.TabIndex = 5;
            // 
            // cbItemsDeclared
            // 
            this.cbItemsDeclared.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItemsDeclared.FormattingEnabled = true;
            this.cbItemsDeclared.Items.AddRange(new object[] {
            "Laptop",
            "Cell Phone",
            "Fire Arm",
            "System Unit",
            "Mouse",
            "Keyboard"});
            this.cbItemsDeclared.Location = new System.Drawing.Point(119, 257);
            this.cbItemsDeclared.Name = "cbItemsDeclared";
            this.cbItemsDeclared.Size = new System.Drawing.Size(189, 32);
            this.cbItemsDeclared.TabIndex = 5;
            // 
            // cbPurpose
            // 
            this.cbPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Items.AddRange(new object[] {
            "Laptop",
            "Cell Phone",
            "Fire Arm",
            "System Unit",
            "Mouse",
            "Keyboard"});
            this.cbPurpose.Location = new System.Drawing.Point(106, 3);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(189, 32);
            this.cbPurpose.TabIndex = 5;
            // 
            // gateInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "gateInOut";
            this.Text = "gateInOut";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label glblFname;
        private System.Windows.Forms.Label glblLastName;
        private System.Windows.Forms.Label glblMvLic;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbMvLic;
        private System.Windows.Forms.TextBox tbVisitorId;
        private System.Windows.Forms.Label lblDateIn;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker timeIn;
        private System.Windows.Forms.DateTimePicker timeOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.ComboBox cbMotorVehicleType;
        private System.Windows.Forms.ComboBox cbItemsDeclared;
        private System.Windows.Forms.ComboBox cbPurpose;
    }
}