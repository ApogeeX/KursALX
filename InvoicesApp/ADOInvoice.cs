using System.Data.SqlClient;
using InvoicesApp.Models;
using InvoicesApp.Services;

namespace InvoicesApp
{
    internal class ADOInvoice
    {
        private string _connectionString;
        private InvoiceRepository _companyDbRepository;

        public ADOInvoice(string connectionString)
        {
            _connectionString = connectionString;
            _companyDbRepository = new InvoiceRepository(connectionString);
        }

        public void RunSelectAll()
        {
            var queryString = "select * from Invoices";

            using (var connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}, {sqlDataReader[2]}, {sqlDataReader[3]}, {sqlDataReader[4]}, {sqlDataReader[5]}, {sqlDataReader[6]}");
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

        public void InsertInvoice()
        {
            var invoice = new Invoice
            {
                SeriesNumber = "FV 2574/02/2023",
                ClientCompanyName = "Amazon.de",
                ClientNIP = "DE2584585963",
                UserName = "Emil",
                UserLastName = "Pałczyński",
                Amount = 524.30,
            };

            _companyDbRepository.InsertInvoiceToDb(invoice);
            RunSelectAll();
        }
    }
}
