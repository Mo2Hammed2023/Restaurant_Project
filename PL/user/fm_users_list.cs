using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperMarket.PL
{
    public partial class fm_users_list : Form
    {
        BL.cls_Login myclass = new BL.cls_Login();

        public fm_users_list()
        {
            InitializeComponent();
            dgv_users_list.DataSource = myclass.search_user("");

            this.dgv_users_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgv_users_list.RowTemplate.Height = 35;
            this.dgv_users_list.DefaultCellStyle.Padding = new Padding(3, 3, 3, 3);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_users_list.DataSource = myclass.search_user(txt_search.Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            fm_add_user fm = new fm_add_user();
            fm.btn_save_user.Text = "إضافة";
            dgv_users_list.DataSource = myclass.search_user("");
            fm.ShowDialog();
            
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
        if (!dgv_users_list.CurrentRow.IsNewRow)
            {
                fm_add_user fm = new fm_add_user();
                fm.txt_user_id.Text = dgv_users_list.CurrentRow.Cells[0].Value.ToString();
          fm.txt_user_password.Text = dgv_users_list.CurrentRow.Cells[1].Value.ToString();
      fm.txt_user_password_con.Text = dgv_users_list.CurrentRow.Cells[1].Value.ToString();
               fm.cb_user_type.Text = dgv_users_list.CurrentRow.Cells[2].Value.ToString();
          fm.txt_user_fullName.Text = dgv_users_list.CurrentRow.Cells[3].Value.ToString();

                fm.btn_save_user.Text = "تعديل";
                fm.ShowDialog();
                dgv_users_list.DataSource = myclass.search_user("");              
            }

            else
          MessageBox.Show(": قم بتحديد مستخدم أولا", "تنبيه",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            if (dgv_users_list.CurrentRow.Cells[3].Value.ToString() != Program.user_name)
            {
                if (!dgv_users_list.CurrentRow.IsNewRow)
                {
                    if (MessageBox.Show("هل تريد فعلا حذف المستخدم ؟", "حذف مستخدم", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        myclass.delete_user(dgv_users_list.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show(": لقد تمت عملية الحذف بنجاح", "حذف مستخدم",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_users_list.DataSource = myclass.search_user("");
                       
                    }

                }

                else
                    MessageBox.Show(": قم بتحديد مستخدم أولا", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show(": لا يمكن حذف المستخدم الذي دخلت من خلاله", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btn_display_worker_Click(object sender, EventArgs e)
        {

        }

        private void btn_display_all_workers_Click(object sender, EventArgs e)
        {

        }
    }
}
