using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalComponentInteraction
{
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonPropertyName("type")]
    public required int Type { get; init; }

    [JsonPropertyName("message")]
    public required InternalMessage Message { get; init; } 

    [JsonPropertyName("member")]
    public required InternalGuildMember Member { get; init; } 

    [JsonPropertyName("id")]
    public required Snowflake Id { get; init; } 

    [JsonPropertyName("guild_id")]
    public required Snowflake GuildId { get; init; }

    [JsonPropertyName("data")]
    public required InternalInteractionResolvedData Data { get; init; } 

    [JsonPropertyName("channel_id")]
    public required Snowflake ChannelId { get; init; } 

    [JsonPropertyName("application_id")]
    public required Snowflake ApplicationId { get; init; } 
}
