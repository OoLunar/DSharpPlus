using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

/// <remarks>
/// For the attachments array in Message Create/Edit requests, only the id is required.
/// </remarks>
public sealed record InternalAttachment
{
    /// <summary>
    /// The attachment id.
    /// </summary>
    [JsonPropertyName("id")]
    public required Snowflake Id { get; init; }

    /// <summary>
    /// The name of the file attached.
    /// </summary>
    [JsonPropertyName("filename")]
    public required string Filename { get; init; }

    /// <summary>
    /// The description for the file.
    /// </summary>
    [JsonPropertyName("description")]
    public Optional<string> Description { get; init; }

    /// <summary>
    /// The attachment's <seealso href="https://en.wikipedia.org/wiki/Media_type">media type</seealso>.
    /// </summary>
    [JsonPropertyName("content_type")]
    public Optional<string> ContentType { get; init; }

    /// <summary>
    /// The size of the file in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public required int Size { get; init; }

    /// <summary>
    /// The source url of file.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// A proxied url of file.
    /// </summary>
    [JsonPropertyName("proxy_url")]
    public required string ProxyUrl { get; init; } 

    /// <summary>
    /// The height of file (if image).
    /// </summary>
    [JsonPropertyName("height")]
    public Optional<int?> Height { get; init; }

    /// <summary>
    /// The width of file (if image).
    /// </summary>
    [JsonPropertyName("width")]
    public Optional<int?> Width { get; init; }

    /// <summary>
    /// Whether this attachment is ephemeral.
    /// </summary>
    /// <remarks>
    /// Ephemeral attachments will automatically be removed after a set period of time. Ephemeral attachments on messages are guaranteed to be available as long as the message itself exists.
    /// </remarks>
    [JsonPropertyName("ephemeral")]
    public Optional<bool> Ephemeral { get; init; }
}
