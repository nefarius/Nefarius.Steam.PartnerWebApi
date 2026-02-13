using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>Deleted Steam IDs response from GetDeletedSteamIds.</summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public sealed class DeletedSteamIds
{
    /// <summary>List of deleted Steam ID entries.</summary>
    [JsonPropertyName("steamids")]
    public List<DeletedSteamIdEntry> SteamIds { get; set; } = null!;

    /// <summary>Row version for pagination.</summary>
    [JsonPropertyName("rowversion")]
    public ulong RowVersion { get; set; }
}

/// <summary>Response wrapper for GetDeletedSteamIds.</summary>
public sealed class DeletedSteamIdsResponse
{
    /// <summary>The deleted Steam IDs response.</summary>
    [JsonPropertyName("response")]
    public DeletedSteamIds Response { get; set; } = null!;
}

/// <summary>Single deleted Steam ID entry.</summary>
public sealed class DeletedSteamIdEntry
{
    /// <summary>Steam ID.</summary>
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; } = null!;

    /// <summary>App ID.</summary>
    [JsonPropertyName("appid")]
    public int AppId { get; set; }
}