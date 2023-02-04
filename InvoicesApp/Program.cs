using InvoicesApp;

var connectionString = "Data Source=EMIL\\SQLEXPRESS;Initial Catalog=InvoiceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
ADOInvoice invoice = new ADOInvoice(connectionString);

//Console.WriteLine("--------------------------------");
//invoice.RunSelectAll();
Console.WriteLine("--------------------------------");
invoice.InsertInvoice();