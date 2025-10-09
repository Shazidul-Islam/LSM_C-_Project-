using FinalProject_C_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FinalProject_C_
{
    public partial class MainWindow : Form
    {
        //LogIn User
        internal static DataTable loginUser {  get; set; }

        //Buttons
        internal static Guna2Button ProfileButton {  get; set; }

        //Panels
        internal static Panel MainPanel {  get; set; }
        internal static Panel SideBar {  get; set; }

        //UserControls Pages
        internal static UserControl ucLogIn {  get; set; }
        internal static UserControl ucProfile {  get; set; }
        internal static DataAccess dataAccess { get; set; }
        internal static UserControl ucUserTable { get; set; }
        internal static UserControl ucSevices { get; set; }
        internal static UserControl ucServiceTable { get; set; }
        internal static UserControl ucTransaction { get; set; }
        internal static UserControl ucWorkList { get; set; }
        internal static UserControl ucReview { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            MainPanel = this.pnlMainPanel;
            SideBar = this.pnlSideBar;
            dataAccess = new DataAccess();
            ProfileButton = this.btnProfile;
        }

        private void ChangeWindow(UserControl NextPage)
        {
            NextPage.Dock = DockStyle.Fill;
            this.pnlMainPanel.Controls.Clear();
            this.pnlMainPanel.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ucLogIn = new LogIn();
            this.ChangeWindow(ucLogIn);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MainWindow.SideBar.Visible = false;
            ucLogIn = new LogIn();
            this.ChangeWindow(ucLogIn);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucProfile = new Profile();
            this.ChangeWindow(ucProfile);
        }

        private void btnUserTable_Click(object sender, EventArgs e)
        {
            ucUserTable = new AdminUser();
            this.ChangeWindow(ucUserTable);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ucSevices = new MainServiceP();
            this.ChangeWindow(ucSevices);
        }

        private void btnServiceT_Click(object sender, EventArgs e)
        {
            ucServiceTable = new AdminService();
            this.ChangeWindow(ucServiceTable); 
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ucTransaction= new AdminTransaction();
            this.ChangeWindow(ucTransaction);
        }

        private void btnWorkList_Click(object sender, EventArgs e)
        {
            ucWorkList = new EmployeeAssigned();
            this.ChangeWindow(ucWorkList);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ucReview= new UserReview();
            this.ChangeWindow(ucReview);
        }
    }
}
