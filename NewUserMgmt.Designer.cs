namespace VTDI_Gate_Log1_flavaSolutions
{
    partial class NewUserMgmt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblLastName;
            System.Windows.Forms.Label lblEmailAddress;
            System.Windows.Forms.Label lblUsrname;
            System.Windows.Forms.Label lblPassword;
            System.Windows.Forms.Label lblGender;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserMgmt));
            this.vTDI_GLog_Db_Users_DataSources = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSources();
            this.usersTableAdapter = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSourcesTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSourcesTableAdapters.TableAdapterManager();
            this.genderTableAdapter = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSourcesTableAdapters.GenderTableAdapter();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTDIGLogDbUsersDataSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbId = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.vTDI_GLog_Db_EditedDataSet = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_EditedDataSet();
            this.vTDIGLogDbEditedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vTDI_GLog_Db_Users_DataSet = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSet();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSetTableAdapters.TableAdapterManager();
            this.lblStatus = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblEmailAddress = new System.Windows.Forms.Label();
            lblUsrname = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblGender = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vTDI_GLog_Db_Users_DataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTDIGLogDbUsersDataSourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTDI_GLog_Db_EditedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTDIGLogDbEditedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTDI_GLog_Db_Users_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFirstName.Location = new System.Drawing.Point(14, 138);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(76, 16);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblLastName.AutoSize = true;
            lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLastName.Location = new System.Drawing.Point(14, 181);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(76, 16);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmailAddress.Location = new System.Drawing.Point(14, 229);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new System.Drawing.Size(42, 16);
            lblEmailAddress.TabIndex = 6;
            lblEmailAddress.Text = "Email";
            // 
            // lblUsrname
            // 
            lblUsrname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblUsrname.AutoSize = true;
            lblUsrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUsrname.Location = new System.Drawing.Point(12, 285);
            lblUsrname.Name = "lblUsrname";
            lblUsrname.Size = new System.Drawing.Size(74, 16);
            lblUsrname.TabIndex = 8;
            lblUsrname.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPassword.Location = new System.Drawing.Point(13, 330);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(71, 16);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password:";
            // 
            // lblGender
            // 
            lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGender.Location = new System.Drawing.Point(14, 370);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(56, 16);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(12, 418);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 16);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            // 
            // vTDI_GLog_Db_Users_DataSources
            // 
            this.vTDI_GLog_Db_Users_DataSources.DataSetName = "VTDI_GLog_Db_Users_DataSources";
            this.vTDI_GLog_Db_Users_DataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorTableAdapter = null;
            this.tableAdapterManager.GateLogTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = this.genderTableAdapter;
            this.tableAdapterManager.ItemsTo_DeclareTableAdapter = null;
            this.tableAdapterManager.PurposeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSourcesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.Vehicle_TypeTableAdapter = null;
            this.tableAdapterManager.Visitor_TypeTableAdapter = null;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(108, 129);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(169, 25);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(108, 178);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(169, 25);
            this.tbLastName.TabIndex = 5;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAddress.Location = new System.Drawing.Point(108, 226);
            this.tbEmailAddress.Multiline = true;
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(169, 25);
            this.tbEmailAddress.TabIndex = 7;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(108, 276);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(169, 25);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(108, 321);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(169, 25);
            this.tbPassword.TabIndex = 11;
            // 
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genderBindingSource, "Id", true));
            this.cbGender.DataSource = this.genderBindingSource;
            this.cbGender.DisplayMember = "name";
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(108, 367);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(169, 24);
            this.cbGender.TabIndex = 13;
            this.cbGender.ValueMember = "Id";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.vTDIGLogDbUsersDataSourcesBindingSource;
            // 
            // vTDIGLogDbUsersDataSourcesBindingSource
            // 
            this.vTDIGLogDbUsersDataSourcesBindingSource.AllowNew = true;
            this.vTDIGLogDbUsersDataSourcesBindingSource.DataSource = this.vTDI_GLog_Db_Users_DataSources;
            this.vTDIGLogDbUsersDataSourcesBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.vTDI_GLog_Db_Users_DataSources;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(108, 407);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(169, 24);
            this.tbId.TabIndex = 14;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 464);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 41);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 41);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 464);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 41);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(225, 464);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 41);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // vTDI_GLog_Db_EditedDataSet
            // 
            this.vTDI_GLog_Db_EditedDataSet.DataSetName = "VTDI_GLog_Db_EditedDataSet";
            this.vTDI_GLog_Db_EditedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vTDIGLogDbEditedDataSetBindingSource
            // 
            this.vTDIGLogDbEditedDataSetBindingSource.DataSource = this.vTDI_GLog_Db_EditedDataSet;
            this.vTDIGLogDbEditedDataSetBindingSource.Position = 0;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.vTDIGLogDbUsersDataSourcesBindingSource;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // vTDI_GLog_Db_Users_DataSet
            // 
            this.vTDI_GLog_Db_Users_DataSet.DataSetName = "VTDI_GLog_Db_Users_DataSet";
            this.vTDI_GLog_Db_Users_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.vTDI_GLog_Db_Users_DataSet;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = VTDI_Gate_Log1_flavaSolutions.VTDI_GLog_Db_Users_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(454, 491);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status";
            // 
            // NewUserMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.tbId);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(lblEmailAddress);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(lblUsrname);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(lblGender);
            this.Controls.Add(this.cbGender);
            this.Name = "NewUserMgmt";
            this.Text = "NewUserMgmt";
            this.Load += new System.EventHandler(this.NewUserMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vTDI_GLog_Db_Users_DataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTDIGLogDbUsersDataSourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTDI_GLog_Db_EditedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTDIGLogDbEditedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTDI_GLog_Db_Users_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VTDI_GLog_Db_Users_DataSources vTDI_GLog_Db_Users_DataSources;
        private VTDI_GLog_Db_Users_DataSourcesTableAdapters.UsersTableAdapter usersTableAdapter;
        private VTDI_GLog_Db_Users_DataSourcesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRemove;
        private VTDI_GLog_Db_Users_DataSourcesTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource vTDIGLogDbUsersDataSourcesBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private VTDI_GLog_Db_EditedDataSet vTDI_GLog_Db_EditedDataSet;
        private System.Windows.Forms.BindingSource vTDIGLogDbEditedDataSetBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.Timer timer1;
        private VTDI_GLog_Db_Users_DataSet vTDI_GLog_Db_Users_DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private VTDI_GLog_Db_Users_DataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private VTDI_GLog_Db_Users_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lblStatus;
    }
}