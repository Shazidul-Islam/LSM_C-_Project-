using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject_C_.UserControls.Cards
{
    public partial class ServiceCard : UserControl
    {
        string ServiceID { get; set; }
        string ServiceName { get; set; }
        string CategoryName { get; set; }
        string SubCategoryName { get; set; }
        string Description { get; set; }
        string Price { get; set; }
        string Image { get; set; }
        public ServiceCard()
        {
            InitializeComponent();
        }

        public ServiceCard(string ServiceID, string Name, string CategoryName, string SubCategoryName, string Description, string Price, string Image) : this ()
        {
            this.ServiceID= ServiceID;
            this.ServiceName= Name;
            this.CategoryName= CategoryName;
            this.SubCategoryName= SubCategoryName;
            this.Description= Description;
            this.Price = Price;
            this.Image = Image;
            this.lblServiceN.Text = Name;
            this.lblCategory.Text += CategoryName;
            this.lblPrice.Text += Price+" Tk";
        }
        private void pnlCard_Click(object sender, EventArgs e)
        {
            ServiceDetails servicedetails = new ServiceDetails(ServiceID, ServiceName, CategoryName, SubCategoryName, Description, Price, Image);
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
