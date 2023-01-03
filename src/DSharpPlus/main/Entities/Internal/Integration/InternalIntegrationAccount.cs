using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalIntegrationAccount
{
    /// <summary>
    /// The id of the account.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; } 

    /// <summary>
    /// The name of the account.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; } 
}
