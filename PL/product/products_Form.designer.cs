using System.Windows.Forms;
namespace SuperMarket.PL
{
    partial class products_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PR_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_display_all_products = new System.Windows.Forms.Button();
            this.but_display_one_product = new System.Windows.Forms.Button();
            this.pf_exit = new System.Windows.Forms.Button();
            this.btn_save_exl = new System.Windows.Forms.Button();
            this.btn_product_Image = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.btn_Manage_ANP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PR_dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(212, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "قم بإدخال النص المراد البحث عنه :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(526, 29);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(303, 27);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.PR_dgv);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 470);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة المنتجات";
            // 
            // PR_dgv
            // 
            this.PR_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PR_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PR_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PR_dgv.GridColor = System.Drawing.Color.Silver;
            this.PR_dgv.Location = new System.Drawing.Point(0, 42);
            this.PR_dgv.MultiSelect = false;
            this.PR_dgv.Name = "PR_dgv";
            this.PR_dgv.ReadOnly = true;
            this.PR_dgv.RowHeadersWidth = 51;
            this.PR_dgv.RowTemplate.Height = 29;
            this.PR_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PR_dgv.Size = new System.Drawing.Size(987, 428);
            this.PR_dgv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_display_all_products);
            this.groupBox2.Controls.Add(this.but_display_one_product);
            this.groupBox2.Controls.Add(this.pf_exit);
            this.groupBox2.Controls.Add(this.btn_save_exl);
            this.groupBox2.Controls.Add(this.btn_product_Image);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_deleteProduct);
            this.groupBox2.Controls.Add(this.btn_Manage_ANP);
            this.groupBox2.Location = new System.Drawing.Point(27, 550);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btn_display_all_products
            // 
            this.btn_display_all_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_display_all_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_display_all_products.Location = new System.Drawing.Point(40, 29);
            this.btn_display_all_products.Name = "btn_display_all_products";
            this.btn_display_all_products.Size = new System.Drawing.Size(146, 35);
            this.btn_display_all_products.TabIndex = 0;
            this.btn_display_all_products.Text = "طباعة كل المنتجات";
            this.btn_display_all_products.UseVisualStyleBackColor = false;
            this.btn_display_all_products.Click += new System.EventHandler(this.btn_display_all_products_Click);
            // 
            // but_display_one_product
            // 
            this.but_display_one_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.but_display_one_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_display_one_product.Location = new System.Drawing.Point(192, 29);
            this.but_display_one_product.Name = "but_display_one_product";
            this.but_display_one_product.Size = new System.Drawing.Size(146, 35);
            this.but_display_one_product.TabIndex = 0;
            this.but_display_one_product.Text = "طباعة منتج محدد";
            this.but_display_one_product.UseVisualStyleBackColor = false;
            this.but_display_one_product.Click += new System.EventHandler(this.btn_display_one_product_Click);
            // 
            // pf_exit
            // 
            this.pf_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.pf_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pf_exit.Location = new System.Drawing.Point(292, 70);
            this.pf_exit.Name = "pf_exit";
            this.pf_exit.Size = new System.Drawing.Size(146, 35);
            this.pf_exit.TabIndex = 0;
            this.pf_exit.Text = "الخروج";
            this.pf_exit.UseVisualStyleBackColor = false;
            this.pf_exit.Click += new System.EventHandler(this.pf_exit_Click);
            // 
            // btn_save_exl
            // 
            this.btn_save_exl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_save_exl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_exl.Location = new System.Drawing.Point(444, 70);
            this.btn_save_exl.Name = "btn_save_exl";
            this.btn_save_exl.Size = new System.Drawing.Size(198, 35);
            this.btn_save_exl.TabIndex = 0;
            this.btn_save_exl.Text = "حفض الائحة في ملف إكسل";
            this.btn_save_exl.UseVisualStyleBackColor = false;
            this.btn_save_exl.Click += new System.EventHandler(this.btn_save_exl_Click);
            // 
            // btn_product_Image
            // 
            this.btn_product_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_product_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product_Image.Location = new System.Drawing.Point(344, 29);
            this.btn_product_Image.Name = "btn_product_Image";
            this.btn_product_Image.Size = new System.Drawing.Size(146, 35);
            this.btn_product_Image.TabIndex = 0;
            this.btn_product_Image.Text = "صورة المنتج";
            this.btn_product_Image.UseVisualStyleBackColor = false;
            this.btn_product_Image.Click += new System.EventHandler(this.btn_product_Image_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(496, 29);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(146, 35);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "تعديل بيانات منتج";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteProduct.Location = new System.Drawing.Point(648, 29);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(146, 35);
            this.btn_deleteProduct.TabIndex = 0;
            this.btn_deleteProduct.Text = "حذف منتج معين";
            this.btn_deleteProduct.UseVisualStyleBackColor = false;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_Manage_ANP
            // 
            this.btn_Manage_ANP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_Manage_ANP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manage_ANP.Location = new System.Drawing.Point(800, 29);
            this.btn_Manage_ANP.Name = "btn_Manage_ANP";
            this.btn_Manage_ANP.Size = new System.Drawing.Size(146, 35);
            this.btn_Manage_ANP.TabIndex = 0;
            this.btn_Manage_ANP.Text = "إضافة منتج جديد";
            this.btn_Manage_ANP.UseVisualStyleBackColor = false;
            this.btn_Manage_ANP.Click += new System.EventHandler(this.btn_Manage_ANP_Click);
            // 
            // products_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1041, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "products_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة إدارة المنتجات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PR_dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox search;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_display_all_products;
        private Button but_display_one_product;
        private Button pf_exit;
        private Button btn_save_exl;
        private Button btn_product_Image;
        private Button btn_update;
        private Button btn_deleteProduct;
        private Button btn_Manage_ANP;
        public DataGridView PR_dgv;
    }
}