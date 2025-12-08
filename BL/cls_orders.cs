using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SuperMarket.BL
{
    internal class cls_orders
    {

        public SqlParameter[] Fill_order_data(
            int id_order, DateTime date_order, int customer_id,
            string description_order, string salesMan)
        {
            return new[]
            {
                Program.CreateParam("@id_order", SqlDbType.Int, id_order),
                Program.CreateParam("@date_order", SqlDbType.DateTime, date_order),
                Program.CreateParam("@customer_id", SqlDbType.Int, customer_id),
                Program.CreateParam("@description_order", SqlDbType.VarChar, description_order, 250),
                Program.CreateParam("@salesMan", SqlDbType.VarChar, salesMan, 75)
            };
        }


        public SqlParameter[] Fill_order_details_data(
        string Id_product, int id_order, int qte,
        string order_price, string Amount, float discount, string Total_amount)
        {
            return new[]
            {
                Program.CreateParam("@Id_product", SqlDbType.VarChar, Id_product, 30),
                Program.CreateParam("@id_order", SqlDbType.Int, id_order),
                Program.CreateParam("@qte", SqlDbType.Int, qte),
                Program.CreateParam("@order_price", SqlDbType.VarChar, order_price, 50),
                Program.CreateParam("@Amount", SqlDbType.VarChar, Amount, 50),
                Program.CreateParam("@discount", SqlDbType.Float, discount),
                Program.CreateParam("@Total_amount", SqlDbType.VarChar, Total_amount, 50)
            };
        }


        public DataTable verify_qte (string product_id , int qte)
        {
            return Program.dal.select("verify_qte", new []
            {   Program.CreateParam("@id_product", SqlDbType.VarChar,product_id, 30),
                Program.CreateParam("@qte_entered", SqlDbType.Int , qte)
            });
        }


        public DataTable get_order_details(int order_id)
        {
            return Program.dal.select("get_order_details",new[]
            { Program.CreateParam("@id_order", SqlDbType.Int ,order_id) }
           );         
        } 

        public DataTable search_order(string search_text)
        {
          return Program.dal.select("search_order", new[]
            { Program.CreateParam("@search_text", SqlDbType.Int ,search_text , 50) });
        }

    }
}
