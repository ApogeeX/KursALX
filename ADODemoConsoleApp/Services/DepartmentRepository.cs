
using ADODemoConsoleApp.Models;
using System.Data.SqlClient;

namespace ADODemoConsoleApp.Services
{
    public class DepartmentRepository
    {
        private string _connectionString;

        public DepartmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertDepartmentToDB(Department department)
        {
            var queryString = "insert into departments(id, department_name) " +
                "values(@id, @name)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", department.Id.ToString());
                command.Parameters.AddWithValue("@name", department.DepartmentName);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    Console.Write(ex.StackTrace);
                }
                finally { connection.Close(); }

            }
        }

        public List<Department> GetAllDepartments() 
        {
            var departments = new List<Department>();
            var queryString = "select * from departments";

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var department = new Department
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            DepartmentName = sqlDataReader[1].ToString(),
                        };
                        departments.Add(department);

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

            return departments;
        }

        public Department GetById(Guid id)
        {
            var queryString = "select * from departments where departments.id=@id";
            var departments = new List<Department>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                sqlCommand.Parameters.AddWithValue("@id", id.ToString());
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var department = new Department
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            DepartmentName = sqlDataReader[1].ToString(),
                        };
                        departments.Add(department);
                    }
                    sqlDataReader.Close();
                    return departments.FirstOrDefault();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    throw;
                }
                finally { connection.Close(); }
            }
        }
    }
}
