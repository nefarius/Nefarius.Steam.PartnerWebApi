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

