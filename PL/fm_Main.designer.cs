using System.Windows.Forms;
namespace SuperMarket.PL
{
    partial class fm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_login = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_create_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_recover_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_log_out = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_customers_Managment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsm_add_new_sale_operation = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_sales_managment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_products = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_new_product_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.Mpro_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MS_category_managment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_user = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_add_user = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_users_managment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MS,
            this.tsm_customer,
            this.tsm_products,
            this.tsm_user});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_MS
            // 
            this.File_MS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.File_MS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_login,
            this.tsm_create_backup,
            this.tsm_recover_backup,
            this.Tsm_log_out});
            this.File_MS.Name = "File_MS";
            this.File_MS.Size = new System.Drawing.Size(52, 26);
            this.File_MS.Text = "ملف";
            // 
            // Tsm_login
            // 
            this.Tsm_login.Name = "Tsm_login";
            this.Tsm_login.Size = new System.Drawing.Size(241, 26);
            this.Tsm_login.Text = "تسجيل الدخول";
            this.Tsm_login.Click += new System.EventHandler(this.Tsm_login_Click);
            // 
            // tsm_create_backup
            // 
            this.tsm_create_backup.Name = "tsm_create_backup";
            this.tsm_create_backup.Size = new System.Drawing.Size(241, 26);
            this.tsm_create_backup.Text = "إنشاء نسخة إحتياطية";
            this.tsm_create_backup.Click += new System.EventHandler(this.tsm_create_backup_Click);
            // 
            // tsm_recover_backup
            // 
            this.tsm_recover_backup.Name = "tsm_recover_backup";
            this.tsm_recover_backup.Size = new System.Drawing.Size(241, 26);
            this.tsm_recover_backup.Text = "إستعادة نسخة محفوظة";
            this.tsm_recover_backup.Click += new System.EventHandler(this.tsm_recover_backup_Click);
            // 
            // Tsm_log_out
            // 
            this.Tsm_log_out.Name = "Tsm_log_out";
            this.Tsm_log_out.Size = new System.Drawing.Size(241, 26);
            this.Tsm_log_out.Text = "تسجيل الخروج";
            this.Tsm_log_out.Click += new System.EventHandler(this.Tsm_log_out_Click);
            // 
            // tsm_customer
            // 
            this.tsm_customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsm_customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_customers_Managment,
            this.toolStripSeparator2,
            this.Tsm_add_new_sale_operation,
            this.Tsm_sales_managment});
            this.tsm_customer.Name = "tsm_customer";
            this.tsm_customer.Size = new System.Drawing.Size(65, 26);
            this.tsm_customer.Text = "العملاء";
            // 
            // MS_customers_Managment
            // 
            this.MS_customers_Managment.Name = "MS_customers_Managment";
            this.MS_customers_Managment.Size = new System.Drawing.Size(188, 26);
            this.MS_customers_Managment.Text = "إدارة العملاء";
            this.MS_customers_Managment.Click += new System.EventHandler(this.MS_customers_Managment_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // Tsm_add_new_sale_operation
            // 
            this.Tsm_add_new_sale_operation.Name = "Tsm_add_new_sale_operation";
            this.Tsm_add_new_sale_operation.Size = new System.Drawing.Size(188, 26);
            this.Tsm_add_new_sale_operation.Text = "إضافة بيع جديد";
            this.Tsm_add_new_sale_operation.Click += new System.EventHandler(this.Tsm_add_new_sale_operation_Click);
            // 
            // Tsm_sales_managment
            // 
            this.Tsm_sales_managment.Name = "Tsm_sales_managment";
            this.Tsm_sales_managment.Size = new System.Drawing.Size(188, 26);
            this.Tsm_sales_managment.Text = "إدارة المبيعات";
            this.Tsm_sales_managment.Click += new System.EventHandler(this.Tsm_sales_managment_Click);
            // 
            // tsm_products
            // 
            this.tsm_products.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsm_products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_new_product_MS,
            this.Mpro_MS,
            this.toolStripSeparator1,
            this.MS_category_managment});
            this.tsm_products.Name = "tsm_products";
            this.tsm_products.Size = new System.Drawing.Size(78, 26);
            this.tsm_products.Text = "المنتجات";
            // 
            // Add_new_product_MS
            // 
            this.Add_new_product_MS.Name = "Add_new_product_MS";
            this.Add_new_product_MS.Size = new System.Drawing.Size(197, 26);
            this.Add_new_product_MS.Text = "إضافة منتج جديد";
            this.Add_new_product_MS.Click += new System.EventHandler(this.Add_new_product_MS_Click);
            // 
            // Mpro_MS
            // 
            this.Mpro_MS.Name = "Mpro_MS";
            this.Mpro_MS.Size = new System.Drawing.Size(197, 26);
            this.Mpro_MS.Text = "إدارة  المنتجات ";
            this.Mpro_MS.Click += new System.EventHandler(this.Mpro_MS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // MS_category_managment
            // 
            this.MS_category_managment.Name = "MS_category_managment";
            this.MS_category_managment.Size = new System.Drawing.Size(197, 26);
            this.MS_category_managment.Text = "إدارة الأصناف";
            this.MS_category_managment.Click += new System.EventHandler(this.MS_category_managment_Click);
            // 
            // tsm_user
            // 
            this.tsm_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsm_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_add_user,
            this.Tsm_users_managment});
            this.tsm_user.Name = "tsm_user";
            this.tsm_user.Size = new System.Drawing.Size(103, 26);
            this.tsm_user.Text = "المستخدمون";
            // 
            // Tsm_add_user
            // 
            this.Tsm_add_user.Name = "Tsm_add_user";
            this.Tsm_add_user.Size = new System.Drawing.Size(222, 26);
            this.Tsm_add_user.Text = "إضافة مستخدم جديد";
            this.Tsm_add_user.Click += new System.EventHandler(this.Tsm_add_user_Click);
            // 
            // Tsm_users_managment
            // 
            this.Tsm_users_managment.Name = "Tsm_users_managment";
            this.Tsm_users_managment.Size = new System.Drawing.Size(222, 26);
            this.Tsm_users_managment.Text = "إدارة المستخدمين";
            this.Tsm_users_managment.Click += new System.EventHandler(this.Tsm_users_managment_Click);
            // 
            // fm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 609);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem File_MS;
        private ToolStripMenuItem Tsm_login;
        private ToolStripMenuItem tsm_create_backup;
        private ToolStripMenuItem tsm_recover_backup;
        private ToolStripMenuItem Tsm_log_out;
        public ToolStripMenuItem tsm_customer;
        private ToolStripMenuItem MS_customers_Managment;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem Tsm_add_new_sale_operation;
        private ToolStripMenuItem Tsm_sales_managment;
        private ToolStripMenuItem tsm_products;
        private ToolStripMenuItem Add_new_product_MS;
        private ToolStripMenuItem Mpro_MS;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MS_category_managment;
        private ToolStripMenuItem tsm_user;
        private ToolStripMenuItem Tsm_add_user;
        private ToolStripMenuItem Tsm_users_managment;
    }
}