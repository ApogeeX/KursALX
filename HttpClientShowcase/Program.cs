using HttpClientShowcase;
using HttpClientShowcase.Models;

Console.WriteLine("Http Client Demo...");
Console.WriteLine();
var serializationDemo = new SerializationDemo();
//var jsonStrings = serializationDemo.RunSerialization();
//serializationDemo.RunDeserialization(jsonStrings);

var client = new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
//var hello = await httpClientDemo.Hello("Emil");
//Console.WriteLine(hello);
//await httpClientDemo.GetRandomJoke();
//Console.WriteLine();
//await httpClientDemo.GetRandomCatInfo();
//Console.WriteLine();
//await httpClientDemo.GetRandomDogImage();
//await httpClientDemo.PredictGender("Me");

//var email = new Email
//{
//    To = "emil.palczynski@gmail.com",
//    Subject = "App test2",
//    Message = "Alx course test2"
//};

//await httpClientDemo.SendEmail(email);