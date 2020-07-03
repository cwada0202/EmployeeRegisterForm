using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeRecord
{
    public partial class frmUpdate : Form
    {
        public string conString = frmMainMenu.Constants.conString;

        public frmUpdate()
        {
            InitializeComponent();
        }

        public void frmUpdate_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtEmpId.Text);
            //when "-1" is new employee
            if (x == -1)
            {
                return;
            }
            else if (employeeBindingNavigator.Visible == false)
            {
                return;
            }
            else
                SetDataAutoFill();
        }
        public void SetDataAutoFill()
        {
            // TODO: This line of code loads data into the 'employeeRecordDataSet.Regions' table. You can move, or remove it, as needed.
            this.regionsTableAdapter.Fill(this.employeeRecordDataSet.Regions);
            // TODO: This line of code loads data into the 'employeeRecordDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.employeeRecordDataSet.Cities);
            // TODO: This line of code loads data into the 'employeeRecordDataSet.EmpAddress' table. You can move, or remove it, as needed.
            this.empAddressTableAdapter.Fill(this.employeeRecordDataSet.EmpAddress);
            // TODO: This line of code loads data into the 'employeeRecordDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeRecordDataSet.Departments);
            // TODO: This line of code loads data into the 'employeeRecordDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeRecordDataSet.Employee);

        }
     
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frm2 = new frmMainMenu();
            frm2.Show();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewEmp frm2 = new frmViewEmp();
            frm2.Show();
            frm2.cmbdept.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Process for Update
            int x = Convert.ToInt32(txtEmpId.Text);
            if (x > 0 )
            {
                var conString = frmMainMenu.Constants.conString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                //Query for Update
                string q = "EXECUTE usp_UpdateEmpInfo @EmpId ='" + txtEmpId.Text.ToString() + "', " +
                    "@FirstName ='" + txtfName.Text.ToString() + "', @MiddleName ='" + txtmName.Text.ToString() + "', " +
                    "@LastName ='" + txtlName.Text.ToString() + "', @DeptName = '" + cmbdept.Text.ToString() + "', " +
                    "@AddL1 = '" + txtAddLine1.Text.ToString() + "', @AddL2 = '" + txtAddLine2.Text.ToString() + "', " +
                    "@City = '" + txtCity.Text.ToString() + "', @RegionName = '" + cmbstate.Text.ToString() + "', " +
                    "@PostalCode = '" + txtPostalCode.Text.ToString() + "', @HireDate = '" + dtpHireDate.Value.ToString("MM-dd-yyyy") + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                // execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee ID: " + txtEmpId.Text.ToString() + " has been updated.",
                            "EMPLOYEE UPDATE INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Activate();
            }
            if (x==0)
            {
                RegisterIntoSQL();
            }

        }
        private void RegisterIntoSQL()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            //Check the duplication of input data
            if (ChkDuplicationOfData(txtfName, txtmName, txtlName) == true)
            {
                MessageBox.Show("Same information has found in the database." + "\n"
                                + "Make sure the information is correct.", "Form Registering",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Activate();

            }
            else
            {
                var result = MessageBox.Show("This information will be stored in the database." + "\n"
                    + "Make sure the information is correct" + "\n" + "Are you sure to submit?", "Form Registering",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        //Insert into table in SQL database
                        string q = "EXECUTE usp_RegisterEmp @FirstName = '" + txtfName.Text.ToString() + "', @MiddleName = '" + txtmName.Text.ToString() + "', @LastName = '" + txtlName.Text.ToString() + "'," +
                            " @DeptName = '" + cmbdept.Text.ToString() + "', @Address1 = '" + txtAddLine1.Text.ToString() + "', @Address2 = '" + txtAddLine2.Text.ToString() + "'," +
                            " @City = '" + txtCity.Text.ToString() + "', @Region = '" + cmbstate.Text.ToString() + "', @PostalCode = '" + txtPostalCode.Text.ToString() + "', @HireDate = '" + dtpHireDate.Value.ToString("MM-dd-yyyy") + "'";
                        SqlCommand cmd = new SqlCommand(q, con);
                        // execute command
                        cmd.ExecuteNonQuery();
                        con.Close();
                        // after data stored, clear record in form
                        ClearTxtBox();
                        break;
                    case DialogResult.No:
                        this.Activate();
                        break;
                }
            }
            con.Close();
        }
        private bool ChkDuplicationOfData(TextBox FName, TextBox MName, TextBox LName)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            // query
            string chkDub = "SELECT EmpId FROM Employee" +
                            " WHERE FirstName = '" + FName.Text.ToString() + "' AND MiddleName " +
                            "= '" + MName.Text.ToString() + "' AND LastName = '" + LName.Text.ToString() + "'";
            // create new command line
            SqlCommand chkCmd = new SqlCommand(chkDub, con);
            // execute query and read result
            SqlDataReader reader = chkCmd.ExecuteReader();
            // if there is same name record, return true, else false
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            reader.Close();
        }

            private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtEmpId.Text);
            if (x > 0)
            {
                var result = MessageBox.Show("Are you sure to delete?", "DELETE EMPLOYEE INFORMATION",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        //Query for Delete data
                        string q = "EXECUTE usp_DeleteEmpInfo @EmpId ='" + txtEmpId.Text.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(q, con);
                        // execute command
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Employee ID: " + txtEmpId.Text.ToString() + "has been removed from database.",
                            "DELETE EMPLOYEE INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmViewEmp frm2 = new frmViewEmp();
                        frm2.Show();
                        frm2.cmbdept.Text = "";
                        break;
                    case DialogResult.No:
                        this.Activate();
                        break;
                }
            }
            else
            {
                MessageBox.Show("The transaction is invalid.", "VALIDATION ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearTxtBox()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = String.Empty;
                }
            }
            cmbdept.Text = "";
            cmbstate.Text = "";
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveNext();
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Form Closing",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
            else
            {
                this.Hide();
                frmMainMenu frm1 = new frmMainMenu();
                frm1.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTxtBox();
        }
    }
    
}
