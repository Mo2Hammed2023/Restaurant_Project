
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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;

namespace SuperMarket.PL
{
    public partial class products_Form : Form
    {
        BL.cls_product prd = new BL.cls_product();
        private static products_Form pForm;

        static void pForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pForm = null;
        }


        public static products_Form getMainForm
        {
            get
            {
                if (pForm == null)
                {
                    pForm = new products_Form();
                    pForm.FormClosed += new FormClosedEventHandler(pForm_FormClosed);
                }
                return pForm;
            }
        }


        public products_Form()
        {
            InitializeComponent();
            if (pForm == null)
                pForm = this;
            this.TransparencyKey = Color.Empty;

            //this.PR_dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this.PR_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //this.PR_dgv.RowTemplate.Height = 35;
            //this.PR_dgv.DefaultCellStyle.Padding = new Padding(1, 5, 1, 5);
            //this.PR_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.PR_dgv.GridColor = Color.LightGray;
            this.PR_dgv.DataSource = prd.get_All_product();
        }



        private void search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.searchProduct(search.Text);
            this.PR_dgv.DataSource=dt;  
        }

        private void btn_Manage_ANP_Click(object sender, EventArgs e)
        {
            fm_add_product apf = new fm_add_product();
            apf.ShowDialog();
            this.PR_dgv.DataSource = prd.get_All_product();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (PR_dgv.CurrentRow == null)
            {
                MessageBox.Show("يرجى تحديد منتج أولا قبل الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            else if (PR_dgv.CurrentRow != null)
                if (MessageBox.Show("هل تريد فعلا حذف المنتج المحدد ؟", "عملية الحذف ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string Id = this.PR_dgv.CurrentRow.Cells[0].Value?.ToString() ?? "";

                    if (Id == "")
                        return;
                    
                    prd.delete_product(Id);
                    MessageBox.Show("تمت عملية الحذف بنجاح ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.PR_dgv.DataSource = prd.get_All_product();
                }
        }


    private void pf_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            fm_add_product apf    = new fm_add_product();
            apf.txtId.Text        = this.PR_dgv.CurrentRow.Cells[0].Value.ToString();
            apf.txt_dec.Text      = this.PR_dgv.CurrentRow.Cells[1].Value.ToString();
            apf.txtQte.Text       = this.PR_dgv.CurrentRow.Cells[2].Value.ToString();
            apf.txt_Price.Text    = this.PR_dgv.CurrentRow.Cells[3].Value.ToString();
            apf.cb_category.Text  = this.PR_dgv.CurrentRow.Cells[4].Value.ToString();
            apf.Text ="تحديث المنتج : " + this.PR_dgv.CurrentRow.Cells[1].Value.ToString();
            apf.btn_Add.Text = "تحديث";
            apf.state = "Update";
            apf.txtId.ReadOnly = true;
            string Id = this.PR_dgv.CurrentRow.Cells[0].Value?.ToString()??"";

            if (Id == "")
            {
                MessageBox.Show("there is no product ");
                return;
            }

            var dt = prd.get_product_Image(Id);
            if (dt.Rows.Count != 0 && dt.Rows[0][0] != DBNull.Value)
            {
                byte[] image = (byte[])prd.get_product_Image(Id).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                apf.pb_pr_Image.Image = Image.FromStream(ms);
            }
            
           apf.ShowDialog();


        }

        private void btn_product_Image_Click(object sender, EventArgs e)
        {
            string Id = this.PR_dgv.CurrentRow.Cells[0].Value?.ToString()??"";
            if (Id == "")
                return;


            var dt = prd.get_product_Image(Id);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] ==DBNull.Value)
            {
                MessageBox.Show("لم تقم بإرفاق صورة مسبقا  ", "عرض صورة");
                return;
            }

                byte[] image =(byte[]) dt.Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                Image_display im = new Image_display();
                im.view_Image_PB.Image = Image.FromStream(ms);
                im.ShowDialog();
          
        }

        private void btn_display_one_product_Click(object sender, EventArgs e)
        {
            PR.rpt_single_product myreport = new PR.rpt_single_product();
            myreport.SetParameterValue("@Id", this.PR_dgv.CurrentRow.Cells[0].Value.ToString());
            PR.fm_reports myreportform = new PR.fm_reports();
            myreportform.crystalReportViewer1.ReportSource = myreport;
            myreportform.ShowDialog();  
        }

        private void btn_display_all_products_Click(object sender, EventArgs e)
        {
           PR.rpt_products myReport = new PR.rpt_products();
            PR.fm_reports myform = new PR.fm_reports();
            myform.crystalReportViewer1.ReportSource = myReport;
            myform.ShowDialog();
        }

        private void btn_save_exl_Click(object sender, EventArgs e)
        {
            PR.rpt_products myreport = new PR.rpt_products();
            ExportOptions export = new ExportOptions();

            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;

            ExcelFormatOptions excelFormat = new ExcelFormatOptions();
            export.ExportFormatOptions = excelFormat;

            DiskFileDestinationOptions distkfile = new DiskFileDestinationOptions();
            distkfile.DiskFileName = @"D:\ProductsList.xls";
            export.ExportDestinationOptions = distkfile;

            myreport.Export();
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
