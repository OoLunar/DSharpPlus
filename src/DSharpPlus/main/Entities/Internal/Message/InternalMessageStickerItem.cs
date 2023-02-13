using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

/// <summary>
/// The smallest amount of data required to render a sticker. A partial sticker object.
/// </summary>
public sealed record InternalMessageStickerItem
{
    /// <summary>
    /// The id of the sticker.
    /// </summary>
    [JsonPropertyName("id")]
    public required Snowflake Id { get; init; } 

    /// <summary>
    /// The name of the sticker.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The type of sticker format.
    /// </summary>
    [JsonPropertyName("format_type")]
    public required DiscordStickerFormatType FormatType { get; init; }
}
