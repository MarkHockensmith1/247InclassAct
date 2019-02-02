using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity3.Services.Business.Data
{
    public class SecurityDAO
    {

        string connString = "Data Source=(localdb)\\MSSQLLocalDB; initial catalog = Test; Integrated Security = True;";


        public bool FindByUser(UserModel user)
        {

            bool result = true;
            try
            {

                string query = "SELECT * FROM dbo.Users WHERE USERNAME=@Username AND PASSWORD=@Password";
                using (SqlConnection cn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Set query parameters and their values
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = user.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = user.Password;

                    // Open the connection
                    cn.Open();

                    // Using a DataReader see if query returns any rows
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        result = true;
                    else
                        result = false;

                    // Close the connection
                    cn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
    }
}