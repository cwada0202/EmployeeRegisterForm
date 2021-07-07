namespace EmployeeRecord
{
    partial class frmUpdate
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
            System.Windows.Forms.Label lblempId;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label lblDeptName;
            System.Windows.Forms.Label lblAddLine1;
            System.Windows.Forms.Label lblAddLine2;
            System.Windows.Forms.Label lblCityName;
            System.Windows.Forms.Label regionNameLabel1;
            System.Windows.Forms.Label lblPostalCode;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtmName = new System.Windows.Forms.TextBox();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAddLine1 = new System.Windows.Forms.TextBox();
            this.txtAddLine2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.employeeDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeRecordDataSet = new EmployeeRecord.EmployeeRecordDataSet();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.TableAdapterManager();
            this.citiesTableAdapter = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.CitiesTableAdapter();
            this.departmentsTableAdapter = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.DepartmentsTableAdapter();
            this.empAddressTableAdapter = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.EmpAddressTableAdapter();
            this.regionsTableAdapter = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.RegionsTableAdapter();
            this.employeeEmpAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empAddressCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lblempId = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            lblDeptName = new System.Windows.Forms.Label();
            lblAddLine1 = new System.Windows.Forms.Label();
            lblAddLine2 = new System.Windows.Forms.Label();
            lblCityName = new System.Windows.Forms.Label();
            regionNameLabel1 = new System.Windows.Forms.Label();
            lblPostalCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEmpAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empAddressCitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblempId
            // 
            lblempId.AutoSize = true;
            lblempId.Enabled = false;
            lblempId.Location = new System.Drawing.Point(103, 58);
            lblempId.Name = "lblempId";
            lblempId.Size = new System.Drawing.Size(128, 20);
            lblempId.TabIndex = 1;
            lblempId.Text = "Employee ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(141, 127);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(111, 20);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(469, 130);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(129, 20);
            middleNameLabel.TabIndex = 5;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(762, 130);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(108, 20);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new System.Drawing.Point(762, 195);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(98, 20);
            hireDateLabel.TabIndex = 11;
            hireDateLabel.Text = "Hire Date:";
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Location = new System.Drawing.Point(76, 191);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new System.Drawing.Size(176, 20);
            lblDeptName.TabIndex = 9;
            lblDeptName.Text = "Department Name:";
            // 
            // lblAddLine1
            // 
            lblAddLine1.AutoSize = true;
            lblAddLine1.Location = new System.Drawing.Point(103, 256);
            lblAddLine1.Name = "lblAddLine1";
            lblAddLine1.Size = new System.Drawing.Size(149, 20);
            lblAddLine1.TabIndex = 13;
            lblAddLine1.Text = "Address Line01:";
            // 
            // lblAddLine2
            // 
            lblAddLine2.AutoSize = true;
            lblAddLine2.Location = new System.Drawing.Point(103, 316);
            lblAddLine2.Name = "lblAddLine2";
            lblAddLine2.Size = new System.Drawing.Size(149, 20);
            lblAddLine2.TabIndex = 15;
            lblAddLine2.Text = "Address Line02:";
            // 
            // lblCityName
            // 
            lblCityName.AutoSize = true;
            lblCityName.Location = new System.Drawing.Point(145, 381);
            lblCityName.Name = "lblCityName";
            lblCityName.Size = new System.Drawing.Size(107, 20);
            lblCityName.TabIndex = 17;
            lblCityName.Text = "City Name:";
            // 
            // regionNameLabel1
            // 
            regionNameLabel1.AutoSize = true;
            regionNameLabel1.Location = new System.Drawing.Point(496, 381);
            regionNameLabel1.Name = "regionNameLabel1";
            regionNameLabel1.Size = new System.Drawing.Size(132, 20);
            regionNameLabel1.TabIndex = 19;
            regionNameLabel1.Text = "Region Name:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new System.Drawing.Point(789, 381);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new System.Drawing.Size(117, 20);
            lblPostalCode.TabIndex = 21;
            lblPostalCode.Text = "Postal Code:";
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = null;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = null;
            this.employeeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(1147, 27);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // txtEmpId
            // 
            this.txtEmpId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpID", true));
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(258, 55);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(173, 28);
            this.txtEmpId.TabIndex = 2;
            this.txtEmpId.Text = "0";
            // 
            // txtfName
            // 
            this.txtfName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.txtfName.Location = new System.Drawing.Point(258, 127);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(188, 28);
            this.txtfName.TabIndex = 4;
            // 
            // txtmName
            // 
            this.txtmName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "MiddleName", true));
            this.txtmName.Location = new System.Drawing.Point(604, 127);
            this.txtmName.Name = "txtmName";
            this.txtmName.Size = new System.Drawing.Size(139, 28);
            this.txtmName.TabIndex = 6;
            // 
            // txtlName
            // 
            this.txtlName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.txtlName.Location = new System.Drawing.Point(876, 127);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(190, 28);
            this.txtlName.TabIndex = 8;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Checked = false;
            this.dtpHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "HireDate", true));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(866, 189);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 28);
            this.dtpHireDate.TabIndex = 12;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMainMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(107, 458);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(194, 35);
            this.btnMainMenu.TabIndex = 23;
            this.btnMainMenu.Text = "Mein Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(480, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 35);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewList.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewList.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnViewList.Location = new System.Drawing.Point(687, 458);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(176, 35);
            this.btnViewList.TabIndex = 25;
            this.btnViewList.Text = "View List";
            this.btnViewList.UseVisualStyleBackColor = false;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Teal;
            this.btnOK.Location = new System.Drawing.Point(894, 458);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(176, 35);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAddLine1
            // 
            this.txtAddLine1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "AddressLine01", true));
            this.txtAddLine1.Location = new System.Drawing.Point(258, 253);
            this.txtAddLine1.Name = "txtAddLine1";
            this.txtAddLine1.Size = new System.Drawing.Size(808, 28);
            this.txtAddLine1.TabIndex = 14;
            // 
            // txtAddLine2
            // 
            this.txtAddLine2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "AddressLine02", true));
            this.txtAddLine2.Location = new System.Drawing.Point(258, 313);
            this.txtAddLine2.Name = "txtAddLine2";
            this.txtAddLine2.Size = new System.Drawing.Size(808, 28);
            this.txtAddLine2.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CityName", true));
            this.txtCity.Location = new System.Drawing.Point(258, 376);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 28);
            this.txtCity.TabIndex = 18;
            // 
            // cmbstate
            // 
            this.cmbstate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbstate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeBindingSource, "PostalCode", true));
            this.cmbstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "RegionName", true));
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Location = new System.Drawing.Point(634, 376);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(121, 28);
            this.cmbstate.TabIndex = 20;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PostalCode", true));
            this.txtPostalCode.Location = new System.Drawing.Point(912, 376);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(154, 28);
            this.txtPostalCode.TabIndex = 22;
            // 
            // cmbdept
            // 
            this.cmbdept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbdept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeDepartmentsBindingSource, "DepartmentName", true));
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(258, 183);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(293, 28);
            this.cmbdept.TabIndex = 10;
            // 
            // employeeDepartmentsBindingSource
            // 
            this.employeeDepartmentsBindingSource.DataMember = "Employee_Departments";
            this.employeeDepartmentsBindingSource.DataSource = this.employeeBindingSource;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(687, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(373, 35);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "CLEAR INPUT";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeRecordDataSet;
            // 
            // employeeRecordDataSet
            // 
            this.employeeRecordDataSet.DataSetName = "EmployeeRecordDataSet";
            this.employeeRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeRecordDataSet;
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.employeeRecordDataSet;
            // 
            // regionsBindingSource
            // 
            this.regionsBindingSource.DataMember = "Regions";
            this.regionsBindingSource.DataSource = this.employeeRecordDataSet;
            // 
            // empAddressBindingSource
            // 
            this.empAddressBindingSource.DataMember = "EmpAddress";
            this.empAddressBindingSource.DataSource = this.employeeRecordDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitiesTableAdapter = this.citiesTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.EmpAddressTableAdapter = this.empAddressTableAdapter;
            this.tableAdapterManager.Employee1TableAdapter = null;
            this.tableAdapterManager.RegionsTableAdapter = this.regionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeRecord.EmployeeRecordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // empAddressTableAdapter
            // 
            this.empAddressTableAdapter.ClearBeforeFill = true;
            // 
            // regionsTableAdapter
            // 
            this.regionsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeEmpAddressBindingSource
            // 
            this.employeeEmpAddressBindingSource.DataMember = "Employee_EmpAddress";
            this.employeeEmpAddressBindingSource.DataSource = this.employeeBindingSource;
            // 
            // empAddressCitiesBindingSource
            // 
            this.empAddressCitiesBindingSource.DataMember = "EmpAddress_Cities";
            this.empAddressCitiesBindingSource.DataSource = this.empAddressBindingSource;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1147, 576);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(lblPostalCode);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(regionNameLabel1);
            this.Controls.Add(this.cmbstate);
            this.Controls.Add(lblCityName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(lblAddLine2);
            this.Controls.Add(this.txtAddLine2);
            this.Controls.Add(lblAddLine1);
            this.Controls.Add(this.txtAddLine1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(lblDeptName);
            this.Controls.Add(hireDateLabel);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.txtmName);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(lblempId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information Update Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdate_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEmpAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empAddressCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeRecordDataSet employeeRecordDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeRecordDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private EmployeeRecordDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingNavigator employeeBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private EmployeeRecordDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeRecordDataSetTableAdapters.EmpAddressTableAdapter empAddressTableAdapter;
        private System.Windows.Forms.BindingSource empAddressBindingSource;
        private EmployeeRecordDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private EmployeeRecordDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txtEmpId;
        public System.Windows.Forms.TextBox txtfName;
        public System.Windows.Forms.TextBox txtmName;
        public System.Windows.Forms.TextBox txtlName;
        public System.Windows.Forms.DateTimePicker dtpHireDate;
        public System.Windows.Forms.TextBox txtAddLine1;
        public System.Windows.Forms.TextBox txtAddLine2;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.ComboBox cmbstate;
        public System.Windows.Forms.TextBox txtPostalCode;
        public System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.BindingSource employeeDepartmentsBindingSource;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource employeeEmpAddressBindingSource;
        private System.Windows.Forms.BindingSource empAddressCitiesBindingSource;
    }
}