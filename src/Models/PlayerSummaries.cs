using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>The user's current status — Steam persona state.</summary>
public enum PlayerSummariesPersonaState
{
    /// <summary>Offline.</summary>
    Offline = 0,

    /// <summary>Online.</summary>
    Online = 1,

    /// <summary>Busy.</summary>
    Busy = 2,

    /// <summary>Away.</summary>
    Away = 3,

    /// <summary>Snooze.</summary>
    Snooze = 4,

    /// <summary>Looking to trade.</summary>
    LookingToTrade = 5,

    /// <summary>Looking to play.</summary>
    LookingToPlay = 6
}

/// <summary>Community profile visibility.</summary>
public enum CommunityVisibilityState
{
    /// <summary>
    ///     Private, Friends Only, etc.
    /// </summary>
    NotVisible = 1,

    /// <summary>
    ///     Profile is publicly visible.
    /// </summary>
    Public = 3
}

/// <summary>Profile configuration state.</summary>
public enum PlayerSummariesProfileState
{
    /// <summary>Default.</summary>
    Default,

    /// <summary>Community profile is configured.</summary>
    CommunityProfileConfigured
}

/// <summary>Player summary from GetPlayerSummaries.</summary>
public sealed class PlayerSummariesPlayer
{
    /// <summary>
    ///     64bit SteamID of the user
    /// </summary>
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; } = null!;

    /// <summary>
    ///     This represents whether the profile is visible or not, and if it is visible, why you are allowed to see it. Note
    ///     that because this WebAPI does not use authentication, there are only two possible values returned: 1 - the profile
    ///     is not visible to you (Private, Friends Only, etc), 3 - the profile is "Public", and the data is visible. Mike
    ///     Blaszczak&apos;s
    ///     <see href="http://forums.steampowered.com/forums/showpost.php?p=31955251&amp;postcount=3">post on Steam forums</see>
    ///     says, "The community visibility state this API returns is different than the privacy state. It's the effective
    ///     visibility state from the account making the request to the account being viewed given the requesting
    ///     account's relationship to the viewed account."
    /// </summary>
    [JsonPropertyName("communityvisibilitystate")]
    public CommunityVisibilityState CommunityVisibilityState { get; set; }

    /// <summary>
    ///     If set, indicates the user has a community profile configured (will be set to '1')
    /// </summary>
    [JsonPropertyName("profilestate")]
    public PlayerSummariesProfileState ProfileState { get; set; }

    /// <summary>
    ///     The player's persona name (display name)
    /// </summary>
    [JsonPropertyName("personaname")]
    public string PersonaName { get; set; } = null!;

    /// <summary>
    ///     The full URL of the player's Steam Community profile.
    /// </summary>
    [JsonPropertyName("profileurl")]
    public Uri ProfileUrl { get; set; } = null!;

    /// <summary>
    ///     The full URL of the player's 32x32px avatar. If the user hasn't configured an avatar, this will be the default ?
    ///     avatar.
    /// </summary>
    [JsonPropertyName("avatar")]
    public Uri Avatar { get; set; } = null!;

    /// <summary>
    ///     The full URL of the player's 64x64px avatar. If the user hasn't configured an avatar, this will be the default ?
    ///     avatar.
    /// </summary>
    [JsonPropertyName("avatarmedium")]
    public Uri AvatarMedium { get; set; } = null!;

    /// <summary>
    ///     The full URL of the player's 184x184px avatar. If the user hasn't configured an avatar, this will be the default ?
    ///     avatar.
    /// </summary>
    [JsonPropertyName("avatarfull")]
    public Uri AvatarFull { get; set; } = null!;

    /// <summary>
    ///     SHA1 hash of the avatar.
    /// </summary>
    [JsonPropertyName("avatarhash")]
    public string AvatarHash { get; set; } = null!;

    /// <summary>Current persona state.</summary>
    [JsonPropertyName("personastate")]
    public PlayerSummariesPersonaState PersonaState { get; set; }

    /// <summary>Real name (if set and visible).</summary>
    [JsonPropertyName("realname")]
    public string? RealName { get; set; }

    /// <summary>Primary clan ID.</summary>
    [JsonPropertyName("primaryclanid")]
    public string? PrimaryClanId { get; set; }

    /// <summary>Account creation time (Unix timestamp).</summary>
    [JsonPropertyName("timecreated")]
    public int? TimeCreated { get; set; }

    /// <summary>Persona state flags.</summary>
    [JsonPropertyName("personastateflags")]
    public int? PersonaStateFlags { get; set; }
}

/// <summary>Container for player summaries.</summary>
public sealed class PlayerSummaries
{
    /// <summary>List of player summaries.</summary>
    [JsonPropertyName("players")]
    public List<PlayerSummariesPlayer> Players { get; set; } = null!;
}

/// <summary>Response wrapper for GetPlayerSummaries.</summary>
public sealed class PlayerSummariesResponse
{
    /// <summary>The player summaries response.</summary>
    [JsonPropertyName("response")]
    public PlayerSummaries Response { get; set; } = null!;
}