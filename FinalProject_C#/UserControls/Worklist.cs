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
    public partial class Worklist : UserControl
    {
        public Worklist()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            this.lblAssignedID.Text = string.Empty;
            this.lblClientName.Text = string.Empty;
            this.lblClientPhone.Text = string.Empty;
            this.lblAdd.Text = string.Empty;    
            this.lblDT.Text = string.Empty;
            this.lblWorkHour.Text = string.Empty;
            this.lblEarnings.Text = string.Empty;
            this.lblServiceStatus.Text = string.Empty;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
