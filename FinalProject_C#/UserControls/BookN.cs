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
        internal static string DateTime {  get; set; }
        internal static string Hours { get; set; }
        internal static string EmployeeID { get; set; }
        internal static string Address { get; set; }
        internal static string PhoneNo { get; set; }
        internal static string ServiceID { get; set; }
        internal static string TotalCost { get; set; }
        public BookN()
        {
            InitializeComponent();
            loadEmployee();
        }

        public BookN(string serviceID) : this()
        {
            this.lblServiceID.Text += serviceID;
            ServiceID = serviceID;
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if(this.txtHours.Text == "" || 
                this.cmbEmployee.Text == ""||
                this.txtAddress.Text == ""||
                this.txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            DateTime = this.dtpDateTime.Text;
            Hours = this.txtHours.Text;
            EmployeeID = this.cmbEmployee.SelectedValue.ToString();
            Address = this.txtAddress.Text;
            PhoneNo = this.txtPhoneNo.Text;


            Payment payment = new Payment();
            payment.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(payment);
        }

        internal void loadEmployee()
        {
            try
            {
                var query = $"select U.UserID, U.FullName, U.UserTypeID ,UT.TypeName from Users as U , UserType as UT where U.UserTypeID > 2 and u.UserTypeID = ut.UserTypeID";
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);

                this.cmbEmployee.DataSource = DT;
                this.cmbEmployee.DisplayMember = "FullName";
                this.cmbEmployee.ValueMember = "UserID";
            }
            catch(Exception e) { MessageBox.Show("Error : " + e.Message); }
        }
    }
}
