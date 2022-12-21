using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalActivityTimestamps
{
    /// <summary>
    /// The unix time (in milliseconds) of when the activity started.
    /// </summary>
    [JsonPropertyName("start")]
    public Optional<int> Start { get; init; }

    /// <summary>
    /// The unix time (in milliseconds) of when the activity ends.
    /// </summary>
    [JsonPropertyName("end")]
    public Optional<int> End { get; init; }
}
