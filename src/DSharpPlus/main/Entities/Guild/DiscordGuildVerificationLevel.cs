namespace DSharpPlus.Entities;

public enum DiscordGuildVerificationLevel
{
    /// <summary>
    /// Unrestricted.
    /// </summary>
    None = 0,

    /// <summary>
    /// Must have verified email on account.
    /// </summary>
    Low = 1,

    /// <summary>
    /// Must be registered on Discord for longer than 5 minutes.
    /// </summary>
    Medium = 2,

    /// <summary>
    /// Must be a member of the server for longer than 10 minutes.
    /// </summary>
    High = 3,

    /// <summary>
    /// Must have a verified phone number.
    /// </summary>
    VeryHigh = 4
}
