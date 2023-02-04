using HttpClientShowcase.Models;

namespace HttpClientShowcase.Interfaces
{
    public interface IHttpClientDemo
    {
        Task GetRandomJoke();
        Task GetRandomCatInfo();
        Task GetRandomDogImage();
        Task PredictGender(string name);
        Task SendEmail(Email email);
    }
}
