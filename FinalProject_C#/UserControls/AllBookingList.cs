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
    public partial class AllBookingList : UserControl
    {
        public AllBookingList()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            this.lblAssignedID.Text = string.Empty;
            this.lblServiceID.Text = string.Empty;
            this.lblServiceName.Text = string.Empty;
            this.lblCatagoryName.Text = string.Empty;
            this.lblEmployeePhone.Text = string.Empty;
            this.lblAddress.Text = string.Empty;
            this.lblDT.Text = string.Empty;
            this.lblWorkHour.Text = string.Empty;
            this.lblPaymentStatus.Text = string.Empty;
            this.lblTotalCost.Text = string.Empty;
            this.lblServiceStatus.Text = string.Empty;
            this.lblServiceStatus.Text = string.Empty;
            this.lblRating.Text = string.Empty;
            this.lblUserReview.Text = string.Empty; 
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
