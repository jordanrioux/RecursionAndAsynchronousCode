using System.Text.Json.Serialization;

namespace AsynchronousCode.CLI.Models;

public partial class JokeResult
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("joke")]
    public string Joke { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }
}