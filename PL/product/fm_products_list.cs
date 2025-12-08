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
    public partial class fm_products_list : Form
    {
        public fm_products_list()
        {
            InitializeComponent();
            dgv_products_list.DataSource = Program.dal.select("get_All_product", null);

            dgv_products_list.RowTemplate.Height = 35;
            dgv_products_list.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgv_products_list.GridColor = Color.LightGray;
            dgv_products_list.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgv_products_list.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void dgv_products_list_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
