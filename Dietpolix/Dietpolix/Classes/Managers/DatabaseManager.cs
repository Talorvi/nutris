using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dietpolix.Classes.Managers
{
    public class DatabaseManager
    {
        static string SERVER = "localhost";
        static string USER = "root";
        static string PASSWD = "";
        static string DATABASE = "dietpolix_db";
        static uint PORT = 3306;

        static string QUERY_ADD_USER = "INSERT INTO `users` (`user_id`, `login`, `password`, `name`, `sex`) VALUES (NULL, '{0}', '{1}', '{2}', NULL);";
        static string QUERY_CHECK_LOGIN = "SELECT COUNT(login) AS `liczba` FROM  `users` WHERE login LIKE \'{0}\'";

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
            Console.WriteLine(conStrBuilder.ConnectionString);
        }
        public bool TryToAddUser(string login, string password, string name, int sex)
        {
            bool canadd = false;

            string polecenie = String.Format(QUERY_ADD_USER, login, password, name);
            connection = new MySqlConnection(conStrBuilder.ConnectionString);

            command = new MySqlCommand(polecenie, connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                canadd = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                canadd = false;
            }
            finally
            {
                connection.Close();
            }
            return canadd;
        }

        public bool CheckIfLoginExists(string login)
        {
            int countLogins = 0;

            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            string polecenie = String.Format(QUERY_CHECK_LOGIN, login);

            command = new MySqlCommand(polecenie, connection);

            try
            {
                connection.Open();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                MySqlDataReader dataReader = command.ExecuteReader();
                try
                {
                    while (dataReader.Read())
                    {
                        countLogins = ReadSingleRowCheckLogin((IDataRecord)dataReader);
                        Console.WriteLine(countLogins);
                    }
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                connection.Close();
            }

            if (countLogins != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int ReadSingleRowCheckLogin(IDataRecord record)
        {
            string str = record[0].ToString();
            return Convert.ToInt32(str);
        }
    }
}
