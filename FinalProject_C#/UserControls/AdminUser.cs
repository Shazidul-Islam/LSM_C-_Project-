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
            this.load_UserTable();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            this.dgvUserTable.ClearSelection();
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
                var query = $@"select U.UserID,U.FullName,U.Gender,U.DOB,U.Email,U.PhoneNo,U.Password,U.UserDescription,UT.TypeName from Users as U,UserType as UT where U.UserID=UT.UserID";
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.dgvUserTable.AutoGenerateColumns = false;
                this.dgvUserTable.DataSource = DT;
                
                
                
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
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
            this.clear();
            this.txtUserID.Text = this.dgvUserTable.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtFullName.Text = this.dgvUserTable.CurrentRow.Cells["FullName"].Value.ToString();
            string gender = this.dgvUserTable.CurrentRow.Cells["Gender"].Value.ToString();
            if (gender == "Male")
            {
                this.rbMale.Checked = true;
                this.rbFemale.Checked = false;
            }
            else if (gender == "Female")
            {
                this.rbFemale.Checked = true;
                this.rbMale.Checked = false;
            }
            string UserType = this.dgvUserTable.CurrentRow.Cells["UserType"].Value.ToString();
            if(UserType=="NORMAL USER")
            {
                
                this.cmbUserType.Text = "USER";
            }
            else { this.cmbUserType.Text = "EMPLOYEE";
                this.cmbServiceType.Visible = true;
                this.txtUserDescription.Visible = true;
            }
                this.txtEmail.Text = this.dgvUserTable.CurrentRow.Cells["Email"].Value.ToString();
            this.dtpDate.Text = this.dgvUserTable.CurrentRow.Cells["DOB"].Value.ToString();
            this.txtPhoneNo.Text = this.dgvUserTable.CurrentRow.Cells["PhoneNo"].Value.ToString();
            this.txtPassword.Text = this.dgvUserTable.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbServiceType.Text = this.dgvUserTable.CurrentRow.Cells["UserType"].Value.ToString();
            this.txtUserDescription.Text = this.dgvUserTable.CurrentRow.Cells["UserDescription"].Value.ToString();
        }

        private void ButRemove_Click(object sender, EventArgs e)
        {
            if(this.dgvUserTable.SelectedRows.Count<1)
            {
                MessageBox.Show("Please Select A Row First To Delete");
                return;
            }
            DialogResult sure=MessageBox.Show("Are you sure to remove this person?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sure == DialogResult.No)
            {
                this.clear();
                return;
            }

            var UserID = this.dgvUserTable.CurrentRow.Cells["UserID"].Value.ToString();
            try
            {
                var query = $@"Delete from Users Where UserID='{UserID}'";
                var query2 = $@"Delete from UserType Where UserID='{UserID}'";
                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                var validate1 = MainWindow.dataAccess.ExecuteDMLQuery(query2);
                if (validate == 1 && validate1 == 1)
                {
                    MessageBox.Show("User Delete Successful");
                    this.load_UserTable();
                    this.clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        
        }
    }
}
