using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Base
    {
        public bool Insert(string query)
        {
            bool status = false;

            SqlConnection sqlConnection = ConnectionManager.GetInstance();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (rowsAffected > 0)
                status = true;

            return status;
        }

        public DataTable Select(string query)
        {
            SqlConnection sqlConnection = ConnectionManager.GetInstance();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            
            sqlConnection.Close();

            return dt;
        }
    }
}
