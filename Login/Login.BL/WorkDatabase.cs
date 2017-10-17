using Login.BL.Entity;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Login.BL
{
    public interface IWorkDatabase
    {
        void AddUser(User user);
        void UpdatePassowd(User user);
        bool IsExist(User user);
    }
    public class WorkDatabase : IWorkDatabase
    {
        private SqlConnection connection=null;
        private readonly IMessageService _messageService;
        public WorkDatabase(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void OpenConnection()
        {
            connection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["Registration"].ConnectionString
            };
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public bool IsExist(User user)
        {
            OpenConnection();
            string query = "SELECT COUNT(*) FROM USERS   WHERE name = '" + user.Login + "' AND password = '" + user.Password + "'";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                if (reader[0].ToString() == "1")
                    return true;
                return false;
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void UpdatePassowd(User user)
        {
            string query = "UPDATE Users SET Password='" + user.Password + "' WHERE Id=(SELECT id FROM Users WHERE Email='" + user.Email + "')";

            using(SqlCommand command=new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void AddUser(User user)
        {
            string query = "INSERT INTO [Users] ([Name], [Password], [Email]) VALUES ('"+user.Login+"','"+user.Password+"','"+user.Email+"')";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}