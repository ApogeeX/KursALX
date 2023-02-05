using HttpClientShowcase;
using HttpClientShowcase.Models;

Console.WriteLine("Http Client App...");
Console.WriteLine();
var serializationDemo = new SerializationDemo();
//var jsonStrings = serializationDemo.RunSerialization();
//serializationDemo.RunDeserialization(jsonStrings);

var client = new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
var httpClientApp = new HttpClientApp(client);
//var hello = await httpClientDemo.Hello("Emil");
//Console.WriteLine(hello);
//await httpClientDemo.GetRandomJoke();
//Console.WriteLine();
//await httpClientDemo.GetRandomCatInfo();
//Console.WriteLine();
//await httpClientDemo.GetRandomDogImage();
//await httpClientDemo.PredictGender("Me");
await httpClientApp.BoredApi();
Console.WriteLine();
await httpClientApp.Herokuapp();
Console.WriteLine();
await httpClientApp.Coindesk();


//var email = new Email
//{
//    To = "emil.palczynski@gmail.com",
//    Subject = "App test2",
//    Message = "Alx course test2"
//};

//await httpClientDemo.SendEmail(email);
