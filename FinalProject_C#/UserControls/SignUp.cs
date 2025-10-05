using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUpBTOLogin_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(login);
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text==""||this.txtFullName.Text == "" || this.txtEmail.Text == "" || this.txtPhoneNo.Text==""||this.txtPassword.Text==""||this.txtCPassword.Text==""||this.cmbUserType.Text=="")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string Gender = "";
            if (rbMale.Checked)
            {
                Gender="Male";
                
            }
            else if(rbFemale.Checked)
            {
                Gender = "Female";

            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }
            if(this.txtPassword.Text!=this.txtCPassword.Text)
            {
                MessageBox.Show("Password not Matched with Confirm Password");
                return;
            }
            if (this.cmbUserType.Text == "EMPLOYEE" && this.cmbServiceType.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string ServiceType=this.cmbServiceType.Text;
            if (this.cmbUserType.Text=="USER"){ ServiceType = "NORMAL USER"; }


            try
            {
                var query = $@"Insert into Users values ('{this.txtUserID.Text}','{this.txtFullName.Text}','{Gender}','{this.dtpDate.Text}','{this.txtEmail.Text}','{this.txtPhoneNo.Text}','{this.txtPassword.Text}','{this.txtUserDescription.Text}');";
                var query1 = $@"Insert into UserType values ('{this.txtUserID.Text}','{ServiceType}');";
                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                var validate1 = MainWindow.dataAccess.ExecuteDMLQuery(query1);
                if(validate==1&&validate1==1)
                {
                    MessageBox.Show("SignUP Successful");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }

        }
        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbUserType.Text== "EMPLOYEE")
            {
                this.cmbServiceType.Visible =true;
                this.txtUserDescription.Visible =true;
            }
            else { this.cmbServiceType.Visible =false; this.txtUserDescription.Visible =false;}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.ucLogIn = new LogIn();
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(MainWindow.ucLogIn);
            MainWindow.ucLogIn.Show();
        }
    }
}
