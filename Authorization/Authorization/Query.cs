using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Authorization
{
    class Query
    {
        private SqlConnection sqlConnection;

        public bool Check(string userLogin, string userPassword)
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
            sqlConnection.Close();
            return false;
           
        }
    }
}
