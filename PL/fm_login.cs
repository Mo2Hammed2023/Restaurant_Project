using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.PL
{
    public partial class fm_login : Form
    {
        BL.cls_Login log = new BL.cls_Login();
        public fm_login()
        {
            InitializeComponent();
            txt_userName.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt = log.Login(txt_userName.Text, txt_password.Text);
           
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.user_name = dt.Rows[0]["Full_name"].ToString();
                if (dt.Rows[0][2].ToString() == "مدير")
                {
                    fm_Main.getMainForm.Enable_menu_strip_for_manager();
                }

                else
                    fm_Main.getMainForm.Enable_menu_strip_for_worker();


            }
            else
             MessageBox.Show("قد يكون هناك خطأ في إسم المستخدم أو كلمة المرور ");
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_userName.Clear();
            txt_password.Clear();
        }

        private void txt_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
                e.SuppressKeyPress = true;
            }
              
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();
                e.SuppressKeyPress = true;
            }

        }
    }
}
