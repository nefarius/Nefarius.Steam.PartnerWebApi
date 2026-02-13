using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     Checks if the specified user owns the app.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AppOwnership
{
    /// <summary>
    ///     Indicates if the user is the actual owner or the app.
    /// </summary>
    [JsonPropertyName("ownsapp")]
    public bool OwnsApp { get; set; }

    /// <summary>
    ///     Whether the user permanently owns your app. Not true for ownership via Family Sharing, free weekends, or site
    ///     license.
    /// </summary>
    [JsonPropertyName("permanent")]
    public bool Permanent { get; set; }

    /// <summary>
    ///     Time that the app was acquired.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    /// <summary>
    ///     Indicates the true owner of the app.
    /// </summary>
    [JsonPropertyName("ownersteamid")]
    public string OwnerSteamId { get; set; } = null!;

    /// <summary>
    ///     Indicates if user is borrowing this license from a PC Cafe site.
    /// </summary>
    [JsonPropertyName("sitelicense")]
    public bool SiteLicense { get; set; }

    /// <summary>Indicates if this is a timed trial.</summary>
    [JsonPropertyName("timedtrial")]
    public bool TimedTrial { get; set; }

    /// <summary>Result code from the API.</summary>
    [JsonPropertyName("result")]
    public string Result { get; set; } = null!;
}

/// <summary>
///     Checks if the specified user owns the app.
/// </summary>
[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
[SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Global")]
public sealed class AppOwnershipResponse
{
    /// <summary>App ownership details.</summary>
    [JsonPropertyName("appownership")]
    public AppOwnership AppOwnership { get; set; } = null!;
}