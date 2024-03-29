﻿using HttpClientShowcase.Interfaces;
using HttpClientShowcase.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;

namespace HttpClientShowcase
{
    public class HttpClientDemo : IHttpClientDemo
    {
        private const string OutputFolderPath = @"C:\Temp\Img";
        private readonly HttpClient _httpClient;
        public HttpClientDemo(HttpClient client) 
        {
            _httpClient = client;
        }

        public async Task GetRandomJoke()
        {
            var requestUri = "https://official-joke-api.appspot.com/random_joke";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var joke = JsonConvert.DeserializeObject<JokeResponse>(responseContentJson);
            Console.WriteLine($"Joke for today:\n{joke.Setup}\n -> {joke.Punchline}");
        }
        
        public async Task GetRandomCatInfo()
        {
            var requestUri = "https://catfact.ninja/fact";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var catFact = JsonConvert.DeserializeObject<CatFactResponse>(responseContentJson);
            Console.WriteLine($"Cat fact for today:\n{catFact.Fact}");
        }

        public async Task GetRandomDogImage()
        {
            var requestUri = "https://dog.ceo/api/breeds/image/random";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var randomDogImageLink = JsonConvert.DeserializeObject<RandomDogImageResponse>(responseContentJson);
            try
            {
                SaveImage(randomDogImageLink.Message, "something");
                Process.Start("explorer.exe", OutputFolderPath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        public async Task PredictGender(string name)
        {
            var baseRequestUri = "https://api.genderize.io";
            var uriBuilder = new UriBuilder(baseRequestUri);
            uriBuilder.Query = $"name={name}";
            var uri = uriBuilder.Uri;
            var response = await _httpClient.GetAsync(uri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var predictGenderResponse = JsonConvert.DeserializeObject<PredictGenderResponse>(responseContentJson);
            Console.WriteLine($"Name: {predictGenderResponse.Name}\nGender: {predictGenderResponse.Gender}\nPropability: {predictGenderResponse.Probability * 100}%");
        }

        public async Task SendEmail(Email email)
        {
            var baseRequestUri = "https://cnemailingservice20230203214349.azurewebsites.net/api/CNEMailingFunction";
            var emailJson = JsonConvert.SerializeObject(email);
            var requestContent = new StringContent(emailJson);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, baseRequestUri);
            requestMessage.Content = requestContent;
            requestMessage.Headers.Add("x-functions-key", "<api key>");
            var result = await _httpClient.SendAsync(requestMessage);
            var resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
        }

        public async Task<string> Hello(string name)
        {
            return $"Hello {name}";
        }

        private void SaveImage(string imageUri, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                var stream = webClient.OpenRead(imageUri);
                var bitmap = new Bitmap(stream);
                if(bitmap!=null)
                    bitmap.Save($"{OutputFolderPath}\\{fileName}.png", ImageFormat.Png);
            }
        }

        public async Task BoredApi()
        {
            var requestUri = "https://www.boredapi.com/api/activity";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var boredapi = JsonConvert.DeserializeObject<BoredApiResponse>(responseContentJson);
            Console.WriteLine($"Boredapi for today:\nActivity: {boredapi.Activity}\nType: {boredapi.Type}\nParticipants: {boredapi.Participants}\nPrice: {boredapi.Price}\nLink: {boredapi.Link}\nKey: {boredapi.Key}\nAccessibility: {boredapi.Accessibility}");
        }
    }
}
