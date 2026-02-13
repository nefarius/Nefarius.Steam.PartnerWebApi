using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>Ownership changes from GetAppOwnershipChanges.</summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class OwnershipChanges
{
    /// <summary>List of Steam ID entries.</summary>
    [JsonPropertyName("steamids")]
    public List<SteamIdEntry> Steamids { get; set; } = null!;

    /// <summary>Package row version for pagination.</summary>
    [JsonPropertyName("packagerowversion")]
    public ulong PackageRowVersion { get; set; } = 0;

    /// <summary>CD key row version for pagination.</summary>
    [JsonPropertyName("cdkeyrowversion")]
    public ulong CdKeyRowVersion { get; set; } = 0;

    /// <summary>Whether more data is available.</summary>
    [JsonPropertyName("moredata")]
    public bool MoreData { get; set; }
}

/// <summary>Request payload for GetAppOwnershipChanges.</summary>
public class OwnershipChangesRequest
{
    /// <summary>Ownership changes data.</summary>
    [JsonPropertyName("ownershipchanges")]
    public OwnershipChanges Ownershipchanges { get; set; } = null!;
}

/// <summary>Steam ID entry for ownership changes.</summary>
public class SteamIdEntry
{
    /// <summary>Steam ID.</summary>
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; } = null!;
}