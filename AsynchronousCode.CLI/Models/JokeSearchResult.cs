using System.Text.Json.Serialization;

namespace AsynchronousCode.CLI.Models;

public class JokeSearchResult
{
    [JsonPropertyName("current_page")]
    public long CurrentPage { get; set; }

    [JsonPropertyName("limit")]
    public long Limit { get; set; }

    [JsonPropertyName("next_page")]
    public long NextPage { get; set; }

    [JsonPropertyName("previous_page")]
    public long PreviousPage { get; set; }

    [JsonPropertyName("results")]
    public List<JokeResult> Results { get; set; }

    [JsonPropertyName("search_term")]
    public string SearchTerm { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("total_jokes")]
    public long TotalJokes { get; set; }

    [JsonPropertyName("total_pages")]
    public long TotalPages { get; set; }
}
