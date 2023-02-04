using InvoicesApp.Models;
using System.Data.SqlClient;

namespace InvoicesApp.Services
{
    public class InvoiceRepository
    {
        private string _connectionString;

        public InvoiceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertInvoiceToDb(Invoice invoice)
        {
            var queryString = "insert into invoices(seriesnumber, clientcompanyname, clientnip, username, userlastname, amount) " +
                "values(@series, @clientcompanyname, @clientnip, @username, @userlastname, @amount)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@series", invoice.SeriesNumber);
                command.Parameters.AddWithValue("@clientcompanyname", invoice.ClientCompanyName);
                command.Parameters.AddWithValue("@clientnip", invoice.ClientNIP);
                command.Parameters.AddWithValue("@username", invoice.UserName);
                command.Parameters.AddWithValue("@userlastname", invoice.UserLastName);
                command.Parameters.AddWithValue("@amount", invoice.Amount);

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

            }
        }

    }

    
}
