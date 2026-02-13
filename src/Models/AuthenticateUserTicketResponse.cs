using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     Parameters returned by AuthenticateUserTicket.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AuthenticateUserTicketParams
{
    /// <summary>
    ///     Status of the authentication (e.g. "OK").
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; } = null!;

    /// <summary>
    ///     The 64-bit SteamID of the authenticated user.
    /// </summary>
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; } = null!;

    /// <summary>
    ///     The 64-bit SteamID of the game owner (may differ from steamid if using Steam Family Sharing).
    /// </summary>
    [JsonPropertyName("ownersteamid")]
    public string OwnerSteamId { get; set; } = null!;

    /// <summary>
    ///     Whether the user has a VAC ban.
    /// </summary>
    [JsonPropertyName("vacbanned")]
    public bool VacBanned { get; set; }

    /// <summary>
    ///     Whether the user has a publisher ban.
    /// </summary>
    [JsonPropertyName("publisherbanned")]
    public bool PublisherBanned { get; set; }
}

/// <summary>
///     Response wrapper for AuthenticateUserTicket.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AuthenticateUserTicketResponse
{
    /// <summary>
    ///     The response parameters containing the authenticated user's SteamID and related data.
    /// </summary>
    [JsonPropertyName("response")]
    public AuthenticateUserTicketResponseInner Response { get; set; } = null!;
}

/// <summary>
///     Inner response object containing params.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AuthenticateUserTicketResponseInner
{
    /// <summary>
    ///     Authentication result parameters.
    /// </summary>
    [JsonPropertyName("params")]
    public AuthenticateUserTicketParams Params { get; set; } = null!;
}