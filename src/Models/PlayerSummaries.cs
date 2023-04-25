using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     The user's current status.
/// </summary>
public enum PlayerSummariesPersonaState
{
    Offline = 0,
    Online = 1,
    Busy = 2,
    Away = 3,
    Snooze = 4,
    LookingToTrade = 5,
    LookingToPlay = 6
}

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

public enum PlayerSummariesProfileState
{
    Default,
    CommunityProfileConfigured
}

public sealed class PlayerSummariesPlayer
{
    /// <summary>
    ///     64bit SteamID of the user
    /// </summary>
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; }

    /// <summary>
    ///     This represents whether the profile is visible or not, and if it is visible, why you are allowed to see it. Note
    ///     that because this WebAPI does not use authentication, there are only two possible values returned: 1 - the profile
    ///     is not visible to you (Private, Friends Only, etc), 3 - the profile is "Public", and the data is visible. Mike
    ///     Blaszczak&apos;s
    ///     <see href="http://forums.steampowered.com/forums/showpost.php?p=31955251&postcount=3">post on Steam forums</see>
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
    public string PersonaName { get; set; }

    /// <summary>
    ///     The full URL of the player's Steam Community profile.
    /// </summary>
    [JsonPropertyName("profileurl")]
    public Uri ProfileUrl { get; set; }

    /// <summary>
    ///     The full URL of the player's 32x32px avatar. If the user hasn't configured an avatar, this will be the default ?
    ///     avatar.
    /// </summary>
    [JsonPropertyName("avatar")]
    public Uri Avatar { get; set; }

    /// <summary>
    ///     The full URL of the player's 64x64px avatar. If the user hasn't configured an avatar, this will be the default ?
    ///     avatar.
    /// </summary>
    [JsonPropertyName("avatarmedium")]
    public Uri AvatarMedium { get; set; }

    /// <summary>
    ///     The full URL of the player's 184x184px avatar. If the user hasn't configured an avatar, this will be the default ?
    ///     avatar.
    /// </summary>
    [JsonPropertyName("avatarfull")]
    public Uri AvatarFull { get; set; }

    /// <summary>
    ///     SHA1 hash of the avatar.
    /// </summary>
    [JsonPropertyName("avatarhash")]
    public string AvatarHash { get; set; }

    [JsonPropertyName("personastate")]
    public PlayerSummariesPersonaState PersonaState { get; set; }

    [JsonPropertyName("realname")]
    public string RealName { get; set; }

    [JsonPropertyName("primaryclanid")]
    public string PrimaryClanId { get; set; }

    [JsonPropertyName("timecreated")]
    public int? TimeCreated { get; set; }

    [JsonPropertyName("personastateflags")]
    public int? PersonaStateFlags { get; set; }
}

public sealed class PlayerSummaries
{
    [JsonPropertyName("players")]
    public List<PlayerSummariesPlayer> Players { get; set; }
}

public sealed class PlayerSummariesResponse
{
    [JsonPropertyName("response")]
    public PlayerSummaries Response { get; set; }
}