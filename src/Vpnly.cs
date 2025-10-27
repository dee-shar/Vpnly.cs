using System.Net.Http;

namespace VpnlyApi
{
    public class Vpnly
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://s3.hub-vpn.com";
        public Vpnly()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
        }

        public async Task<string> GetServers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/servers.json");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
