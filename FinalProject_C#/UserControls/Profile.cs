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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            string FullName = "Hamidur";
            string UserType = "User";
            string UserID = "00-11";
            string PhoneNo = "0195368238";
            string Email = "hamidur@gmailc.com";
            string DOB = "2002-01-02";
            string Gender = "Male";
            string Description = "I am Hamidur";

           

            this.lblFullName.Text = FullName;
            this.lblUserType.Text = UserType;
            this.lblUserID.Text = UserID;
            this.lblPhoneNo.Text = PhoneNo;
            this.lblEmail.Text = Email;
            this.lblDOB.Text = DOB;
            this.lblGender.Text = Gender;
            this.lblDescription.Text = Description;
        }

    }
}
