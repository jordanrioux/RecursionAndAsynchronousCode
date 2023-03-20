using AsynchronousCode.CLI.Models;

namespace AsynchronousCode.CLI.Repositories;

public class JokeRepository
{
    private const string BASE_API_URL = "https://icanhazdadjoke.com/";

    public Task<JokeResult?> GetRandomJoke()
    {
        return ApiClientHelper.GetAsync<JokeResult>(BASE_API_URL);
    }

    public Task<JokeSearchResult> SearchJokes(string term = "", int page = 1, int limit = 20)
    {
        var endpoint = $"search?term={term}&page={page}&limit={limit}";
        return ApiClientHelper.GetAsync<JokeSearchResult>(BASE_API_URL + endpoint);
    }
}