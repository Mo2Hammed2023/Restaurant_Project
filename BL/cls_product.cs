using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace SuperMarket.BL
{
    internal class cls_product
    {


     public DataTable get_All_cateogries()
      {      
            return Program.dal.select("get_All_cateogries" , null);         
      }

      public void Add_product_data (int id_cat , string Id_product, string label_product
          , string price , int qte_in_stock, byte [] Image_product)
                    {           
            Program.dal.Execute("add_product", Fill_data(id_cat, label_product, Id_product, price, qte_in_stock, Image_product));       
                    }


        public void update_data(int id_cat, string label_product, string Id_product,
           string price, int qte_in_stock, byte[] Image_product)
        {
            Program.dal.Execute("update_product", Fill_data(id_cat, label_product, Id_product, price, qte_in_stock, Image_product));
        }


        public SqlParameter [] Fill_data (int id_cat, string label_product, 
            string Id_product, string price, int qte_in_stock, byte[] Image_product)
        {
            return new[]
           {
                Program.CreateParam("@id_cat", SqlDbType.Int, id_cat),
                Program.CreateParam("@id_product", SqlDbType.VarChar,Id_product,30),
                Program.CreateParam("@label_product", SqlDbType.VarChar,label_product,30),
                Program.CreateParam("@qte_in_stock", SqlDbType.Int, qte_in_stock),
                Program.CreateParam("@price", SqlDbType.VarChar,price, 20),
                Program.CreateParam("@Image_product", SqlDbType.Image,Image_product)
            };
        }


        public DataTable VerifyProductId(string Id)
        {  
          return Program.dal.select("VarifyProductId", new[]
          { Program.CreateParam("@Id", SqlDbType.VarChar,Id, 30) });
        }

        public DataTable searchProduct(string Id)
        {
         return Program.dal.select("search_Product", new[]
          { Program.CreateParam("@Id", SqlDbType.VarChar,Id, 30) }); ;
        }



        public DataTable get_product_Image(string Id)
        {
          return Program.dal.select("get_product_Image", new[]
          { Program.CreateParam("@Id", SqlDbType.VarChar,Id, 30) }); ;
        }


        public DataTable get_All_product()
        {
            return Program.dal.select("get_All_product", null);
     }

        public void delete_product (string Id)
        {  
            Program.dal.Execute("delete_product", new[]
              { Program.CreateParam("@Id", SqlDbType.VarChar,Id, 30) });
       }
    }
}
