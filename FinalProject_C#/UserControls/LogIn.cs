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
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(signUp);
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(this.txtEmail.Text==""||this.txtPassword.Text=="")
            {
                MessageBox.Show("Fill the email and password first");
                return;
            }
            try
            {
                var query =$@"select * from Users where Email='{this.txtEmail.Text}' and Password='{this.txtPassword.Text}'";
                var DA = MainWindow.dataAccess.ExecuteQueryTable(query);
                if (DA.Rows.Count == 1)
                {
                    MainWindow.SideBar.Visible = true;

                    MainServiceP Home = new MainServiceP();
                    Home.Dock = DockStyle.Fill;
                    MainWindow.MainPanel.Controls.Clear();
                    MainWindow.MainPanel.Controls.Add(Home);
                }
                else { MessageBox.Show("Invalid User"); }
            }
            catch (Exception ex){ MessageBox.Show($"ERROR {ex.Message}"); }
           
        }
    }
}
