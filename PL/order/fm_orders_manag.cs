using SuperMarket.BL;
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
    public partial class fm_orders_manag : Form
    {
        BL.cls_orders myorder = new BL.cls_orders();
        public fm_orders_manag()
        {
            InitializeComponent();
            this.dgv_orders_list.DataSource = myorder.search_order("");
            this.dgv_orders_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgv_orders_list.RowTemplate.Height = 35;
            this.dgv_orders_list.DefaultCellStyle.Padding = new Padding(3, 3, 3, 3);
        }







        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgv_orders_list.DataSource = myorder.search_order(txt_search.Text);
            }

            catch { return; }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void but_display_one_order_Click(object sender, EventArgs e)
        {

            if (dgv_orders_list.CurrentRow.IsNewRow == false)
            {
            int order_id = Convert.ToInt16(dgv_orders_list.CurrentRow.Cells[0].Value);
                this.Cursor = Cursors.WaitCursor;
                PR.rpt_orders myreport = new PR.rpt_orders();
                myreport.SetDataSource(myorder.get_order_details(order_id));
                PR.fm_reports myform = new PR.fm_reports();
                myform.crystalReportViewer1.ReportSource = myreport;
                myform.ShowDialog();
                this.Cursor = Cursors.Default;
            }

            else
                MessageBox.Show("قم بتحديد صف أولا", "تنبيه",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
