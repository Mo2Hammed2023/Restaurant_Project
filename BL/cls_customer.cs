using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarket.BL
{
    internal class cls_customer
    {


        public SqlParameter[] Fill_data(string first_name, string last_name, string tel, string email,
         byte[] customer_image, int id = 0)
         {
            List<SqlParameter> param = new List<SqlParameter>();

            param.Add(Program.CreateParam("@first_name", SqlDbType.VarChar, first_name, 25));
            param.Add(Program.CreateParam("@last_name", SqlDbType.VarChar, last_name, 25));
            param.Add(Program.CreateParam("@tel", SqlDbType.NChar, tel, 10));
            param.Add(Program.CreateParam("@email", SqlDbType.VarChar, email, 25));
            param.Add(Program.CreateParam("@customer_image", SqlDbType.Image, customer_image));

            if (id > 0)
            {
                param.Add(Program.CreateParam("@id", SqlDbType.Int, id));
            }
            return param.ToArray();
         }


        public DataTable search_customer( string text )
        {  
            return Program.dal.select("search_customer", new[]
            { Program.CreateParam("@text_search", SqlDbType.VarChar, text , 50) });            
        }

        public void delete_customer (int id)
        {
            Program.dal.Execute("delete_customer", new[]
              { Program.CreateParam("@id", SqlDbType.Int , id) });
        }

 

    }
}
