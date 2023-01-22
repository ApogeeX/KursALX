using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace ADODemoConsoleApp
{
    public class ADODemo
    {
        private string _connectionString;

        public ADODemo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RunSelectAllFromEmployees()
        {
            var queryString = "select * from employees";

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try 
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}, {sqlDataReader[2]}, {sqlDataReader[3]}, {sqlDataReader[4]}");
                    }
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public void RunSelectDefinedColumnSet(string column1, string column2)
        {
            var queryString = $"select {column1}, {column2}, email from employees";

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}");
                    }
              
            }
        }
    }
}
