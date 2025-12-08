namespace SuperMarket.PL
{
    partial class fm_categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_cat_lists = new System.Windows.Forms.DataGridView();
            this.lab_position = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_print_all = new System.Windows.Forms.Button();
            this.btn_print_single = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exportAll_to_pdf = new System.Windows.Forms.Button();
            this.btn_products_of_category_save_to_pdf = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat_lists)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_cat_lists);
            this.groupBox2.Controls.Add(this.lab_position);
            this.groupBox2.Controls.Add(this.btn_next);
            this.groupBox2.Controls.Add(this.btn_last);
            this.groupBox2.Controls.Add(this.btn_first);
            this.groupBox2.Controls.Add(this.btn_previous);
            this.groupBox2.Controls.Add(this.txt_desc);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 275);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصنف";
            // 
            // dgv_cat_lists
            // 
            this.dgv_cat_lists.AllowUserToAddRows = false;
            this.dgv_cat_lists.AllowUserToResizeColumns = false;
            this.dgv_cat_lists.AllowUserToResizeRows = false;
            this.dgv_cat_lists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cat_lists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cat_lists.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_cat_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cat_lists.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cat_lists.Location = new System.Drawing.Point(6, 23);
            this.dgv_cat_lists.MultiSelect = false;
            this.dgv_cat_lists.Name = "dgv_cat_lists";
            this.dgv_cat_lists.ReadOnly = true;
            this.dgv_cat_lists.RowHeadersWidth = 51;
            this.dgv_cat_lists.RowTemplate.Height = 26;
            this.dgv_cat_lists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cat_lists.Size = new System.Drawing.Size(481, 241);
            this.dgv_cat_lists.TabIndex = 0;
            this.dgv_cat_lists.CurrentCellChanged += new System.EventHandler(this.dgv_cat_lists_CurrentCellChanged);
            // 
            // lab_position
            // 
            this.lab_position.BackColor = System.Drawing.Color.AliceBlue;
            this.lab_position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_position.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_position.Location = new System.Drawing.Point(658, 223);
            this.lab_position.Name = "lab_position";
            this.lab_position.Size = new System.Drawing.Size(96, 45);
            this.lab_position.TabIndex = 5;
            this.lab_position.Text = "0";
            this.lab_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(577, 224);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 44);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(496, 224);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 44);
            this.btn_last.TabIndex = 4;
            this.btn_last.Text = ">>||";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Location = new System.Drawing.Point(841, 223);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 44);
            this.btn_first.TabIndex = 2;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Location = new System.Drawing.Point(760, 223);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 44);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "<<";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_desc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(498, 102);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(275, 70);
            this.txt_desc.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(578, 52);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(196, 34);
            this.txt_id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(779, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "وصف الصنف :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(780, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "معرف الصنف :";
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_new.Location = new System.Drawing.Point(797, 23);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(94, 38);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_print_all);
            this.groupBox3.Controls.Add(this.btn_print_single);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Controls.Add(this.btn_exportAll_to_pdf);
            this.groupBox3.Controls.Add(this.btn_products_of_category_save_to_pdf);
            this.groupBox3.Controls.Add(this.close);
            this.groupBox3.Location = new System.Drawing.Point(9, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 140);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // btn_print_all
            // 
            this.btn_print_all.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_print_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_all.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_print_all.Location = new System.Drawing.Point(39, 23);
            this.btn_print_all.Name = "btn_print_all";
            this.btn_print_all.Size = new System.Drawing.Size(177, 38);
            this.btn_print_all.TabIndex = 2;
            this.btn_print_all.Text = "طباعة كل الأصناف";
            this.btn_print_all.UseVisualStyleBackColor = false;
            this.btn_print_all.Click += new System.EventHandler(this.btn_print_all_Click);
            // 
            // btn_print_single
            // 
            this.btn_print_single.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_print_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_single.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_print_single.Location = new System.Drawing.Point(222, 23);
            this.btn_print_single.Name = "btn_print_single";
            this.btn_print_single.Size = new System.Drawing.Size(263, 38);
            this.btn_print_single.TabIndex = 2;
            this.btn_print_single.Text = "طباعة منتجات صنف معين";
            this.btn_print_single.UseVisualStyleBackColor = false;
            this.btn_print_single.Click += new System.EventHandler(this.btn_print_single_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_update.Location = new System.Drawing.Point(491, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 38);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_delete.Location = new System.Drawing.Point(593, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 38);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_add.Enabled = false;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_add.Location = new System.Drawing.Point(695, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 38);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "إضافة";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exportAll_to_pdf
            // 
            this.btn_exportAll_to_pdf.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_exportAll_to_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportAll_to_pdf.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_exportAll_to_pdf.Location = new System.Drawing.Point(540, 73);
            this.btn_exportAll_to_pdf.Name = "btn_exportAll_to_pdf";
            this.btn_exportAll_to_pdf.Size = new System.Drawing.Size(288, 38);
            this.btn_exportAll_to_pdf.TabIndex = 2;
            this.btn_exportAll_to_pdf.Text = "حفظ لائحة الأصناف في ملف pdf";
            this.btn_exportAll_to_pdf.UseVisualStyleBackColor = false;
            this.btn_exportAll_to_pdf.Click += new System.EventHandler(this.btn_exportAll_to_pdf_Click);
            // 
            // btn_products_of_category_save_to_pdf
            // 
            this.btn_products_of_category_save_to_pdf.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_products_of_category_save_to_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products_of_category_save_to_pdf.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_products_of_category_save_to_pdf.Location = new System.Drawing.Point(241, 73);
            this.btn_products_of_category_save_to_pdf.Name = "btn_products_of_category_save_to_pdf";
            this.btn_products_of_category_save_to_pdf.Size = new System.Drawing.Size(293, 38);
            this.btn_products_of_category_save_to_pdf.TabIndex = 2;
            this.btn_products_of_category_save_to_pdf.Text = "حفظ منتاجات صنف في ملف pdf";
            this.btn_products_of_category_save_to_pdf.UseVisualStyleBackColor = false;
            this.btn_products_of_category_save_to_pdf.Click += new System.EventHandler(this.btn_products_of_category_save_to_pdf_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.AliceBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.close.Location = new System.Drawing.Point(103, 73);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(132, 38);
            this.close.TabIndex = 2;
            this.close.Text = "الخروج";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // fm_categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العمليات المتاحة";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat_lists)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_position;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_exportAll_to_pdf;
        private System.Windows.Forms.Button btn_products_of_category_save_to_pdf;
        private System.Windows.Forms.Button btn_print_all;
        private System.Windows.Forms.Button btn_print_single;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_cat_lists;
        private System.Windows.Forms.Button btn_first;
    }
}