using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SuperMarket.PL
{
    public partial class fm_Main : Form
    {
        private static fm_Main MFI;

        static void MFI_FormClosed (object sender ,FormClosedEventArgs e)
        {
            MFI = null;
        }


        public static fm_Main getMainForm  
        {
         get
            {
                if (MFI == null)
                {
                    MFI = new fm_Main();
                    MFI.FormClosed += new FormClosedEventHandler(MFI_FormClosed);
                }
                return MFI;
            }
        }



        public fm_Main()
        {
            InitializeComponent();
            if (MFI == null)
                MFI = this;
            Enable_first_menu_strip();
            this.Load += Main_Form_Load;
        }

       

        private void Main_Form_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(225, 240, 255);
                    Image image = Image.FromFile(@"D:\MdiClientImage.jpg");
                    mdiClient.BackgroundImage = image;
                    mdiClient.BackgroundImageLayout = ImageLayout.Stretch;


                    mdiClient.Paint += (s, ev) =>
                    {
                        ev.Graphics.DrawImage(image, new Rectangle(0, 0, mdiClient.Width, mdiClient.Height));
                    };

                    mdiClient.Resize += (s, ev) => mdiClient.Invalidate();
                    break;
                }
        }



     

      

        public void Enable_menu_strip_for_manager ()
        {
            this.tsm_customer.Visible = true;
            this.tsm_products.Visible = true;
            this.tsm_user.Visible = true;
            this.tsm_create_backup.Visible = true;
            this.tsm_recover_backup.Visible = true;
            this.Tsm_log_out.Visible = true;
            this.Tsm_login.Visible = false;
        }

        public void Enable_menu_strip_for_worker()
        {
            this.tsm_customer.Visible = true;
            this.tsm_products.Visible = false;
            this.tsm_user.Visible = false;
            this.tsm_create_backup.Visible = false;
            this.tsm_recover_backup.Visible = false;       
            this.Tsm_login.Visible = false;
            this.Tsm_log_out.Visible = true;
            this.Tsm_sales_managment.Visible = false;

        }

        private void Enable_first_menu_strip ()
        {
            this.tsm_customer.Visible = false;
            this.tsm_products.Visible = false;
            this.tsm_user.Visible = false;
            this.tsm_create_backup.Visible = false;
            this.tsm_recover_backup.Visible = false;
            this.Tsm_log_out.Visible = false;
            this.Tsm_login.Visible = true;
        }



        private void Add_new_product_MS_Click(object sender, EventArgs e)
        {
            fm_add_product apf = new fm_add_product();
            apf.ShowDialog();
        }

        private void Mpro_MS_Click(object sender, EventArgs e)
        {
            products_Form pf = new products_Form();
            pf.ShowDialog();
        }

        private void MS_category_managment_Click(object sender, EventArgs e)
        {
            fm_categories fm = new fm_categories();
            fm.ShowDialog();
        }

        private void MS_customers_Managment_Click(object sender, EventArgs e)
        {
            fm_customer myform = new fm_customer();
            myform.ShowDialog();    
        }

        private void Tsm_add_new_sale_operation_Click(object sender, EventArgs e)
        {
            fm_orders fm = new fm_orders();
            fm.ShowDialog();
        }

        private void Tsm_sales_managment_Click(object sender, EventArgs e)
        {
            fm_orders_manag fm = new fm_orders_manag();
            fm.ShowDialog();
        }

        private void Tsm_log_out_Click(object sender, EventArgs e)
        {
            Enable_first_menu_strip();
        }

        private void Tsm_login_Click(object sender, EventArgs e)
        {
            fm_login LF = new fm_login();
            LF.ShowDialog();
        }

        private void Tsm_add_user_Click(object sender, EventArgs e)
        {
            fm_add_user fm = new fm_add_user();
            fm.ShowDialog();
        }

        private void Tsm_users_managment_Click(object sender, EventArgs e)
        {
            fm_users_list fm = new fm_users_list();
            fm.ShowDialog();
        }

        private void tsm_create_backup_Click(object sender, EventArgs e)
        {
            fm_backup fm = new fm_backup();
            fm.ShowDialog();
        }

        private void tsm_recover_backup_Click(object sender, EventArgs e)
        {
            fm_restore_backup fm = new fm_restore_backup();
            fm.ShowDialog();
        }
    }
}
