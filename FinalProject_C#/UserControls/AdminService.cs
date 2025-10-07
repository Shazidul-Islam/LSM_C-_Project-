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
    public partial class AdminService : UserControl
    {
        public AdminService()
        {
            InitializeComponent();
            this.load_ServiceTable();
        }
        private void Clear()
        {
            this.gdvServiceTable.ClearSelection();
            this.txtServiceID.Clear();
            this.txtServiceN.Clear();
            this.cmbServiceCN.SelectedItem=null;
            this.cmbServiceSCN.SelectedIndex=-1; 
            this.txtServiceD.Clear();
            this.txtServiceP.Clear();
            this.txtServiceI.Clear();
        }
        private void load_ServiceCategoryCommand()
        {
            var query = "select  * from ServiceCategory";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.cmbServiceCN.DataSource = DT;
                this.cmbServiceCN.DisplayMember = "CategoryName";
                this.cmbServiceCN.ValueMember = "CategoryID";
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }
        private void load_SubCategory(string CategoryID)
        {
            var query = $"select * from SubCategory where CategoryID ='{CategoryID}'";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.cmbServiceSCN.DataSource = DT;
                this.cmbServiceSCN.DisplayMember = "SubCategoryName";
                this.cmbServiceSCN.ValueMember = "SubCategoryID";
                this.cmbServiceSCN.SelectedItem = null;
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        
        }
        private void load_ServiceTable(string query = "select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID")
        {
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.gdvServiceTable.AutoGenerateColumns = false;
                this.gdvServiceTable.DataSource = DT;
            


            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }
        private void UDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void gdvServiceTable_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void cmbSeviceCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbServiceCN.SelectedItem==null) return;
            this.load_SubCategory(this.cmbServiceCN.SelectedValue.ToString());
        }

        private void cmbServiceCN_Click(object sender, EventArgs e)
        {
            this.load_ServiceCategoryCommand();
        }
    }
}
