using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SuperMarket.PL
{
    public partial class fm_customer : Form
    {
        BL.cls_customer cust = new BL.cls_customer();
        int id, position,count;
        public fm_customer()
        {
            InitializeComponent();
            this.dgv_customer_list.RowTemplate.Height = 35;
            dgv_customer_list.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgv_customer_list.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            this.dgv_customer_list.DataSource = get_All_customers();


            dgv_customer_list.Columns[0].Visible = false;
            dgv_customer_list.Columns[5].Visible = false;
        }

    

        private void btn_add_Click(object sender, EventArgs e)
        {
         try
          {
              Program.dal.Execute("add_customer", cust.Fill_data(txt_firstName.Text, 
              txt_lastName.Text, txt_phoneNumber.Text, txt_email.Text, get_image_data()));
              MessageBox.Show("تمت عملية الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.dgv_customer_list.DataSource = get_All_customers();
            }
            catch { }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
          Program.dal.Execute("update_customer",
          cust.Fill_data(txt_firstName.Text, 
          txt_lastName.Text, txt_phoneNumber.Text, txt_email.Text,
          get_image_data(), id));
          MessageBox.Show("تمت عملية التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.dgv_customer_list.DataSource = get_All_customers();     
        }


        public byte[] get_image_data()
        {        
            if (pb_customer_image.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pb_customer_image.Image.Save(ms, pb_customer_image.Image.RawFormat);
                return ms.ToArray();
            }

            return null; }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_customer_list.SelectedRows.Count > 0)
                 {
                    if (MessageBox.Show("هل تريد فعلا حذف هذا العميل :", "عملية الحذف",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cust.delete_customer(id);
                        MessageBox.Show("تمت عملية الحذف بنجاح", "الحذف", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.dgv_customer_list.DataSource = get_All_customers();
                    }
                 }

            else
                {
                    MessageBox.Show("يجب عليك إختيار صف أولا", "الحذف", MessageBoxButtons.OK,
                     MessageBoxIcon.Stop);
                }
        }

        public DataTable get_All_customers()
        {
            return Program.dal.select("get_All_customers", null) ;          
        }


        private void pb_customer_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog temp = new OpenFileDialog();
               temp.Filter = "ملفات الصور | *.jpg; *.png; *.gif; *.bmp;";
            if (temp.ShowDialog() == DialogResult.OK)
            {
                pb_customer_image.Image = Image.FromFile(temp.FileName);
            }
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_phoneNumber.Clear();
            txt_email.Clear();
            pb_customer_image.Image = null;
            txt_firstName.Focus();
            btn_new.Enabled = false;
            btn_add.Enabled = true;
        }

      

   
        private void dgv_customer_list_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pb_customer_image.Image = null;
                var temp = dgv_customer_list.CurrentRow;
                this.id = Convert.ToInt32(temp.Cells[0].Value);
                this.txt_firstName.Text = temp.Cells[1].Value.ToString();
                this.txt_lastName.Text =  temp.Cells[2].Value.ToString();
                this.txt_phoneNumber.Text = temp.Cells[3].Value.ToString();
                this.txt_email.Text = temp.Cells[4].Value.ToString();

                if (temp.Cells[5].Value != DBNull.Value)
                {
                    byte[] picture = (byte[])dgv_customer_list.CurrentRow.Cells[5].Value;
                    MemoryStream ms = new MemoryStream(picture);
                    pb_customer_image.Image = Image.FromStream(ms);
                }


            }catch { }

       finally
            {
                btn_new.Enabled = true;
                btn_add.Enabled = false;
            }
        }



        private void txt_firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_lastName.Focus();
        }

        private void txt_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_phoneNumber.Focus();
        }

        private void txt_phoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_email.Focus();
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_add.Focus();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            dgv_customer_list.DataSource = cust.search_customer(txt_search.Text);
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_okay_Click(sender, e);
        }

        private void btn_cancel_search_Click(object sender, EventArgs e)
        {
            this.dgv_customer_list.DataSource = get_All_customers();
            txt_search.Clear();
        }


        void Navigate(int index)
        {
            pb_customer_image.Image = null;
            DataRowCollection drc = get_All_customers().Rows;
            count = drc.Count-1;
            dgv_customer_list.Rows[index].Selected = true;


            txt_firstName.Text =   drc[index][1].ToString();
            txt_lastName.Text =    drc[index][2].ToString();
            txt_phoneNumber.Text = drc[index][3].ToString();
            txt_email.Text =       drc[index][4].ToString();

            if (drc[index][5] != DBNull.Value)
            {
                byte[] picture = (byte[])drc[index][5];
                MemoryStream ms = new MemoryStream(picture);
                pb_customer_image.Image = Image.FromStream(ms);
            }

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            position = 0;
            Navigate(position);
            lab_position.Text = (1 + position) + "/" + (1+count);
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            position = count;
            Navigate(position);
            lab_position.Text = (1 + position) + "/" + (1 + count);

        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (position != 0)
            {
                Navigate(--position);
                lab_position.Text = (1 + position) + "/" + (1 + count);
                return;
            }

           MessageBox.Show("هذا هو أول عنصر");
           return;
           
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (position != count)
            {
                position += 1;
                Navigate(position);
                lab_position.Text = (1 + position) + "/" + (1 + count);
                return;
            }

                MessageBox.Show("هذا هو أخر عنصر");
                return;
 
        }

       
    }
}
