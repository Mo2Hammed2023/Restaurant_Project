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
    public partial class fm_add_user : Form
    {
        BL.cls_Login myclass = new BL.cls_Login();
        public fm_add_user()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_user_id.Text != String.Empty && txt_user_password.Text != String.Empty &&
                   txt_user_fullName.Text != String.Empty)
            {

                if (btn_save_user.Text == "حفظ")
                {
                    Program.dal.Execute("add_user", myclass.Fill_user_data(txt_user_id.Text,
                    txt_user_password.Text, txt_user_fullName.Text, cb_user_type.Text));
                    MessageBox.Show("تم إنشاء مستخدم بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (btn_save_user.Text == "تعديل")
                {
                    Program.dal.Execute("update_user", myclass.Fill_user_data(txt_user_id.Text,
                    txt_user_password.Text, txt_user_fullName.Text, cb_user_type.Text));

                    this.Close();
                    MessageBox.Show("تم تعديل المستخدم بنجاح", "التعديل", MessageBoxButtons.OK
                  , MessageBoxIcon.Information);
                }


                clear();
                return;
            }


            MessageBox.Show("ربما قد توجد حقول فارغة", "تنبيه",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void txt_password_con_Leave(object sender, EventArgs e)
        {
            if (txt_user_password.Text != txt_user_password_con.Text)
            {
                MessageBox.Show("عذرا : تأكيد كلمة المرور لا يطابق كلمة المرور المدخلة", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_user_password_con.Clear();
                txt_user_password_con.Focus();
            }
        }

        private void clear()
        {
            txt_user_id.Clear();
            txt_user_fullName.Clear();
            txt_user_password.Clear();
            txt_user_password_con.Clear();
        }

    }
}
