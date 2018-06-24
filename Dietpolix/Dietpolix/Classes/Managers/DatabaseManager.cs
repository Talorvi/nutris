using System;
using MySql.Data.MySqlClient;

namespace Dietpolix.Classes.Managers
{
    public class DatabaseManager
    {
        static string SERVER = "sql7.freemysqlhosting.net";
        static string USER = "sql7240213";
        static string PASSWD = "z3DPKHvvTr";
        static string DATABASE = "sql7240213";
        static uint PORT = 3306;
        //static string QUERY_ADD_USER = "SELECT name FROM country";

        private MySqlConnectionStringBuilder conStrBuilder;
        private MySqlConnection connection;
        private MySqlCommand command;

        public DatabaseManager()
        {
            conStrBuilder = new MySqlConnectionStringBuilder();
            conStrBuilder.Server = SERVER;
            conStrBuilder.UserID = USER;
            conStrBuilder.Password = PASSWD;
            conStrBuilder.Database = DATABASE;
            conStrBuilder.Port = PORT;
            conStrBuilder.SslMode = MySqlSslMode.None;
            Console.WriteLine(conStrBuilder.ConnectionString);
        }
        public void AddUser(string login, string password, string name, int sex)
        {
            string polecenie = "INSERT INTO Users VALUES (NULL, \'" + login + "\', \'" + password + "\', \'" + name + "\', " + sex + ");";
            Console.WriteLine(polecenie);
            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            command = new MySqlCommand(polecenie, connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
