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
using System.Runtime.CompilerServices;

namespace EmployeeRecord
{
    public partial class frmViewEmp : Form
    {
        public string conString = frmMainMenu.Constants.conString;

        public frmViewEmp()
        {
            InitializeComponent();
            //query for sql
            string q = "SELECT * FROM uf_ListOfEmp() ORDER BY EmpId";
            LoadDateFromSQL(q);
        }
        //DateTimePicker formatting
        private void dtpHireDate_ValueChanged(object sender, EventArgs e)
        {
            dtpHireDate.CustomFormat = "MM/dd/yyyy";
        }
        private void dtpHireDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpHireDate.CustomFormat = " ";
            }
        }// End of DateTimePicker Formatting
        private void LoadDateFromSQL(string q)
        {
            //Clear data
            lvEmpList.Items.Clear();
            // need SQL LIST adapter for list data into list view
            SqlDataAdapter sqlListAdapter = new SqlDataAdapter(q, conString);
            //create table
            DataTable empTable = new DataTable();
            // get data into table
            sqlListAdapter.Fill(empTable);

            for (int i = 0; i < empTable.Rows.Count; i++)
            {
                DataRow rows = empTable.Rows[i];
                //create ListView
                ListViewItem itm = new ListViewItem(rows["EmpId"].ToString());
                itm.SubItems.Add(rows["FullName"].ToString());
                itm.SubItems.Add(rows["DepartmentName"].ToString());
                itm.SubItems.Add(rows["Address"].ToString());
                itm.SubItems.Add(rows["CityName"].ToString());
                itm.SubItems.Add(rows["RegionName"].ToString());
                itm.SubItems.Add(DateTime.Parse(rows["HireDate"].ToString()).ToString("MM-dd-yyyy"));
                lvEmpList.Items.Add(itm);
            }
        }
        private string Queries()
        {
            string q = "";
            if (txtEmpId.Text.Length > 0)
            {
                q = "EXECUTE usp_SerchById @EmpId ='" + txtEmpId.Text.ToString() + "'";
            }
            else if (txtfName.Text.Length > 0 || txtlName.Text.Length > 0)
            {
                q = "EXECUTE usp_SerchByName @FirstName='" + txtfName.Text.ToString() + "'," +
                    " @LastName='" + txtlName.Text.ToString() + "'";
            }
            else if (cmbdept.Text.Length > 0)
            {
                q = "EXECUTE usp_SerchByDeptName @DeptName = '" + cmbdept.Text.ToString() + "'";
            }
            else if (dtpHireDate.Checked == true)
            {
                q = "EXECUTE usp_SerchByHireDate @HireDate ='" + dtpHireDate.Value.ToString("MM-dd-yyyy") + "'";
            }
            else if (txtEmpId.Text.Length == 0 && txtfName.Text.Length == 0 || txtlName.Text.Length == 0
                && cmbdept.Text.Length == 0 && dtpHireDate.Checked == false)
            {
                q = "SELECT * FROM uf_ListOfEmp() ORDER BY EmpId";
            }
            return q;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //query for sql
            string q = Queries();
            LoadDateFromSQL(q);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = String.Empty;
                }
            }
            cmbdept.Text = "";
            dtpHireDate.Text = "";

        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frm1 = new frmMainMenu();
            frm1.Show();
        }
        //When user click item on ListView
        private void lvEmpList_MouseClick(object sender, MouseEventArgs e)
        {
            //hide this window
            this.Hide();
            //create new window
            frmUpdate f4 = new frmUpdate();

            // set data into comboboxes
            string cn = "DepartmentName";
            string qDept = "SELECT (DepartmentName) FROM Departments";
            QueryExecution(f4.cmbdept, qDept, cn);
            string cn1 = "RegionName";
            string qRegion = "SELECT (RegionName) FROM Regions";
            QueryExecution(f4.cmbstate, qRegion, cn1);
            // end of comboboxes setting

            //set employeebindingnaviator.visible to false since Update form code will be depending on this visibility
            f4.employeeBindingNavigator.Visible = false;
            //get and set f4.form empId from selected item
            f4.txtEmpId.Text = lvEmpList.SelectedItems[0].SubItems[0].Text;
            // new connection to sql
            SqlConnection con = new SqlConnection(conString);
            // open Sql
            con.Open();
            // query
            string q = "EXECUTE usp_GetEmpInfo @EmpId ='" + f4.txtEmpId.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            // execute command
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                f4.txtfName.Text = reader.GetValue(1).ToString();
                f4.txtmName.Text = reader.GetValue(2).ToString();
                f4.txtlName.Text = reader.GetValue(3).ToString();
                f4.cmbdept.Text = reader.GetValue(4).ToString();
                f4.txtAddLine1.Text = reader.GetValue(5).ToString();
                f4.txtAddLine2.Text = reader.GetValue(6).ToString();
                f4.txtCity.Text = reader.GetValue(7).ToString();
                f4.cmbstate.Text = reader.GetValue(8).ToString();
                f4.txtPostalCode.Text = reader.GetValue(9).ToString();
                f4.dtpHireDate.Value = reader.GetDateTime(10);
            }
            con.Close();
            f4.Show();

        }
        private void QueryExecution(ComboBox cmb, string q, string cn)
        {
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

        private void frmViewEmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm1 = new frmMainMenu();
            frm1.Show();
        }

        private void frmViewEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeRecordDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeRecordDataSet.Departments);

        }

    }
}
