# Vpnly.cs
Web-API for [vpnly.net](https://vpnly.net) an free VPN extension that provides unlimited access without any restrictions

## Example
```cs
using VpnlyApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Vpnly();
            string servers = await api.GetServers();
            Console.WriteLine(servers);
        }
    }
}
```
