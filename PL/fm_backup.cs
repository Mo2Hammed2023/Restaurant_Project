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
    public partial class fm_backup : Form
    {
        SqlConnection backup_con = new SqlConnection(
               @"Server =.\SQLEXPRESS;
                Database=SuperMarket-db;
                Integrated Security=true");

        SqlCommand cmd;
        public fm_backup()
        {
            InitializeComponent();
            btn_browse.Focus();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txt_folder_path.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_backup_Click(object sender, EventArgs e)
        {
         if (txt_folder_path.Text != String.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                string backup_file_name = txt_folder_path.Text + "\\SuperMarket-db"
                + DateTime.Now.ToShortDateString().Replace('/', '-') + " - "
                + DateTime.Now.ToString("HH-mm-ss");

                string backup_quary = "Backup Database [SuperMarket-db] to Disk='" + backup_file_name + ".bak'";

                cmd = new SqlCommand(backup_quary, backup_con);
                backup_con.Open();
                cmd.ExecuteNonQuery();
                backup_con.Close();
                this.Cursor = Cursors.Default;


                MessageBox.Show("تم إنشاء النسخة الإحتياطية بنجاح", "إنشاء نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

               else
                MessageBox.Show("قم بتحديد مسار المجلد أولا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      
    }
}
