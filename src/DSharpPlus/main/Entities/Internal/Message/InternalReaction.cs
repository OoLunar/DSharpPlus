using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalReaction
{
    /// <summary>
    /// Times this emoji has been used to react.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    /// <summary>
    /// Whether the current user reacted using this emoji.
    /// </summary>
    [JsonPropertyName("me")]
    public required bool Me { get; init; }

    /// <summary>
    /// The emoji information.
    /// </summary>
    [JsonPropertyName("emoji")]
    public required InternalEmoji Emoji { get; init; } 
}
