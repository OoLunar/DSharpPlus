using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

/// <summary>
/// Roles represent a set of permissions attached to a group of users. Roles have names, colors, and can be "pinned" to the side bar, causing their members to be listed separately. Roles can have separate permission profiles for the global context (guild) and channel context. The <c>@everyone</c> role has the same ID as the guild it belongs to.
/// </summary>
public sealed record InternalRole
{
    /// <summary>
    /// Role Id.
    /// </summary>
    [JsonPropertyName("id")]
    public required Snowflake Id { get; init; } 

    /// <summary>
    /// Name of the role.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; } 

    /// <summary>
    /// The color of the role.
    /// </summary>
    [JsonPropertyName("color")]
    public required int Color { get; init; }

    /// <summary>
    /// If this role is pinned in the user listing.
    /// </summary>
    [JsonPropertyName("hoist")]
    public required bool Hoist { get; init; }

    /// <summary>
    /// The role icon hash.
    /// </summary>
    [JsonPropertyName("icon")]
    public Optional<string?> Icon { get; init; }

    /// <summary>
    /// The role unicode emoji.
    /// </summary>
    [JsonPropertyName("unicode_emoji")]
    public Optional<string?> UnicodeEmoji { get; init; }

    /// <summary>
    /// The position of this role.
    /// </summary>
    [JsonPropertyName("position")]
    public required int Position { get; init; }

    /// <summary>
    /// The Internal permissions of this role.
    /// </summary>
    [JsonPropertyName("permissions")]
    public required DiscordPermissions Permissions { get; init; }

    /// <summary>
    /// Whether this role is managed by an integration.
    /// </summary>
    [JsonPropertyName("managed")]
    public required bool Managed { get; init; }

    /// <summary>
    /// Whether this role is mentionable.
    /// </summary>
    [JsonPropertyName("mentionable")]
    public required bool Mentionable { get; init; }

    /// <summary>
    /// The tags this role has.
    /// </summary>
    [JsonPropertyName("tags")]
    public Optional<InternalRoleTags> Tags { get; init; }

    public static implicit operator ulong(InternalRole role) => role.Id;
    public static implicit operator Snowflake(InternalRole role) => role.Id;
}
