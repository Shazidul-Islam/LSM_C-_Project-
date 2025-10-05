namespace FinalProject_C_.UserControls
{
    partial class SignUp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pnlMainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlSUBPN = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCD = new System.Windows.Forms.Label();
            this.lblLGS = new System.Windows.Forms.Label();
            this.gpbPIC = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlFM = new Guna.UI2.WinForms.Guna2Panel();
            this.gcbUT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gdtpDT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.gbSU = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbPL = new System.Windows.Forms.CheckBox();
            this.cbCL = new System.Windows.Forms.CheckBox();
            this.lblST = new System.Windows.Forms.Label();
            this.pnlGENDER = new System.Windows.Forms.Panel();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.lblG = new System.Windows.Forms.Label();
            this.gtbUD = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbCP = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbP = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbE = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbUN = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtbFN = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMainPanel.SuspendLayout();
            this.pnlSUBPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpbPIC)).BeginInit();
            this.pnlFM.SuspendLayout();
            this.pnlGENDER.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.pnlSUBPN);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pnlMainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pnlMainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(1100, 713);
            this.pnlMainPanel.TabIndex = 4;
            // 
            // pnlSUBPN
            // 
            this.pnlSUBPN.Controls.Add(this.lblCD);
            this.pnlSUBPN.Controls.Add(this.lblLGS);
            this.pnlSUBPN.Controls.Add(this.gpbPIC);
            this.pnlSUBPN.Controls.Add(this.pnlFM);
            this.pnlSUBPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.pnlSUBPN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.pnlSUBPN.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlSUBPN.Location = new System.Drawing.Point(50, 66);
            this.pnlSUBPN.Name = "pnlSUBPN";
            this.pnlSUBPN.Size = new System.Drawing.Size(1000, 600);
            this.pnlSUBPN.TabIndex = 0;
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCD.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCD.Location = new System.Drawing.Point(85, 80);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(429, 23);
            this.lblCD.TabIndex = 12;
            this.lblCD.Text = "Complete the sign up to create your dashboard.";
            // 
            // lblLGS
            // 
            this.lblLGS.AutoSize = true;
            this.lblLGS.BackColor = System.Drawing.Color.Transparent;
            this.lblLGS.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLGS.Location = new System.Drawing.Point(82, 37);
            this.lblLGS.Name = "lblLGS";
            this.lblLGS.Size = new System.Drawing.Size(295, 41);
            this.lblLGS.TabIndex = 11;
            this.lblLGS.Text = "Let\'s Get Started";
            this.lblLGS.Click += new System.EventHandler(this.label3_Click);
            // 
            // gpbPIC
            // 
            this.gpbPIC.BackColor = System.Drawing.Color.Transparent;
            this.gpbPIC.Image = ((System.Drawing.Image)(resources.GetObject("gpbPIC.Image")));
            this.gpbPIC.ImageRotate = 0F;
            this.gpbPIC.Location = new System.Drawing.Point(65, 123);
            this.gpbPIC.Name = "gpbPIC";
            this.gpbPIC.Size = new System.Drawing.Size(449, 420);
            this.gpbPIC.TabIndex = 10;
            this.gpbPIC.TabStop = false;
            // 
            // pnlFM
            // 
            this.pnlFM.BackColor = System.Drawing.Color.Transparent;
            this.pnlFM.Controls.Add(this.gcbUT);
            this.pnlFM.Controls.Add(this.gdtpDT);
            this.pnlFM.Controls.Add(this.checkBox4);
            this.pnlFM.Controls.Add(this.checkBox3);
            this.pnlFM.Controls.Add(this.gbSU);
            this.pnlFM.Controls.Add(this.cbPL);
            this.pnlFM.Controls.Add(this.cbCL);
            this.pnlFM.Controls.Add(this.lblST);
            this.pnlFM.Controls.Add(this.pnlGENDER);
            this.pnlFM.Controls.Add(this.lblG);
            this.pnlFM.Controls.Add(this.gtbUD);
            this.pnlFM.Controls.Add(this.gtbCP);
            this.pnlFM.Controls.Add(this.gtbP);
            this.pnlFM.Controls.Add(this.gtbPN);
            this.pnlFM.Controls.Add(this.gtbE);
            this.pnlFM.Controls.Add(this.gtbUN);
            this.pnlFM.Controls.Add(this.gtbFN);
            this.pnlFM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.pnlFM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFM.Location = new System.Drawing.Point(560, 23);
            this.pnlFM.Name = "pnlFM";
            this.pnlFM.Size = new System.Drawing.Size(414, 562);
            this.pnlFM.TabIndex = 9;
            // 
            // gcbUT
            // 
            this.gcbUT.BackColor = System.Drawing.Color.Transparent;
            this.gcbUT.BorderRadius = 5;
            this.gcbUT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbUT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbUT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbUT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbUT.ItemHeight = 30;
            this.gcbUT.Items.AddRange(new object[] {
            "USER",
            "EMPLOYEE"});
            this.gcbUT.Location = new System.Drawing.Point(19, 315);
            this.gcbUT.Name = "gcbUT";
            this.gcbUT.Size = new System.Drawing.Size(380, 36);
            this.gcbUT.TabIndex = 23;
            // 
            // gdtpDT
            // 
            this.gdtpDT.BorderRadius = 5;
            this.gdtpDT.BorderThickness = 1;
            this.gdtpDT.Checked = true;
            this.gdtpDT.FillColor = System.Drawing.Color.White;
            this.gdtpDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gdtpDT.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gdtpDT.Location = new System.Drawing.Point(19, 143);
            this.gdtpDT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtpDT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtpDT.Name = "gdtpDT";
            this.gdtpDT.Size = new System.Drawing.Size(380, 36);
            this.gdtpDT.TabIndex = 22;
            this.gdtpDT.Value = new System.DateTime(2025, 10, 3, 2, 41, 25, 580);
            // 
            // checkBox4
            // 
            this.checkBox4.AccessibleDescription = "cbEL";
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox4.Location = new System.Drawing.Point(266, 429);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 20);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Electrician";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AccessibleDescription = "cbGD";
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox3.Location = new System.Drawing.Point(154, 429);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 20);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Gardening";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // gbSU
            // 
            this.gbSU.BorderRadius = 8;
            this.gbSU.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbSU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbSU.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbSU.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.gbSU.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.gbSU.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gbSU.ForeColor = System.Drawing.Color.White;
            this.gbSU.Location = new System.Drawing.Point(154, 507);
            this.gbSU.Name = "gbSU";
            this.gbSU.Size = new System.Drawing.Size(135, 36);
            this.gbSU.TabIndex = 8;
            this.gbSU.Text = "Sign Up";
            // 
            // cbPL
            // 
            this.cbPL.AutoSize = true;
            this.cbPL.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbPL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbPL.Location = new System.Drawing.Point(266, 403);
            this.cbPL.Name = "cbPL";
            this.cbPL.Size = new System.Drawing.Size(91, 20);
            this.cbPL.TabIndex = 19;
            this.cbPL.Text = "Plumbing";
            this.cbPL.UseVisualStyleBackColor = true;
            // 
            // cbCL
            // 
            this.cbCL.AutoSize = true;
            this.cbCL.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbCL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbCL.Location = new System.Drawing.Point(154, 403);
            this.cbCL.Name = "cbCL";
            this.cbCL.Size = new System.Drawing.Size(88, 20);
            this.cbCL.TabIndex = 18;
            this.cbCL.Text = "Cleaning";
            this.cbCL.UseVisualStyleBackColor = true;
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblST.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblST.Location = new System.Drawing.Point(15, 399);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(132, 21);
            this.lblST.TabIndex = 17;
            this.lblST.Text = "Service Type:";
            // 
            // pnlGENDER
            // 
            this.pnlGENDER.Controls.Add(this.rbF);
            this.pnlGENDER.Controls.Add(this.rbM);
            this.pnlGENDER.Location = new System.Drawing.Point(103, 363);
            this.pnlGENDER.Name = "pnlGENDER";
            this.pnlGENDER.Size = new System.Drawing.Size(296, 33);
            this.pnlGENDER.TabIndex = 16;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rbF.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbF.Location = new System.Drawing.Point(174, 5);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(77, 22);
            this.rbF.TabIndex = 1;
            this.rbF.TabStop = true;
            this.rbF.Text = "Female";
            this.rbF.UseVisualStyleBackColor = true;
            this.rbF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rbM.ForeColor = System.Drawing.Color.White;
            this.rbM.Location = new System.Drawing.Point(32, 5);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(60, 22);
            this.rbM.TabIndex = 0;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.Color.White;
            this.lblG.Location = new System.Drawing.Point(15, 368);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(87, 24);
            this.lblG.TabIndex = 15;
            this.lblG.Text = "Gender:";
            // 
            // gtbUD
            // 
            this.gtbUD.BorderRadius = 5;
            this.gtbUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbUD.DefaultText = "";
            this.gtbUD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbUD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbUD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbUD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbUD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbUD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbUD.ForeColor = System.Drawing.Color.Black;
            this.gtbUD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbUD.Location = new System.Drawing.Point(19, 465);
            this.gtbUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbUD.Name = "gtbUD";
            this.gtbUD.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbUD.PlaceholderText = "User Description";
            this.gtbUD.SelectedText = "";
            this.gtbUD.Size = new System.Drawing.Size(380, 35);
            this.gtbUD.TabIndex = 14;
            this.gtbUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gtbCP
            // 
            this.gtbCP.BorderRadius = 5;
            this.gtbCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbCP.DefaultText = "";
            this.gtbCP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbCP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbCP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbCP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbCP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbCP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbCP.ForeColor = System.Drawing.Color.Black;
            this.gtbCP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbCP.Location = new System.Drawing.Point(19, 272);
            this.gtbCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbCP.Name = "gtbCP";
            this.gtbCP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbCP.PlaceholderText = "Confirm Password";
            this.gtbCP.SelectedText = "";
            this.gtbCP.Size = new System.Drawing.Size(380, 35);
            this.gtbCP.TabIndex = 12;
            this.gtbCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtbCP.UseSystemPasswordChar = true;
            // 
            // gtbP
            // 
            this.gtbP.BorderRadius = 5;
            this.gtbP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbP.DefaultText = "";
            this.gtbP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbP.ForeColor = System.Drawing.Color.Black;
            this.gtbP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbP.Location = new System.Drawing.Point(19, 229);
            this.gtbP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbP.Name = "gtbP";
            this.gtbP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbP.PlaceholderText = "Password";
            this.gtbP.SelectedText = "";
            this.gtbP.Size = new System.Drawing.Size(380, 35);
            this.gtbP.TabIndex = 11;
            this.gtbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtbP.UseSystemPasswordChar = true;
            // 
            // gtbPN
            // 
            this.gtbPN.BorderRadius = 5;
            this.gtbPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbPN.DefaultText = "";
            this.gtbPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbPN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbPN.ForeColor = System.Drawing.Color.Black;
            this.gtbPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbPN.Location = new System.Drawing.Point(19, 186);
            this.gtbPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbPN.Name = "gtbPN";
            this.gtbPN.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbPN.PlaceholderText = "Phone Number";
            this.gtbPN.SelectedText = "";
            this.gtbPN.Size = new System.Drawing.Size(380, 35);
            this.gtbPN.TabIndex = 10;
            this.gtbPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gtbE
            // 
            this.gtbE.BorderRadius = 5;
            this.gtbE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbE.DefaultText = "";
            this.gtbE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbE.ForeColor = System.Drawing.Color.Black;
            this.gtbE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbE.Location = new System.Drawing.Point(19, 100);
            this.gtbE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbE.Name = "gtbE";
            this.gtbE.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbE.PlaceholderText = "Email";
            this.gtbE.SelectedText = "";
            this.gtbE.Size = new System.Drawing.Size(380, 35);
            this.gtbE.TabIndex = 8;
            this.gtbE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtbE.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // gtbUN
            // 
            this.gtbUN.BorderRadius = 5;
            this.gtbUN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbUN.DefaultText = "";
            this.gtbUN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbUN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbUN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbUN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbUN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbUN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbUN.ForeColor = System.Drawing.Color.Black;
            this.gtbUN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbUN.Location = new System.Drawing.Point(19, 57);
            this.gtbUN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbUN.Name = "gtbUN";
            this.gtbUN.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbUN.PlaceholderText = "UserName";
            this.gtbUN.SelectedText = "";
            this.gtbUN.Size = new System.Drawing.Size(380, 35);
            this.gtbUN.TabIndex = 7;
            this.gtbUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gtbFN
            // 
            this.gtbFN.BorderRadius = 5;
            this.gtbFN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbFN.DefaultText = "";
            this.gtbFN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbFN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbFN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbFN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbFN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbFN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gtbFN.ForeColor = System.Drawing.Color.Black;
            this.gtbFN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbFN.Location = new System.Drawing.Point(19, 14);
            this.gtbFN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbFN.Name = "gtbFN";
            this.gtbFN.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.gtbFN.PlaceholderText = "Full Name";
            this.gtbFN.SelectedText = "";
            this.gtbFN.Size = new System.Drawing.Size(380, 35);
            this.gtbFN.TabIndex = 6;
            this.gtbFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.pnlMainPanel);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(1100, 713);
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlSUBPN.ResumeLayout(false);
            this.pnlSUBPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpbPIC)).EndInit();
            this.pnlFM.ResumeLayout(false);
            this.pnlFM.PerformLayout();
            this.pnlGENDER.ResumeLayout(false);
            this.pnlGENDER.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMainPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlSUBPN;
        private Guna.UI2.WinForms.Guna2GradientButton gbSU;
        private Guna.UI2.WinForms.Guna2Panel pnlFM;
        private Guna.UI2.WinForms.Guna2TextBox gtbE;
        private Guna.UI2.WinForms.Guna2TextBox gtbUN;
        private Guna.UI2.WinForms.Guna2TextBox gtbFN;
        private Guna.UI2.WinForms.Guna2TextBox gtbUD;
        private Guna.UI2.WinForms.Guna2TextBox gtbCP;
        private Guna.UI2.WinForms.Guna2TextBox gtbP;
        private Guna.UI2.WinForms.Guna2TextBox gtbPN;
        private System.Windows.Forms.Panel pnlGENDER;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.CheckBox cbCL;
        private System.Windows.Forms.Label lblST;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdtpDT;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbPL;
        private System.Windows.Forms.Label lblLGS;
        private Guna.UI2.WinForms.Guna2PictureBox gpbPIC;
        private Guna.UI2.WinForms.Guna2ComboBox gcbUT;
        private System.Windows.Forms.Label lblCD;
    }
}
