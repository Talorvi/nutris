using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;

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
        static string QUERY_CHECK_LOGIN = "SELECT COUNT(login) AS `liczba` FROM  `users` WHERE login LIKE '{0}'";
        static string QUERY_GET_PASSWORD = "SELECT password FROM `users` WHERE login LIKE '{0}'";

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

            //creating md5 string
            using (MD5 md5Hash = MD5.Create())
            {
                password = GetMd5Hash(md5Hash, password);
            }

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

        public bool TryToLogIn(string login, string password)
        {
            string passwordhash = "";
            //creating md5 string
            using (MD5 md5Hash = MD5.Create())
            {
                password = GetMd5Hash(md5Hash, password);
            }

            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            string polecenie = String.Format(QUERY_GET_PASSWORD, login);

            command = new MySqlCommand(polecenie, connection);

            try
            {
                connection.Open();
            }
            catch (Exception exception)
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
                        passwordhash = ReadSingleRowPassword((IDataRecord)dataReader);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                connection.Close();
            }
            if (password == passwordhash)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        private static string ReadSingleRowPassword(IDataRecord record)
        {
            return record[0].ToString();
        } 

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
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
