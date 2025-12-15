using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class App
{
    [JsonPropertyName("appid")]
    public int AppId { get; set; }

    [JsonPropertyName("ownsapp")]
    public bool OwnsApp { get; set; }

    [JsonPropertyName("permanent")]
    public bool Permanent { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("ownersteamid")]
    public string OwnerSteamId { get; set; }

    [JsonPropertyName("sitelicense")]
    public bool Sitelicense { get; set; }

    [JsonPropertyName("timedtrial")]
    public bool TimedTrial { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AppV5
{
    [JsonPropertyName("appid")]
    public int AppId { get; set; }

    [JsonPropertyName("ownsapp")]
    public bool OwnsApp { get; set; }

    [JsonPropertyName("permanent")]
    public bool Permanent { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("timeexpires")]
    public string TimeExpires { get; set; }

    [JsonPropertyName("ownersteamid")]
    public string OwnerSteamId { get; set; }

    [JsonPropertyName("sitelicense")]
    public bool Sitelicense { get; set; }

    [JsonPropertyName("usercanceled")]
    public bool UserCanceled { get; set; }

    [JsonPropertyName("timedtrial")]
    public bool TimedTrial { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PublisherAppOwnership
{
    [JsonPropertyName("apps")]
    public List<App> Apps { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PublisherAppOwnershipResponse
{
    [JsonPropertyName("appownership")]
    public PublisherAppOwnership AppOwnership { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PublisherAppOwnershipV5
{
    [JsonPropertyName("apps")]
    public List<AppV5> Apps { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PublisherAppOwnershipV5Response
{
    [JsonPropertyName("appownership")]
    public PublisherAppOwnershipV5 AppOwnership { get; set; }
}

