namespace FinalProject_C_.UserControls
{
    partial class Sevices
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpServices = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchService = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flpServices);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 64);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(887, 571);
            this.guna2Panel1.TabIndex = 0;
            // 
            // flpServices
            // 
            this.flpServices.AutoScroll = true;
            this.flpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.flpServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpServices.Location = new System.Drawing.Point(0, 0);
            this.flpServices.Name = "flpServices";
            this.flpServices.Size = new System.Drawing.Size(887, 571);
            this.flpServices.TabIndex = 0;
            // 
            // txtSearchService
            // 
            this.txtSearchService.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchService.BorderRadius = 8;
            this.txtSearchService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchService.DefaultText = "";
            this.txtSearchService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(147)))), ((int)(((byte)(138)))));
            this.txtSearchService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchService.ForeColor = System.Drawing.Color.Black;
            this.txtSearchService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchService.Location = new System.Drawing.Point(0, 0);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.PlaceholderText = "";
            this.txtSearchService.SelectedText = "";
            this.txtSearchService.Size = new System.Drawing.Size(887, 37);
            this.txtSearchService.TabIndex = 5;
            // 
            // Sevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.txtSearchService);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Sevices";
            this.Size = new System.Drawing.Size(887, 635);
            this.Load += new System.EventHandler(this.Sevices_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flpServices;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchService;
    }
}
