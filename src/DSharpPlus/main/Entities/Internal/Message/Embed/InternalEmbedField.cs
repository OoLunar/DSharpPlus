using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalEmbedField
{
    /// <summary>
    /// The name of the field.
    /// </summary>
    /// <remarks>
    /// Max 256 characters.
    /// </remarks>
    [JsonPropertyName("name")]
    public required string Name { get; init; } 

    /// <summary>
    /// The value of the field.
    /// </summary>
    /// <remarks>
    /// Max 1024 characters.
    /// </remarks>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// Whether or not this field should display inline.
    /// </summary>
    [JsonPropertyName("inline")]
    public Optional<bool> Inline { get; init; }
}
