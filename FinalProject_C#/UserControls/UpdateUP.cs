using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace FinalProject_C_.UserControls
{
    public partial class UpdateUP : UserControl
    {
        public UpdateUP()
        {
            InitializeComponent();
            this.txtFullName.Text = MainWindow.loginUser.Rows[0][1].ToString();
            this.lblFullName.Text = MainWindow.loginUser.Rows[0][1].ToString();
            this.lblUserType.Text = MainWindow.loginUser.Rows[0][8].ToString();
            this.txtEmail.Text = MainWindow.loginUser.Rows[0][4].ToString();
            this.txtPhoneNo.Text = MainWindow.loginUser.Rows[0][5].ToString();
            this.dtpDate.Text = MainWindow.loginUser.Rows[0][3].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string FullName = txtFullName.Text;
            string Email = txtEmail.Text;
            string PhoneNo = txtPhoneNo.Text;
            string Password = txtPassword.Text;
            string UserID = MainWindow.loginUser.Rows[0][0].ToString();
            
            if (
               string.IsNullOrWhiteSpace(FullName) ||
               string.IsNullOrWhiteSpace(Email) ||
               string.IsNullOrWhiteSpace(PhoneNo) ||
               string.IsNullOrWhiteSpace(Password)
               )

            {
                MessageBox.Show("Fill All the Field First");
                return;
            }

            try
            {
                var UserCheck = MainWindow.dataAccess.ExecuteQueryTable($"select * from Users where Password='{this.txtPassword.Text}'");
                string query = "";
                query = $@"Update Users set FullName = '{this.txtFullName.Text}',Email = '{this.txtEmail.Text}',DOB = '{this.dtpDate.Text}',PhoneNo = '{this.txtPhoneNo.Text}',Password = '{this.txtPassword.Text}' where Password = '{this.txtPassword.Text}' and UserID = '{MainWindow.loginUser.Rows[0][1].ToString()}'";


                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                if (validate == 1)
                {
                    MessageBox.Show("User Information Successfully Updated");
                    this.clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        }
        private void clear()
        {
            this.txtFullName.Clear();
            this.txtPhoneNo.Clear();
            this.txtEmail.Clear();
            this.dtpDate.Value=DateTime.Now;
            this.txtPassword.Clear();
        }
    }
}
