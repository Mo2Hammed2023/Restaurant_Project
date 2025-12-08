using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace SuperMarket.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection sqlCon;
        SqlCommand cmd;

        //This constructor inisialize the connection object
        public DataAccessLayer()
        {
            sqlCon = new SqlConnection(
                @"Server =.\SQLEXPRESS;
                Database=SuperMarket-db;
                Integrated Security=true");
        }


        public DataTable select(string stored_procedure, SqlParameter[] param)
        {
            sqlCon.Open();
            using (cmd = new SqlCommand(stored_procedure, sqlCon))
            {
                helper(param);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlCon.Close();
                return dt;
            }
        }

        public void helper(SqlParameter[] param)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (param != null)
                cmd.Parameters.AddRange(param);
        }


        public void Execute(string stored_procedure, SqlParameter[] param)
        {
            sqlCon.Open();
            using (cmd = new SqlCommand(stored_procedure, sqlCon))
            {
                helper(param);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }


      

    }
}
