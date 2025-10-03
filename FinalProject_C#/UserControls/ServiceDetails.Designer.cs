namespace FinalProject_C_.UserControls
{
    partial class ServiceDetails
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.guna2GradientPanel2);
            this.pnlMainPanel.Controls.Add(this.guna2GradientPanel1);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pnlMainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pnlMainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.ShadowDecoration.BorderRadius = 100;
            this.pnlMainPanel.ShadowDecoration.Depth = 1;
            this.pnlMainPanel.Size = new System.Drawing.Size(918, 713);
            this.pnlMainPanel.TabIndex = 5;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Location = new System.Drawing.Point(76, 132);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(0, 0);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.BorderRadius = 100;
            this.guna2GradientPanel2.ShadowDecoration.Depth = 1;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(918, 713);
            this.guna2GradientPanel2.TabIndex = 9;
            // 
            // ServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainPanel);
            this.Name = "ServiceDetails";
            this.Size = new System.Drawing.Size(918, 713);
            this.pnlMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMainPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
    }
}
