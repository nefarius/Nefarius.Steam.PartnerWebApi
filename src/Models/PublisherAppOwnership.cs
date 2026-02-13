using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>App entry in publisher app ownership.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class App
{
    /// <summary>App ID.</summary>
    [JsonPropertyName("appid")]
    public int AppId { get; set; }

    /// <summary>Whether the user owns the app.</summary>
    [JsonPropertyName("ownsapp")]
    public bool OwnsApp { get; set; }

    /// <summary>Whether ownership is permanent.</summary>
    [JsonPropertyName("permanent")]
    public bool Permanent { get; set; }

    /// <summary>When the app was acquired.</summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    /// <summary>When the license expires (if applicable).</summary>
    [JsonPropertyName("timeexpired")]
    public string TimeExpired { get; set; } = null!;

    /// <summary>Owner Steam ID.</summary>
    [JsonPropertyName("ownersteamid")]
    public string OwnerSteamId { get; set; } = null!;

    /// <summary>Whether this is a site license.</summary>
    [JsonPropertyName("sitelicense")]
    public bool Sitelicense { get; set; }

    /// <summary>Whether the user canceled.</summary>
    [JsonPropertyName("usercanceled")]
    public bool UserCanceled { get; set; }

    /// <summary>Whether this is a timed trial.</summary>
    [JsonPropertyName("timedtrial")]
    public bool TimedTrial { get; set; }
}

/// <summary>Publisher app ownership container.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PublisherAppOwnership
{
    /// <summary>List of app ownership entries.</summary>
    [JsonPropertyName("apps")]
    public List<App> Apps { get; set; } = null!;
}

/// <summary>Response wrapper for GetPublisherAppOwnership.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PublisherAppOwnershipResponse
{
    /// <summary>App ownership data.</summary>
    [JsonPropertyName("appownership")]
    public PublisherAppOwnership AppOwnership { get; set; } = null!;
}