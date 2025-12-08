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
    public partial class fm_customer_list : Form
    {
        fm_customer fm = new fm_customer();
        public fm_customer_list()
        {
            InitializeComponent();
            this.dgv_customers.DataSource = fm.get_All_customers();
            this.dgv_customers.Columns[0].Visible = false;
            this.dgv_customers.Columns[5].Visible = false;

            dgv_customers.RowTemplate.Height = 35;
            dgv_customers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgv_customers.GridColor = Color.LightGray;
            dgv_customers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgv_customers.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void dgv_customers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
