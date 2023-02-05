using HttpClientShowcase.Models;

namespace HttpClientShowcase.Interfaces
{
    public interface IHttpClientApp
    {
        Task BoredApi();
        Task Herokuapp();
        Task Coindesk();
    }
}
