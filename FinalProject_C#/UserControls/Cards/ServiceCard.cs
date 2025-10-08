using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls.Cards
{
    public partial class ServiceCard : UserControl
    {
        public ServiceCard()
        {
            InitializeComponent();
        }

        private void pnlCard_Click(object sender, EventArgs e)
        {
            ServiceDetails servicedetails = new ServiceDetails();
            servicedetails.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(servicedetails);
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
