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
            for(int i=0; i<=20; i++)
            {
                ServiceCard serviceCard = new ServiceCard();
                this.flpServices.Controls.Add(serviceCard);
            }
        }
    }
}
