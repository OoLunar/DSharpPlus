using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalUserConnection
{
    /// <summary>
    /// The id of the connection account.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The username of the connection account.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The service of the connection (twitch, youtube).
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Whether the connection is revoked.
    /// </summary>
    [JsonPropertyName("revoked")]
    public Optional<bool> Revoked { get; init; }

    /// <summary>
    /// An array of partial server integrations.
    /// </summary>
    [JsonPropertyName("integrations")]
    public Optional<IReadOnlyList<InternalIntegration>> Integrations { get; init; }

    /// <summary>
    /// Whether the connection is verified.
    /// </summary>
    [JsonPropertyName("verified")]
    public required bool Verified { get; init; }

    /// <summary>
    /// Whether friend sync is enabled for this connection.
    /// </summary>
    [JsonPropertyName("friend_sync")]
    public required bool FriendSync { get; init; }

    /// <summary>
    /// Whether activities related to this connection will be shown in presence updates.
    /// </summary>
    [JsonPropertyName("show_activity")]
    public required bool ShowActivity { get; init; }

    /// <summary>
    /// The visibility of this connection.
    /// </summary>
    [JsonPropertyName("visibility")]
    public required DiscordUserConnectionVisibilityType Visibility { get; init; }
}
