using System.Windows.Forms;
namespace SuperMarket.PL
{
    partial class Image_display
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.view_Image_PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.view_Image_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // view_Image_PB
            // 
            this.view_Image_PB.BackColor = System.Drawing.Color.Transparent;
            this.view_Image_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_Image_PB.Location = new System.Drawing.Point(0, 0);
            this.view_Image_PB.Name = "view_Image_PB";
            this.view_Image_PB.Size = new System.Drawing.Size(835, 501);
            this.view_Image_PB.TabIndex = 0;
            this.view_Image_PB.TabStop = false;
            this.view_Image_PB.Click += new System.EventHandler(this.view_Image_PB_Click);
            // 
            // Image_display
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(835, 501);
            this.Controls.Add(this.view_Image_PB);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Image_display";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة عرض الصورة";
            ((System.ComponentModel.ISupportInitialize)(this.view_Image_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox view_Image_PB;
    }
}