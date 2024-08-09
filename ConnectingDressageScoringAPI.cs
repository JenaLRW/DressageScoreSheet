namespace scoringapi
{
    public class ConnectingDressageScoringAPI
    {
        private readonly HttpClient _httpClient;

        public ConnectingDressageScoringAPI(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DressageScoringApi");
        }

        public async Task<List<?????? >> GetHorses()
        {
            var horses = await _httpClient.GetFromJsonAsync<List<HorseModel>>("");
            return horses;
        }
    }
}
    }
}
