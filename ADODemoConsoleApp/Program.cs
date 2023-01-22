// See https://aka.ms/new-console-template for more information
using ADODemoConsoleApp;

var connectionSting = "Data Source=EMIL\\SQLEXPRESS;Initial Catalog=company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
ADODemo demo = new ADODemo(connectionSting);

//demo.RunSelectAllFromEmployees();
//Console.WriteLine("------------------------------");
demo.RunSelectDefinedColumnSet("first_name", "last_name");
Console.WriteLine("------------------------------");