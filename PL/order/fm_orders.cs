using SuperMarket.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.PL
{
    public partial class fm_orders : Form
    {
        BL.cls_orders cl_order = new cls_orders();
        DataTable dt = new DataTable();
      


        public fm_orders()
        {
            InitializeComponent();
            createdataTable();
            if (Program.user_name.Length != 0)
                txt_sales_Man.Text = Program.user_name;

            this.txt_order_id.Text = Program.dal.select
            ("get_last_order_id", null).Rows[0][0].ToString();
        }


        void calculateAmount ()
        {     
         if (txt_qte.Text != String.Empty)
            {
                txt_amout.Text = (Convert.ToDouble(txt_price.Text) * Convert.ToDouble(txt_qte.Text)).ToString();
                txt_total_amout.Text = txt_amout.Text;
            }      
        }

        void calculateTotalAmount()
        {
            if (txt_discount.Text != String.Empty)
            {
                txt_total_amout.Text =
                (Convert.ToDouble(txt_amout.Text) - (
                Convert.ToDouble(txt_amout.Text) *
                (Convert.ToDouble(txt_discount.Text) / 100))).ToString();
            }       
        }

        void calaculate_Total_of_Totals ()
           {
            txt_all_Totals.Text =
           (from DataGridViewRow row in dgv_products.Rows
            where row.Cells[6].FormattedValue.ToString() != string.Empty
           select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }





        void clearboxes()
        {
            foreach (Control ctrl in gb_products.Controls)
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                btn_get_products.Focus();

        }

        void cleardata ()
        {
            Program.ClearForm(gb_customer);
            Program.ClearForm(gb_order);
           
            order_date.ResetText();
            txt_all_Totals.Clear();
            pb_customer_image.Image = null;
            clearboxes();
            dt.Clear();
            dgv_products.DataSource = null;
           

        }

        void createdataTable ()
        {
         for (int i = 0; i < 7; i++)
                dt.Columns.Add("");
            
            this.dgv_products.DataSource = dt;             
        }

        void resize_dgv ()
        {
            this.dgv_products.RowHeadersWidth = 119;
            int[] width = { 169, 200, 133, 133, 146, 119, 146 };
            for (int i = 0; i < width.Length; i++)
            this.dgv_products.Columns[i].Width = width[i];    
        }

        private void dgv_products_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            resize_dgv();
        }



        

        private void btn_get_customers_Click(object sender, EventArgs e)
        {
            fm_customer_list fm = new fm_customer_list();
            fm.ShowDialog();
            var temp = fm.dgv_customers.CurrentRow;
            this.txt_customer_id.Text = temp.Cells[0].Value.ToString();
            this.txt_firstName.Text =   temp.Cells[1].Value.ToString();
            this.txt_lastName.Text =    temp.Cells[2].Value.ToString();
            this.txt_phoneNumber.Text = temp.Cells[3].Value.ToString();
            this.txt_email.Text =       temp.Cells[4].Value.ToString();
           

            if (fm.dgv_customers.CurrentRow.Cells[5].Value != DBNull.Value)
            {
                byte[] picture = (byte[])fm.dgv_customers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture);
                pb_customer_image.Image = Image.FromStream(ms);
            }
       }


       

        private void btn_get_products_Click(object sender, EventArgs e)
        {
            clearboxes();
            fm_products_list fm = new fm_products_list();
            fm.ShowDialog();

            var temp = fm.dgv_products_list.CurrentRow;
         this.txt_product_id.Text =   temp.Cells[0].Value.ToString();
         this.txt_product_name.Text = temp.Cells[1].Value.ToString();
         this.txt_price.Text =        temp.Cells[3].Value.ToString();

           if (txt_product_id.Text != String.Empty)
            {
                txt_qte.Enabled = true;
                txt_discount.Enabled = true;
                this.txt_qte.Focus();
            }
        
        }



        private void btn_save_current_sale_Click(object sender, EventArgs e)
        {
            
            if (txt_customer_id.Text != String.Empty)
            {
                if (dgv_products.Rows.Count > 1)
                {
                   
                    Program.dal.Execute("add_order", cl_order.Fill_order_data(Convert.ToInt16(txt_order_id.Text),
                      order_date.Value, Convert.ToInt16(txt_customer_id.Text)
                      , txt_order_dec.Text, txt_sales_Man.Text));
                   
                    call_Fill_order_details_data();
                    MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata();
                    btn_display_bill.Enabled = true;

                }

                else
                    MessageBox.Show("لم يتم تحديد منتجات يعد", "تنبيه",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("لم يتم تحديد عميل بعد ", "تنبيه",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }




        void call_Fill_order_details_data()
        {
            for (int i = 0; i < dgv_products.Rows.Count - 1; i++)
            {
                var temp = dgv_products.Rows[i];
                Program.dal.Execute("add_order_details", cl_order.Fill_order_details_data(
                    temp.Cells[0].Value.ToString(),
                    Convert.ToInt16(txt_order_id.Text),
                    Convert.ToInt16(temp.Cells[3].Value),
                    temp.Cells[2].Value.ToString(),
                    temp.Cells[4].Value.ToString(),
                    float.Parse(temp.Cells[5].Value.ToString()),
                    temp.Cells[6].Value.ToString())
                     );
            }
                
        }

        private void btn_display_bill_Click(object sender, EventArgs e)
        {
            //get the last order;
            int temp_last_order_id = Convert.ToInt16(Program.dal.select
                ("get_last_order_for_print", null).Rows[0][0]);

            if (temp_last_order_id != 0)
            {
                this.Cursor = Cursors.WaitCursor;
                PR.rpt_orders myreport = new PR.rpt_orders();
                myreport.SetDataSource(cl_order.get_order_details(temp_last_order_id));
                PR.fm_reports myform = new PR.fm_reports();
                myform.crystalReportViewer1.ReportSource = myreport;
                myform.ShowDialog();
                this.Cursor = Cursors.Default;

                this.txt_order_id.Text = Program.dal.select
                  ("get_last_order_id", null).Rows[0][0].ToString();
            }
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txt_product_id.Text != string.Empty)
                clearboxes();
        }





        private void txt_qte_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=(char) Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("لا يمكنك إدخال نص هنا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          else if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_qte.Text != String.Empty)
                {
                    txt_discount.Enabled = true;
                    txt_discount.Focus();
                }

                else
                {
      MessageBox.Show("قم بتعبئة حقل الكمية أولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_qte.Focus();
                }
                  
            }
        }

       

        private void txt_qte_Leave(object sender, EventArgs e)
        {try
            {
        if (cl_order.verify_qte(txt_product_id.Text, Convert.ToInt16(txt_qte.Text)).Rows.Count > 0)
                {
                    calculateAmount();
                    calculateTotalAmount();
                }

                else
                {
                    MessageBox.Show("الكمية المراد شرائها غير متوفرة في المخزون :", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_qte.Clear();
                    txt_qte.Focus();
                }
            } catch  { return; }
           
        }


        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
          char separator = Convert.ToChar(System.Globalization.CultureInfo
           .CurrentCulture.NumberFormat.NumberDecimalSeparator);


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back 
                && e.KeyChar != separator && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("لا يمكنك إدخال نص هنا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           else  if (e.KeyChar == separator)
                if (txt_discount.Text.Length == 0 || txt_discount.Text.Contains(separator))
                    e.Handled = true;
        }


        private void txt_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

        for(int i=0;  i<dgv_products.Rows.Count-1; i++)         
           if (dgv_products.Rows[i].Cells[0].Value.ToString() == txt_product_id.Text)
            {
               MessageBox.Show("إن هذا المنتج موجود في الفاتورة مسبقا :", "تنبيه",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clearboxes();
                 return;
              }

                calculateTotalAmount();

                if (txt_discount.Text == String.Empty)              
                    txt_discount.Text = "0";
                   
                

                DataRow dr = dt.NewRow();
                dr[0] = txt_product_id.Text;
                dr[1] = txt_product_name.Text;
                dr[2] = txt_price.Text;
                dr[3] = txt_qte.Text;
                dr[4] = txt_amout.Text;
                dr[5] = txt_discount.Text;
                dr[6] = txt_total_amout.Text;

                dt.Rows.Add(dr);
                dgv_products.DataSource = dt;
                clearboxes();

                calaculate_Total_of_Totals();
            }
        }


        private void txt_discount_Leave(object sender, EventArgs e)
        {
        if (txt_discount.Text.EndsWith("."))
         txt_discount.Text = txt_discount.Text.TrimEnd('.');

                double check;
                if (double.TryParse(txt_discount.Text, out check))
                    if (check > 100)
                    {
                        txt_discount.Text = "0";
                        MessageBox.Show("أعلى خصم ممكن هو 100%", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }         
        }

        private void dgv_products_DoubleClick(object sender, EventArgs e)
        {
            try
            {
            if (txt_product_id.Text == string.Empty)
                { var temp = dgv_products.CurrentRow;
                    this.txt_product_id.Text   = temp.Cells[0].Value.ToString();
                    this.txt_product_name.Text = temp.Cells[1].Value.ToString();
                    this.txt_price.Text        = temp.Cells[2].Value.ToString();
                    this.txt_qte.Text          = temp.Cells[3].Value.ToString();                    
                    this.txt_amout.Text        = temp.Cells[4].Value.ToString();
                    this.txt_discount.Text     = temp.Cells[5].Value.ToString();
                    this.txt_total_amout.Text  = temp.Cells[6].Value.ToString();
                    dgv_products.Rows.Remove(dgv_products.CurrentRow);
                    txt_qte.Focus();
                }

            else
                    MessageBox.Show("هناك بيانات يتم العمل عليها الان ", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }  catch { return; }
        }

        private void dgv_products_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calaculate_Total_of_Totals();
        }

       




        private void Tsm_update_Click(object sender, EventArgs e)
        {
            dgv_products_DoubleClick(sender, e);
        }

        private void Tsm_delete_current_row_Click(object sender, EventArgs e)
        {
            if (dgv_products.CurrentRow != null)
                dgv_products.Rows.Remove(dgv_products.CurrentRow);

            else
             MessageBox.Show("قم بتحديد صف أولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Tsm_delete_all_rows_Click(object sender, EventArgs e)
        {
            for (int i = dgv_products.Rows.Count - 2; i >= 0; i--)
                dgv_products.Rows.RemoveAt(i);

            //dt.Clear();
            //dgv_products.Refresh();
        }

        private void txt_amout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



