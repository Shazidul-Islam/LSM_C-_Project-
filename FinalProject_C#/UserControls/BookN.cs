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
    public partial class BookN : UserControl
    {
        public BookN()
        {
            InitializeComponent();
        }
        public BookN(string ServiceID, string Name, string CategoryName, string SubCategoryName, string Description, string Price, string Image) : this()
        {

        }
        private void btnBooking_Click(object sender, EventArgs e)
        {

        }

        private void TotalCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
