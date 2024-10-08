using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Represents arguments for MessageReactionRemovedEmoji
/// </summary>
public sealed class MessageReactionRemovedEmojiEventArgs : DiscordEventArgs
{
    /// <summary>
    /// Gets the channel the removed reactions were in.
    /// </summary>
    public DiscordChannel Channel { get; internal set; }

    /// <summary>
    /// Gets the guild the removed reactions were in.
    /// </summary>
    public DiscordGuild Guild { get; internal set; }

    /// <summary>
    /// Gets the message that had the removed reactions.
    /// </summary>
    public DiscordMessage Message { get; internal set; }

    /// <summary>
    /// Gets the emoji of the reaction that was removed.
    /// </summary>
    public DiscordEmoji Emoji { get; internal set; }

    internal MessageReactionRemovedEmojiEventArgs() : base() { }
}
