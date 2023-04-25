using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public sealed class DeletedSteamIds
{
    [JsonPropertyName("steamids")]
    public List<DeletedSteamIdEntry> SteamIds { get; set; }

    [JsonPropertyName("rowversion")]
    public ulong RowVersion { get; set; }
}

public sealed class DeletedSteamIdsResponse
{
    [JsonPropertyName("response")]
    public DeletedSteamIds Response { get; set; }
}

public sealed class DeletedSteamIdEntry
{
    [JsonPropertyName("steamid")]
    public string SteamId { get; set; }

    [JsonPropertyName("appid")]
    public int AppId { get; set; }
}

