using FinalProject_C_.UserControls.Cards;
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
    public partial class Sevices : UserControl
    {
        public Sevices()
        {
            InitializeComponent();
        }

        private void Sevices_Load(object sender, EventArgs e)
        {
            string ServiceID, Name, CategoryName, SubCategoryName, Description, Price, Image;
            var query ="select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID";

            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    ServiceID = DT.Rows[i][0].ToString();
                    Name = DT.Rows[i][1].ToString();
                    CategoryName = DT.Rows[i][2].ToString();
                    SubCategoryName = DT.Rows[i][3].ToString();
                    Description = DT.Rows[i][4].ToString();
                    Price = DT.Rows[i][5].ToString();
                    Image = DT.Rows[i][6].ToString();
                    ServiceCard serviceCard = new ServiceCard(ServiceID, Name, CategoryName, SubCategoryName, Description, Price, Image);
                    this.flpServices.Controls.Add(serviceCard);
                }
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.ucMainServiceP = new MainServiceP();
            MainWindow.ucMainServiceP.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(MainWindow.ucMainServiceP);
        }
    }
}
