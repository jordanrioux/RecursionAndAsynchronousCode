using System.Net.Http.Headers;
using System.Text.Json;

namespace AsynchronousCode.CLI.Repositories;

public static class ApiClientHelper
{
    private static readonly HttpClient _client;

    static ApiClientHelper()
    {
        _client = new HttpClient(); 
        _client.DefaultRequestHeaders
            .Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    public static async Task<TResult?> GetAsync<TResult>(string url)
    {
        var response = await _client.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<TResult>(json);
        return result;
    }
}