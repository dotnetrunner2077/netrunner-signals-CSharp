using System.Net.Http.Headers;
using System.Net.Http.Json;
using Netrunner.Signasl.Models;

namespace Netrunner.Signasl.Services;
public class TriangleService
{
    private readonly string _apiUri;
    private readonly string _endpoint;
    private readonly string _token;
    private readonly string _netrunner;
    public TriangleService(string apiUri, string endpoint, string token, string netrunner)
    {
        _apiUri = apiUri;
        _endpoint = endpoint;
        _token = token;
        _netrunner = netrunner;

    }
    public async Task<List<TriangleSignals>> GetSignalsAsync()
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        client.DefaultRequestHeaders.Add("netrunner-id", _netrunner);

        var response = await client.GetFromJsonAsync<List<TriangleSignals>>(_apiUri + _endpoint);
        return response ?? new List<TriangleSignals>();
    }
}
