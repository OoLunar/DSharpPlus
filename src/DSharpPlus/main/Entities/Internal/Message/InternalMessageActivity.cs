using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalMessageActivity
{
    [JsonPropertyName("type")]
    public required MessageActivityType Type { get; init; }

    [JsonPropertyName("party_id")]
    public Optional<string> PartyId { get; init; }
}
