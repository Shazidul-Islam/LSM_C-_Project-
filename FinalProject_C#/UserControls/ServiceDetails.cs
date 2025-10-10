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
    public partial class ServiceDetails : UserControl
    {
        internal string ServiceID {  get; set; } 
        public ServiceDetails()
        {
            InitializeComponent();
        }
        public ServiceDetails(string ServiceID, string Name, string CategoryName, string SubCategoryName, string Description, string Price, string Image) : this ()
        {
            this.lblServiceN.Text = Name;
            this.lblCategoryN.Text += CategoryName;
            this.lblSubCategoryN.Text += SubCategoryName;
            this.lblDescription.Text += Description;
            this.lblPrice.Text += Price;
            this.ServiceID = ServiceID;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            BookN book = new BookN(this.ServiceID);
            book.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(book);
        }
    }
}
