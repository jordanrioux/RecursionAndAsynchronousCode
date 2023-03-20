using AsynchronousCode.CLI.Models;
using AsynchronousCode.CLI.Services;

var service = new JokeService();
var result = service.GetRandomJoke();
var searchResult = service.SearchJokes("leather");
Task.WaitAll(result, searchResult);

DisplayJokeResult(result.Result);
DisplaySearchResults(searchResult.Result);

// for (var i = 0; i < 50; i++)
// {
//     DisplayJokeResult(await service.GetRandomJoke());
// }


// {
//     var tasks = new List<Task<JokeResult?>>();
//     for (var i = 0; i < 50; i++)
//     {
//         tasks.Add(service.GetRandomJoke());
//     }
//     Task.WaitAll(tasks.ToArray());
//
//     foreach (var task in tasks)
//     {
//         DisplayJokeResult(task.Result); 
//     }
// }

void DisplayJokeResult(JokeResult jokeResult)
{
    Console.WriteLine($"{jokeResult.Id} - {jokeResult.Status}");
    Console.WriteLine(jokeResult.Joke);
}

void DisplaySearchResults(JokeSearchResult searchResult)
{
    Console.WriteLine();
    Console.WriteLine("--- Search Results ---");
    Console.WriteLine($"Total Jokes: {searchResult.TotalJokes}");
    Console.WriteLine($"Total TotalPages: {searchResult.TotalPages}");
    Console.WriteLine();

    foreach (var jokeResult in searchResult.Results)
    {
        DisplayJokeResult(jokeResult);
    }
}