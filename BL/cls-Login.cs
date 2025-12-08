
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
    internal class cls_Login
    {

        public DataTable Login(string Id, string Pwd)
        {
          return Program.dal.select("sp_Login", new[]
            { Program.CreateParam("@ID", SqlDbType.VarChar,Id, 50),
              Program.CreateParam("@PWD ", SqlDbType.VarChar,Pwd, 50) } );
               }



        public SqlParameter[] Fill_user_data(string Id, string Pwd, string fullName, string usertype)
        {
            return new[]
            {    Program.CreateParam("@Id", SqlDbType.VarChar,Id, 50),
                 Program.CreateParam("@pwd", SqlDbType.VarChar,Pwd, 50),
                 Program.CreateParam("@Full_name", SqlDbType.VarChar,fullName, 50),
                 Program.CreateParam("@UserType", SqlDbType.VarChar,usertype, 50)
            };
        }

        public DataTable search_user(string search_text)
        {
          return Program.dal.select("search_user", new[]
           {Program.CreateParam("@search_text", SqlDbType.VarChar,search_text, 50) });
        }

        public void delete_user (string Id)
        {  
            Program.dal.Execute("delete_user", new[] 
              { Program.CreateParam("@Id", SqlDbType.VarChar, Id, 50) });           
        }

    }
}