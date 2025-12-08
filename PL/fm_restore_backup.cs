using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.PL
{
    public partial class fm_restore_backup : Form
    {
        SqlConnection backup_con = new SqlConnection(
               @"Server =.\SQLEXPRESS;
                Database = master;
                Integrated Security=true");

        SqlCommand cmd;
        public fm_restore_backup()
        {
            InitializeComponent();
            btn_browse.Focus();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_file_Name.Text = openFileDialog1.FileName;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_restore_backup_Click(object sender, EventArgs e)
        {
            if (txt_file_Name.Text != String.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                string backup_quary = "ALTER Database [SuperMarket-db] SET OFFLINE WITH ROLLBACK IMMEDIATE; " +
             "Restore Database [SuperMarket-db] from Disk='" + txt_file_Name.Text + "'";

                cmd = new SqlCommand(backup_quary, backup_con);
                backup_con.Open();
                cmd.ExecuteNonQuery();
                backup_con.Close();
                this.Cursor = Cursors.Default;
                MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح", "إستعادة نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
                MessageBox.Show("قم بتحديد مسار الملف أولا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        


    }
}
