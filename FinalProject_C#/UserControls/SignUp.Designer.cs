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
            this.pnlMainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSignUpBTOLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.btnSignUpBTOLogin);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pnlMainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pnlMainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(1100, 713);
            this.pnlMainPanel.TabIndex = 4;
            // 
            // btnSignUpBTOLogin
            // 
            this.btnSignUpBTOLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUpBTOLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUpBTOLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUpBTOLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUpBTOLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignUpBTOLogin.ForeColor = System.Drawing.Color.White;
            this.btnSignUpBTOLogin.Location = new System.Drawing.Point(86, 600);
            this.btnSignUpBTOLogin.Name = "btnSignUpBTOLogin";
            this.btnSignUpBTOLogin.Size = new System.Drawing.Size(180, 45);
            this.btnSignUpBTOLogin.TabIndex = 6;
            this.btnSignUpBTOLogin.Text = "BLogin";
            this.btnSignUpBTOLogin.Click += new System.EventHandler(this.btnSignUpBTOLogin_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMainPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignUpBTOLogin;
    }
}
