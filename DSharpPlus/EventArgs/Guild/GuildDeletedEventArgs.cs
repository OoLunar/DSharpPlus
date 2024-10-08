using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Represents arguments for the GuildDeleted event.
/// </summary>
public class GuildDeletedEventArgs : DiscordEventArgs
{
    /// <summary>
    /// Gets the guild that was deleted.
    /// </summary>
    public DiscordGuild Guild { get; internal set; }

    /// <summary>
    /// Gets whether the guild is unavailable or not.
    /// </summary>
    public bool Unavailable { get; internal set; }

    internal GuildDeletedEventArgs() : base() { }
}
