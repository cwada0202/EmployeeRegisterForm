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
    public partial class frmMainMenu : Form
    {
        public static class Constants
        {
            //Change Data Source to Yours HERE!
            public const string  conString = "Data Source=DESKTOP-TF565U4;Initial Catalog=EmployeeRecord;Integrated Security=True";
        }
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnEnter1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // creating new window
            frmUpdate frm2= new frmUpdate();
            // set databinding
            frm2.SetDataAutoFill();
            // get new page for new record
            frm2.employeeBindingNavigator.BindingSource.AddNew();
            frm2.employeeBindingNavigator.Visible = false;

            // set data into comboboxes
            string cn = "DepartmentName";
            string qDept = "SELECT (DepartmentName) FROM Departments";
            QueryExecution(frm2.cmbdept, qDept, cn);
            string cn1 = "RegionName";
            string qRegion = "SELECT (RegionName) FROM Regions";
            QueryExecution(frm2.cmbstate, qRegion, cn1);
            // end of comboboxes setting

            // display window
            frm2.Show();
            // set combobox data empty
            frm2.cmbdept.Text = "";
            frm2.cmbstate.Text = "";
            frm2.txtEmpId.Text = "0";
        }
        private void QueryExecution(ComboBox cmb, string q, string cn)
        {
            var conString = Constants.conString;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            // execute command
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add(cn, typeof(string));
            dt.Load(reader);
            cmb.ValueMember = cn;
            cmb.DataSource = dt;
            con.Close();
        }

        private void btnEnter2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewEmp frm2 = new frmViewEmp();
            frm2.Show();
            // set combobox data empty
            frm2.cmbdept.Text = "";
            
        }

        private void btnEnter3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdate frm2 = new frmUpdate();
            frm2.btnClear.Visible = false;

            // set data into comboboxes
            string cn = "DepartmentName";
            string qDept = "SELECT (DepartmentName) FROM Departments";
            QueryExecution(frm2.cmbdept, qDept, cn);
            string cn1 = "RegionName";
            string qRegion = "SELECT (RegionName) FROM Regions";
            QueryExecution(frm2.cmbstate, qRegion, cn1);
            // end of comboboxes setting
            //set oldest employee id 
            frm2.employeeBindingNavigator.BindingSource.MoveFirst();
            frm2.Show();
        }
        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                Application.ExitThread();
                // Call method to save file...
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

