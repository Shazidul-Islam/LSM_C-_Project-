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
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        }

        internal void InsertInDataBasePayLater()
        {
            
            try
            {
                var query1 = $@"insert into Booking (BookedAt, StatusID) OUTPUT inserted.BookingID Values (GETDATE(),'1');";
                var InsertBooking = MainWindow.dataAccess.ExecuteQueryTable(query1);

                var query2 = $@"INSERT INTO Assigned (
                                WorkHours,
                                WorkStartTime,
                                WorkAddress,
                                PhoneNo,
                                BookingID,
                                ClientID,
                                EmployeeID,
                                ServiceID
                            )
                            VALUES (
                                {BookN.Hours},
                                '{BookN.DateTime}',
                                '{BookN.Address}',
                                '{BookN.PhoneNo}',
                                {InsertBooking.Rows[0][0].ToString()},
                                '{MainWindow.loginUser.Rows[0][0].ToString()}',
                                '{BookN.EmployeeID}',
                                '{BookN.ServiceID}'
                            );";
                var InsertAssigned = MainWindow.dataAccess.ExecuteDMLQuery(query2);

                MessageBox.Show("Successfull");
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }

        }

        private void btnPayLater_Click(object sender, EventArgs e)
        {
            InsertInDataBasePayLater();
        }
    }
}
