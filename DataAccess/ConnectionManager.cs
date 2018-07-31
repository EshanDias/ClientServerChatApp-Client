using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ConnectionManager
    {
        private static SqlConnection sqlConnection;

        public static SqlConnection GetInstance()
        {
            if (sqlConnection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                sqlConnection = new SqlConnection(connectionString);

                return sqlConnection;
            }
            else
            {
                return sqlConnection;
            }
        }

        //public static bool OpenConnection(SqlConnection sqlConnection)
        //{
        //    sqlConnection.Open();

        //    if (sqlConnection.State == System.Data.ConnectionState.Open)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool CloseConnection(SqlConnection sqlConnection)
        //{
        //    sqlConnection.Close();

        //    if (sqlConnection.State == System.Data.ConnectionState.Closed)
        //        return true;
        //    else
        //        return false;
        //}

    }
}
