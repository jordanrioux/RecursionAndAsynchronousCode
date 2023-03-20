using AsynchronousCode.CLI.Models;
using AsynchronousCode.CLI.Repositories;

namespace AsynchronousCode.CLI.Services;

public class JokeService
{
    private readonly JokeRepository _jokeRepository;

    public JokeService(JokeRepository? jokeRepository = null)
    {
        _jokeRepository = jokeRepository ?? new JokeRepository();
    }
    
    public Task<JokeResult?> GetRandomJoke()
    {
        return _jokeRepository.GetRandomJoke();
    }

    public Task<JokeSearchResult> SearchJokes(string term = "", int page = 1, int limit = 20)
    {
        // TODO: Validate the input
        return _jokeRepository.SearchJokes(term, page, limit);
    }
}