using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Windows.Forms;

namespace Authorization
{
    static class Query
    {
        static private SqlConnection sqlConnection;

        static public bool Check(string userLogin, string userPassword)
        {
            try
            {
                sqlConnection = new SqlConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["Registration"].ConnectionString
                };

                string query = "SELECT COUNT(*) FROM USERS   WHERE name = '" + userLogin + "' AND password = '" + userPassword + "'";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                if (reader[0].ToString() == "1")
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        static public void Update(string userEmail, string userPassword)
        {
            try
            {
                sqlConnection = new SqlConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["Registration"].ConnectionString
                };

                string query = "UPDATE Users SET Password='" + userPassword + "' WHERE Id=(SELECT id FROM Users WHERE Email='" + userEmail + "')";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
