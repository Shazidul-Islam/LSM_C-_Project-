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
        internal static UserControl ucLogIn {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainPanel = this.pnlMainPanel;
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
    }
}
