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

namespace FinalProject_C_
{
    public partial class MainWindow : Form
    {
        internal static Panel MainPanel {  get; set; }
        internal static Panel SideBar {  get; set; }
        internal static UserControl ucLogIn {  get; set; }
        internal static UserControl ucProfile {  get; set; }
        internal static DataAccess dataAccess { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainPanel = this.pnlMainPanel;
            SideBar = this.pnlSideBar;
            dataAccess = new DataAccess();
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
    }
}
