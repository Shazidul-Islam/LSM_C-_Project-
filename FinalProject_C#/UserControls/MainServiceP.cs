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
    public partial class MainServiceP : UserControl
    {
        internal static Panel ServicesPanel {  get; set; }

        public MainServiceP()
        {
            InitializeComponent();
            ServicesPanel = this.pnlServicesP;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchService_Click(object sender, EventArgs e)
        {
            Sevices services = new Sevices();
            services.Dock = DockStyle.Fill;
            ServicesPanel.Controls.Clear();
            ServicesPanel.Controls.Add(services);
        }
    }
}
