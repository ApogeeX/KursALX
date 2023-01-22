using ADODemoConsoleApp.Models;
using ADODemoConsoleApp.Services;
using System;
using System.Data.SqlClient;

namespace ADODemoConsoleApp
{
    public class ADODemo
    {
        private string _connectionString;
        private EmployeeRepository _companyDbRepository;

        public ADODemo(string connectionString)
        {
            _connectionString = connectionString;
            _companyDbRepository = new EmployeeRepository(connectionString);
        }

        public void RunSelectAll()
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
                    sqlDataReader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }
        }

        public void RunSelectDefinedColumnSet(string param1, string param2)
        {
            var queryString = $"select {param1}, {param2} from employees";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    var sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}");
                    }
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }
        }

        public void InsertEmployeeDemo()
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Andrzej",
                LastName = "Pandrzej",
                Email = "ap@gmail.com",
                DepartmentId = Guid.Parse("8D1EE091-EFC7-411C-B7B4-74D4A6ACE180")
            };

            _companyDbRepository.InsertEmployeeToDb(employee);
            RunSelectAll();
        }

        public void InsertManyEmployeesDemo()
        {
            var employeeList = new List<Employee>();
            var random = new Random();

            string[] names = { "Michał", "Andrzej", "Marcin", "Monika" };
            string[] lastNames = { "Kowalski", "Nowak", "Miau", "Hau" };

            for (int i = 0; i < 100; i++)
            {
                employeeList.Add(new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = names[random.NextInt64(0, 4)],
                    LastName = lastNames[random.NextInt64(0, 4)],
                    Email = names[random.NextInt64(0, 4)] + random.NextInt64().ToString() + "@gmail.com",
                    DepartmentId = Guid.Parse("8D1EE091-EFC7-411C-B7B4-74D4A6ACE180")
                });
                Console.WriteLine("Employee created...");
            }
            
            foreach (var employee in employeeList)
                {
                    _companyDbRepository.InsertEmployeeToDb(employee);
                    Console.WriteLine("Employee inserted...");
                }
        }
    }
}