using HttpClientShowcase.Interfaces;
using HttpClientShowcase.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;

namespace HttpClientShowcase
{
    public class HttpClientApp : IHttpClientApp
    {

        private readonly HttpClient _httpClient;
        private const string OutputFolderPath = @"C:\Temp\Img";

        public HttpClientApp(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task BoredApi()
        {
            var requestUri = "https://www.boredapi.com/api/activity";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var boredapi = JsonConvert.DeserializeObject<BoredApiResponse>(responseContentJson);
            Console.WriteLine($"Boredapi for today:\nActivity: {boredapi.Activity}\nType: {boredapi.Type}\nParticipants: {boredapi.Participants}\nPrice: {boredapi.Price}\nLink: {boredapi.Link}\nKey: {boredapi.Key}\nAccessibility: {boredapi.Accessibility}");
        }

        public async Task Herokuapp()
        {
            var requestUri = "https://go-apod.herokuapp.com/apod";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var herokuapp = JsonConvert.DeserializeObject<HerokuappResponse>(responseContentJson);
            Console.WriteLine($"Herokuapp for today:\nDate: {herokuapp.Date}\nExplanation: {herokuapp.Explanation}\nHdurl: {herokuapp.Hdurl}\nMedia_type: {herokuapp.Media_type}\nService_version: {herokuapp.Service_version}\nTitle: {herokuapp.Title}\nUrl: {herokuapp.Url}");
            try
            {
                SaveImage(herokuapp.Url, herokuapp.Title);
                Process.Start("explorer.exe", OutputFolderPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public async Task Coindesk()
        {
            var requestUri = "https://api.coindesk.com/v1/bpi/currentprice.json";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var coindesk = JsonConvert.DeserializeObject<CoindeskResponse>(responseContentJson);
            Console.WriteLine($"Coinbase for today:\nTime: {coindesk.Time.updateduk}\nDisclaimer: {coindesk.Disclaimer}\nChartName: {coindesk.ChartName}\nBpi USD rate: {coindesk.Bpi.USD.rate_float}\nBpi GBP rate: {coindesk.Bpi.GBP.rate_float}\nBpi EUR rate: {coindesk.Bpi.EUR.rate_float}");
        }

        private void SaveImage(string imageUri, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                var stream = webClient.OpenRead(imageUri);
                var bitmap = new Bitmap(stream);
                if (bitmap != null)
                    bitmap.Save($"{OutputFolderPath}\\{fileName}.png", ImageFormat.Png);
            }
        }
    }
}
