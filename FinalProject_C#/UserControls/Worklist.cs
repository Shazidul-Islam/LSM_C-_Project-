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
            this.LoadDataTable();
        }
        private void Clear()
        {
            this.btnComplete.Visible = false;
        }

        internal void LoadDataTable()
        {
            var Query = $@"select  B.BookingID,
                            A.AssignedID, 
                            S.Name,
                            SC.SubCategoryName,
                            U.FullName,
                            U.PhoneNo,
                            A.WorkAddress,
                            A.WorkStartTime,
                            A.WorkHours,
                            (S.Price*A.WorkHours) as Cost,
                            BS.StatusName
                    from Service as S,
                            Assigned as A,
                            Users as U ,
                            SubCategory as SC,
                            Booking as B,
                            BookingStatus as BS
                    where S.ServiceID = A.ServiceID and
                            A.ClientID = U.UserID and
                            SC.SubCategoryID = S.SubCategoryID and
                            A.BookingID = B.BookingID and
                            B.StatusID = BS.StatusID and
                            A.EmployeeID ='{MainWindow.loginUser.Rows[0][0]}';";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(Query);
                this.dgvDataTable.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void dgvDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDataTable.CurrentRow.Cells[10].Value.ToString() == "Confirm")
            {
                this.btnComplete.Visible = true;
            }
        }
    }
}
