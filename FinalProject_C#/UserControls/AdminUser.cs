using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls
{
    public partial class AdminUser : UserControl
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            this.txtUserID.Clear();
            this.txtFullName.Clear();
            this.rbFemale.Checked = false;
            this.rbMale.Checked = false;
            this.txtEmail.Clear();
            this.txtPhoneNo.Clear();
            this.txtPassword.Clear();
            this.cmbUserType.SelectedIndex=-1;
            this.cmbServiceType.SelectedIndex = -1;
            this.txtPassword.Clear();
        }
        private void load_UserTable()
        {
            try
            {
                var query = $@"select U.UserID,U.FullName,U.Gender,U.DOB,U.Email,U.PhoneNo,U.Password,UT.TypeName from Users as U,UserType as UT where U.UserID=UT.UserID";
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.dgvUserTable.AutoGenerateColumns = false;
                this.dgvUserTable.DataSource = DT;
                this.dgvUserTable.EnableHeadersVisualStyles = false;
                this.dgvUserTable.RowHeadersVisible = false;
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }
        private void AdminUser_Load(object sender, EventArgs e)
        {
            this.load_UserTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text == "" || this.txtFullName.Text == "" || this.txtEmail.Text == "" || this.txtPhoneNo.Text == "" || this.txtPassword.Text == "" || this.cmbUserType.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string Gender = "";
            if (rbMale.Checked)
            {
                Gender = "Male";

            }
            else if (rbFemale.Checked)
            {
                Gender = "Female";

            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }
            if (this.cmbUserType.Text == "EMPLOYEE" && this.cmbServiceType.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string ServiceType = this.cmbServiceType.Text;
            if (this.cmbUserType.Text == "USER") { ServiceType = "NORMAL USER"; }


            try
            {
                var query = $@"Insert into Users values ('{this.txtUserID.Text}','{this.txtFullName.Text}','{Gender}','{this.dtpDate.Text}','{this.txtEmail.Text}','{this.txtPhoneNo.Text}','{this.txtPassword.Text}','{this.txtUserDescription.Text}');";
                var query1 = $@"Insert into UserType values ('{this.txtUserID.Text}','{ServiceType}');";
                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                var validate1 = MainWindow.dataAccess.ExecuteDMLQuery(query1);
                if (validate == 1 && validate1 == 1)
                {
                    MessageBox.Show("User Add Successful");
                    this.load_UserTable();
                    this.clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }

        }
        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbUserType.Text == "EMPLOYEE")
            {
                this.cmbServiceType.Visible = true;
                this.txtUserDescription.Visible = true;
            }
            else { this.cmbServiceType.Visible = false; this.txtUserDescription.Visible = false; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (this.txtUserID.Text == "" || this.txtFullName.Text == "" || this.txtEmail.Text == "" || this.txtPhoneNo.Text == "" || this.txtPassword.Text == "" || this.cmbUserType.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string Gender = "";
            if (rbMale.Checked)
            {
                Gender = "Male";

            }
            else if (rbFemale.Checked)
            {
                Gender = "Female";

            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }
            if (this.cmbUserType.Text == "EMPLOYEE" && this.cmbServiceType.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string ServiceType = this.cmbServiceType.Text;
            if (this.cmbUserType.Text == "USER") { ServiceType = "NORMAL USER"; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void dgvUserTable_DoubleClick(object sender, EventArgs e)
        {
            this.txtFullName.Text = this.dgvUserTable.CurrentRow.Cells["FullName"].Value.ToString();
        }
    }
}
