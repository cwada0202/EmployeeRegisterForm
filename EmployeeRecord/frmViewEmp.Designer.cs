using System.Windows.Forms;

namespace EmployeeRecord
{
    partial class frmViewEmp
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
            System.Windows.Forms.Label departmentNameLabel;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label empIDLabel;
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeRecordDataSet = new EmployeeRecord.EmployeeRecordDataSet();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lvEmpList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSerach = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new EmployeeRecord.EmployeeRecordDataSetTableAdapters.DepartmentsTableAdapter();
            departmentNameLabel = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Location = new System.Drawing.Point(793, 67);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new System.Drawing.Size(176, 20);
            departmentNameLabel.TabIndex = 45;
            departmentNameLabel.Text = "Department Name:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new System.Drawing.Point(871, 126);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(98, 20);
            hireDateLabel.TabIndex = 35;
            hireDateLabel.Text = "Hire Date:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(426, 120);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(108, 20);
            lastNameLabel.TabIndex = 33;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(426, 67);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(111, 20);
            firstNameLabel.TabIndex = 29;
            firstNameLabel.Text = "First Name:";
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(87, 67);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(83, 20);
            empIDLabel.TabIndex = 27;
            empIDLabel.Text = "Emp ID:";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMainMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(91, 217);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(194, 35);
            this.btnMainMenu.TabIndex = 49;
            this.btnMainMenu.Text = "Mein Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // cmbdept
            // 
            this.cmbdept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbdept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdept.DataSource = this.departmentsBindingSource;
            this.cmbdept.DisplayMember = "DepartmentName";
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(976, 64);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(202, 28);
            this.cmbdept.TabIndex = 46;
            this.cmbdept.ValueMember = "DepartmentName";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeRecordDataSet;
            // 
            // employeeRecordDataSet
            // 
            this.employeeRecordDataSet.DataSetName = "EmployeeRecordDataSet";
            this.employeeRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(976, 120);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(202, 28);
            this.dtpHireDate.TabIndex = 36;
            this.dtpHireDate.ValueChanged += new System.EventHandler(this.dtpHireDate_ValueChanged);
            this.dtpHireDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpHireDate_KeyDown);
            this.dtpHireDate.ShowCheckBox = true;
            this.dtpHireDate.Checked = false;
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(538, 120);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(164, 28);
            this.txtlName.TabIndex = 34;
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(538, 64);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(164, 28);
            this.txtfName.TabIndex = 30;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(176, 64);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(173, 28);
            this.txtEmpId.TabIndex = 28;
            // 
            // lvEmpList
            // 
            this.lvEmpList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEmpList.FullRowSelect = true;
            this.lvEmpList.GridLines = true;
            this.lvEmpList.HideSelection = false;
            this.lvEmpList.Location = new System.Drawing.Point(91, 279);
            this.lvEmpList.MultiSelect = false;
            this.lvEmpList.Name = "lvEmpList";
            this.lvEmpList.Size = new System.Drawing.Size(1085, 248);
            this.lvEmpList.TabIndex = 53;
            this.lvEmpList.UseCompatibleStateImageBehavior = false;
            this.lvEmpList.View = System.Windows.Forms.View.Details;
            this.lvEmpList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvEmpList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmpId";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FullName";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DepartmnetName";
            this.columnHeader3.Width = 176;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 257;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "City";
            this.columnHeader5.Width = 182;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Region";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "HireDate";
            this.columnHeader7.Width = 100;
            // 
            // btnSerach
            // 
            this.btnSerach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSerach.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSerach.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.ForeColor = System.Drawing.Color.Teal;
            this.btnSerach.Location = new System.Drawing.Point(1000, 217);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(176, 35);
            this.btnSerach.TabIndex = 52;
            this.btnSerach.Text = "SEARCH";
            this.btnSerach.UseVisualStyleBackColor = false;
            this.btnSerach.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnClear.Location = new System.Drawing.Point(776, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 35);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1238, 562);
            this.Controls.Add(this.lvEmpList);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(departmentNameLabel);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(hireDateLabel);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.txtEmpId);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "DepartmentName", true));
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewEmp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewEmp_FormClosing);
            this.Load += new System.EventHandler(this.frmViewEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.ListView lvEmpList;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private EmployeeRecordDataSet employeeRecordDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeRecordDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        public System.Windows.Forms.ComboBox cmbdept;
        public System.Windows.Forms.DateTimePicker dtpHireDate;
    }
}