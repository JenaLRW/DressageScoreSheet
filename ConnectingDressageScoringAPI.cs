using scoringapi.Model;

namespace scoringapi
{
    public class ConnectingDressageScoringAPI
    {
        private readonly HttpClient _httpClient;

        public ConnectingDressageScoringAPI(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DressageScoringApi");
        }

        public async Task<List<Horse>> GetHorses()
        {
            var horses = await _httpClient.GetFromJsonAsync<List<Horse>>("api/horses"); 
            return horses;
        }
    }
}
