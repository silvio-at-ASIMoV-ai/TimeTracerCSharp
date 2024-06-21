using MySqlConnector;

namespace TimeTracerCSharp
{
    internal class DBHelper
    {
        private static string _connectionStr = "Server=192.168.1.67;User ID=silvio;Password=Twin_11_Towers;Database=TimeTracer";
        private static MySqlConnection? _connection;

        private static bool Connect()
        {
            if(_connection == null)
            {
                _connection = new MySqlConnection(_connectionStr);
                return _connection != null;
            } else
            {
                return true;
            }
        }

        public MySqlConnection? Connection => _connection;

        public static void CloseConnection()
        {
            if(_connection != null)
            {
                _connection.Close();
            }
        }

        public static MySqlDataReader? SelectQuery(string queryStr, MySqlParameter[] parms)
        {
            if(_connection == null) Connect();
            if(_connection != null)
            {
                _connection.Open();
                MySqlCommand command = new MySqlCommand(queryStr, _connection);
                foreach (MySqlParameter param in parms)
                {
                    command.Parameters.Add(param);
                }
                return command.ExecuteReader();
            } else
            {
                return null;
            }
        }

    }
}
