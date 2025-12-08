using System.Windows.Forms;
namespace SuperMarket.PL
{
    partial class fm_add_product
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_getImage = new System.Windows.Forms.Button();
            this.pb_pr_Image = new System.Windows.Forms.PictureBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.txt_dec = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pr_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_getImage);
            this.groupBox1.Controls.Add(this.pb_pr_Image);
            this.groupBox1.Controls.Add(this.cb_category);
            this.groupBox1.Controls.Add(this.txt_dec);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(192)))), ((int)(((byte)(238)))));
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.bt_reset.Location = new System.Drawing.Point(367, 588);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(150, 52);
            this.bt_reset.TabIndex = 8;
            this.bt_reset.Text = "إعادة تعيين";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_cancel.Location = new System.Drawing.Point(43, 562);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 48);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "إلغاء";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(137, 563);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 47);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "إضافة ";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_getImage
            // 
            this.btn_getImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getImage.Location = new System.Drawing.Point(122, 494);
            this.btn_getImage.Name = "btn_getImage";
            this.btn_getImage.Size = new System.Drawing.Size(221, 36);
            this.btn_getImage.TabIndex = 5;
            this.btn_getImage.Text = "تحديد ملف الصورة";
            this.btn_getImage.UseVisualStyleBackColor = true;
            this.btn_getImage.Click += new System.EventHandler(this.btn_getImage_Click);
            // 
            // pb_pr_Image
            // 
            this.pb_pr_Image.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pb_pr_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_pr_Image.Location = new System.Drawing.Point(122, 350);
            this.pb_pr_Image.Name = "pb_pr_Image";
            this.pb_pr_Image.Size = new System.Drawing.Size(221, 138);
            this.pb_pr_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pr_Image.TabIndex = 3;
            this.pb_pr_Image.TabStop = false;
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(169, 47);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(174, 34);
            this.cb_category.TabIndex = 0;
            // 
            // txt_dec
            // 
            this.txt_dec.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_dec.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_dec.Location = new System.Drawing.Point(137, 148);
            this.txt_dec.Multiline = true;
            this.txt_dec.Name = "txt_dec";
            this.txt_dec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_dec.Size = new System.Drawing.Size(206, 79);
            this.txt_dec.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(169, 308);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(174, 30);
            this.txt_Price.TabIndex = 4;
            this.txt_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyDown);
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.Location = new System.Drawing.Point(169, 261);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(174, 30);
            this.txtQte.TabIndex = 3;
            this.txtQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(367, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "صورة المنتج :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(384, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ثمن المنتج :";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(169, 94);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(174, 30);
            this.txtId.TabIndex = 1;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            this.txtId.Validated += new System.EventHandler(this.txtId_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(356, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "الكمية المخزنة :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(367, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "وصف المنتج :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(366, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "معرف المنتج :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(370, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج :";
            // 
            // fm_add_product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(637, 719);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_add_product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pr_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_cancel;
        private Button bt_reset;
        public ComboBox cb_category;
        public TextBox txt_dec;
        public TextBox txtId;
        public Button btn_getImage;
        public PictureBox pb_pr_Image;
        public TextBox txt_Price;
        public TextBox txtQte;
        public Button btn_Add;
    }
}