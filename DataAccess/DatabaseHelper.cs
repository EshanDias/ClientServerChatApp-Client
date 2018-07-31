using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DatabaseHelper : Base
    {
        public bool InsertUser(User user)
        {
            bool status = false;

            string query = "INSERT INTO [dbo].[User] (FirstName, LastName, Email, Username, Password) " +
                $"VALUES ('{user.FirstName}','{user.LastName}','{user.Email}','{user.Username}','{user.Password}')";

            status = Insert(query);

            return status;
        }

        public bool ValidateLogin (string username, string password)
        {
            bool status = false;

            string query = $"SELECT * FROM [dbo].[User] WHERE Username = '{username}' AND Password = '{password}'";

            DataTable dt = Select(query);

            if (dt.Rows.Count > 0)
            {
                status = true;
            }

            return status;
        }
    }
}
