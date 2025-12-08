using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SuperMarket.PL
{
    public partial class fm_categories : Form
    {
        SqlConnection category_con = new SqlConnection(
                @"Server =.\SQLEXPRESS;
                Database=SuperMarket-db;
                Integrated Security=true");

        SqlDataAdapter sda;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder sqlcb;
    
        string x = "select [ID-CAT] as 'معرف الصنف', [DESCRPITION-CAT] as 'وصف الصنف' from Category";
        public fm_categories()
        {
            InitializeComponent();

            sda = new SqlDataAdapter(x, category_con);
            sda.Fill(dt);
            this.dgv_cat_lists.DataSource = dt;
            this.txt_id.DataBindings.Add("text", dt, "معرف الصنف");
            this.txt_desc.DataBindings.Add("text", dt, "وصف الصنف");
            bmb = this.BindingContext[dt];
            lab_position.Text = (1+bmb.Position) + "/" + bmb.Count;
        }

        
         private void btn_new_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btn_new.Enabled = false;
            btn_add.Enabled = true;
            int id = Convert.ToInt16( dt.Rows[dt.Rows.Count - 1][0])+1;
            txt_id.Text = id.ToString();
            txt_desc.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         if (txt_desc.Text != String.Empty)
            {
                bmb.EndCurrentEdit();
                sqlcb = new SqlCommandBuilder(sda);
                sda.Update(dt);
                MessageBox.Show("لقد تم إضافة الصنف بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_add.Enabled = false;
                btn_new.Enabled = true;
                lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
                return;
            }
        MessageBox.Show("لقد بتعبئة وصف الصنف اولا", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txt_desc.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position); 
            bmb.EndCurrentEdit();
            sqlcb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("category deleted successFully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            update_label_count();

        }

        public void update_label_count ()
        {
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            sqlcb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("category edited successFully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }









        private void close_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }

       

        private void btn_print_all_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            PR.rpt_categories myreport = new PR.rpt_categories();
            PR.fm_reports myform = new PR.fm_reports();
            myreport.Refresh();
            myform.crystalReportViewer1.ReportSource = myreport;
            this.Cursor = Cursors.Default;
            myform.ShowDialog();
        }

        private void btn_print_single_Click(object sender, EventArgs e)
        {
            PR.rpt_single_cat myreport = new PR.rpt_single_cat();
            PR.fm_reports myform = new PR.fm_reports();
            myreport.SetParameterValue("@Id", Convert.ToInt32(txt_id.Text));
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }


        private void btn_exportAll_to_pdf_Click(object sender, EventArgs e)
        {
            PR.rpt_categories myreport = new PR.rpt_categories();
            ExportOptions export = new ExportOptions();

            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            export.ExportFormatOptions = pdfFormat;

            DiskFileDestinationOptions distkfile = new DiskFileDestinationOptions();
            distkfile.DiskFileName = @"D:\Categories List.pdf";
            export.ExportDestinationOptions = distkfile;
            myreport.Refresh();
            myreport.Export();
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_products_of_category_save_to_pdf_Click(object sender, EventArgs e)
        {
            PR.rpt_single_category myreport = new PR.rpt_single_category();
            ExportOptions export = new ExportOptions();

            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            export.ExportFormatOptions = pdfFormat;

            DiskFileDestinationOptions distkfile = new DiskFileDestinationOptions();
            distkfile.DiskFileName = @"D:\Category_products List.pdf";
            export.ExportDestinationOptions = distkfile;

            myreport.SetParameterValue("@Id", Convert.ToInt32(txt_id.Text));
            myreport.Export();
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_cat_lists_CurrentCellChanged(object sender, EventArgs e)
        {
            lab_position.Text = (1 + bmb.Position) + "/" + bmb.Count;
        }
    }
}
