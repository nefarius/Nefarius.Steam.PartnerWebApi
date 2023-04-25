using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class Player
{
    [JsonPropertyName("SteamId")]
    public string SteamId { get; set; }

    [JsonPropertyName("CommunityBanned")]
    public bool CommunityBanned { get; set; }

    [JsonPropertyName("VACBanned")]
    public bool VACBanned { get; set; }

    [JsonPropertyName("NumberOfVACBans")]
    public int NumberOfVACBans { get; set; }

    [JsonPropertyName("DaysSinceLastBan")]
    public int DaysSinceLastBan { get; set; }

    [JsonPropertyName("NumberOfGameBans")]
    public int NumberOfGameBans { get; set; }

    [JsonPropertyName("EconomyBan")]
    public string EconomyBan { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PlayerBansResponse
{
    [JsonPropertyName("players")]
    public List<Player> Players { get; set; }
}

