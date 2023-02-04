using HttpClientShowcase;

Console.WriteLine("Http Client Demo...");
Console.WriteLine();
var serializationDemo = new SerializationDemo();
//var jsonStrings = serializationDemo.RunSerialization();
//serializationDemo.RunDeserialization(jsonStrings);

var client = new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
//var hello = await httpClientDemo.Hello("Emil");
//Console.WriteLine(hello);
await httpClientDemo.GetRandomJoke();
Console.WriteLine();
await httpClientDemo.GetRandomCatInfo();
Console.WriteLine();
await httpClientDemo.GetRandomDogImage();
