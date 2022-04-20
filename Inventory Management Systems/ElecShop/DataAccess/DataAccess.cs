using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ElecShop.DataAccess
{
    public class DataAccess
    {
        SqlConnection con;
        SqlCommand command;
        public DataAccess()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ElecShop"].ConnectionString);
            con.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            con.Close();
        }
    }
}
