using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuperMarket.PL
{
    public partial class fm_add_product : Form
    {
        public string state = "Add";
        BL.cls_product myobj = new BL.cls_product();

        public fm_add_product()
        {
            InitializeComponent();

            cb_category.DataSource = myobj.get_All_cateogries();
            cb_category.DisplayMember = "DESCRPITION-CAT";
            cb_category.ValueMember = "ID-CAT";
        }

        private void btn_getImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.png; *.gif; *.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_pr_Image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (txt_dec.Text == "" || txtId.Text == "" || txt_Price.Text == "" || txtQte.Text == "")
            {
                MessageBox.Show("هناك حقول فارغة", "فشل عملية الإضافة",
                  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


                byte[] byteImage = null;
                if (pb_pr_Image.Image != null)
                {
                    MemoryStream MS = new MemoryStream();
                    pb_pr_Image.Image.Save(MS, pb_pr_Image.Image.RawFormat);
                    byteImage = MS.ToArray();
                }

                if (state == "Add")
                {
                 Program.dal.Execute("add_product", myobj.Fill_data(Convert.ToInt32(cb_category.SelectedValue)
                 , txtId.Text,  txt_dec.Text, txt_Price.Text,
                 Convert.ToInt32(txtQte.Text), byteImage) );

                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.ClearForm(this);
                return;
                }


            Program.dal.Execute("update_product", myobj.Fill_data(Convert.ToInt32(cb_category.SelectedValue),
                        txt_dec.Text, txtId.Text, txt_Price.Text,
                        Convert.ToInt32(txtQte.Text), byteImage) );

                    MessageBox.Show("تم تحديث البيانات بنجاح", "عملية التعديل",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                

                products_Form.getMainForm.PR_dgv.DataSource = myobj.get_All_product();
           
        }//End method

        private void txtId_Validated(object sender, EventArgs e)
        {
            if (state == "Add") {
                DataTable dt = new DataTable();
                dt = myobj.VerifyProductId(txtId.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    txtId.SelectionStart = 0;
                    txtId.SelectionLength = txtId.Text.Length;
                }
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            Program.ClearForm(this);
        }

       


        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)    {
                e.Handled = true;
                MessageBox.Show("لا يمكنك إدخال نص هنا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("لا يمكنك إدخال نص هنا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

               if ( e.KeyChar == '.')   
                 if (txt_Price.Text.Length == 0  || txt_Price.Text.Contains(".") )
                    e.Handled = true;           
        }

        private void txt_Price_Leave(object sender, EventArgs e)
        {
            if (txt_Price.Text.EndsWith("."))
                txt_Price.Text=  txt_Price.Text.TrimEnd('.');
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_dec.Focus();
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Price.Focus();
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_getImage.Focus();
        }
    }
}
