using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dietpolix.Classes
{
    public class DatabaseManager
    {
        static string SERVER = "sql7.freemysqlhosting.net";
        static string USER = "sql7240213";
        static string PASSWD = "z3DPKHvvTr";
        static string DATABASE = "sql7240213";
        static uint PORT = 3306;
        //static string QUERY_COUNTRIES_NAME = "SELECT name FROM country";

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
    }
}
