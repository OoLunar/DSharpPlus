using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Represents arguments for the DmChannelDeleted event.
/// </summary>
public class DmChannelDeletedEventArgs : DiscordEventArgs
{
    /// <summary>
    /// Gets the direct message channel that was deleted.
    /// </summary>
    public DiscordDmChannel Channel { get; internal set; }

    internal DmChannelDeletedEventArgs() : base() { }
}
