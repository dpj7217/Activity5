using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Activity2Part3.Services.Data
{
    public class SecurityDAO
    {
        public bool FindByUser(Activity2Part3.Models.UserModel user)
        {
            SqlConnection conn = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; database=Test; integrated security = SSPI");
            SqlCommand cmnd = new SqlCommand("SELECT * FROM Users WHERE Username = '" + user.Username + "' AND Password = '" + user.Password + "'", conn);

            conn.Open();
            SqlDataReader reader = cmnd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}