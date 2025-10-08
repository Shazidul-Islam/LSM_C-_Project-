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
            this.flpService = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpService
            // 
            this.flpService.AutoScroll = true;
            this.flpService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.flpService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpService.Location = new System.Drawing.Point(0, 0);
            this.flpService.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.flpService.Name = "flpService";
            this.flpService.Size = new System.Drawing.Size(887, 635);
            this.flpService.TabIndex = 0;
            // 
            // Sevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpService);
            this.Name = "Sevices";
            this.Size = new System.Drawing.Size(887, 635);
            this.Load += new System.EventHandler(this.Sevices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpService;
    }
}
