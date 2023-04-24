using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class OwnershipChanges
{
    [JsonPropertyName("steamids")]
    public List<SteamIdEntry> Steamids { get; set; }

    [JsonPropertyName("packagerowversion")]
    public ulong PackageRowVersion { get; set; } = 0;

    [JsonPropertyName("cdkeyrowversion")]
    public ulong CdKeyRowVersion { get; set; } = 0;

    [JsonPropertyName("moredata")]
    public bool MoreData { get; set; }
}

public class OwnershipChangesRequest
{
    [JsonPropertyName("ownershipchanges")]
    public OwnershipChanges Ownershipchanges { get; set; }
}

public class SteamIdEntry
{
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; }
}

