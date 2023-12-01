using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practice
{
    internal class Database
    {
        private static string con_str = "Data Source=172.21.185.94;Initial Catalog=gamemario;User ID=SA;Password=@Kimyen2004";
        private static SqlConnection connection;
        private static SqlCommand command;
        public static SqlConnection CreateConnection()
        {
            try
            {
                connection = new SqlConnection(con_str);
                connection.Open();
            }
            catch
            {
                connection = null;
            }
            return connection;
        }
        public static SqlCommand CreateCommand(string commandtext, SqlConnection connection)
        {
            try
            {
                command = new SqlCommand(commandtext, CreateConnection());
            }
            catch
            {
                command = null;
            }
            return command;
        }
        public static DataTable SelectQuery(string sql)
        {
            command = CreateCommand(sql, null);
            SqlDataAdapter adt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            command.Dispose();
            adt.Dispose();
            return dt;
        }
    }
}
