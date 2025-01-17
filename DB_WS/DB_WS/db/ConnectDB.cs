using System;
using System.Collections.Generic;
using System.Linq;
using MySqlConnector;
using System.Web;

namespace DB_WS.DB
{
    public class ConnectDB
    {
        private static MySqlConnection connection;
        private static MySqlConnection connect(string server, string dbName, string userName, string password)
        {
            string connectionString = $"Server={server};Database={dbName};User={userName};" +
                $"Password={password};";
            connection = new MySqlConnection(connectionString);
            //connection.Open();
            return connection;
        }
        private ConnectDB()
        {
        }

        public static MySqlConnection getInstance()
        {
            if (connection == null)
                connection = connect("localhost", "world", "root", "170624");
            return connection;
        }
    }
}