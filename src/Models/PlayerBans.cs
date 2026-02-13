using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>Player ban info from GetPlayerBans.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class Player
{
    /// <summary>Steam ID.</summary>
    [JsonPropertyName("SteamId")]
    public string SteamId { get; set; } = null!;

    /// <summary>Whether the player is community banned.</summary>
    [JsonPropertyName("CommunityBanned")]
    public bool CommunityBanned { get; set; }

    /// <summary>Whether the player has VAC bans.</summary>
    [JsonPropertyName("VACBanned")]
    public bool VACBanned { get; set; }

    /// <summary>Number of VAC bans.</summary>
    [JsonPropertyName("NumberOfVACBans")]
    public int NumberOfVACBans { get; set; }

    /// <summary>Days since last ban.</summary>
    [JsonPropertyName("DaysSinceLastBan")]
    public int DaysSinceLastBan { get; set; }

    /// <summary>Number of game bans.</summary>
    [JsonPropertyName("NumberOfGameBans")]
    public int NumberOfGameBans { get; set; }

    /// <summary>Economy ban type (e.g. none, banned).</summary>
    [JsonPropertyName("EconomyBan")]
    public string EconomyBan { get; set; } = null!;
}

/// <summary>Response wrapper for GetPlayerBans.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PlayerBansResponse
{
    /// <summary>List of player ban records.</summary>
    [JsonPropertyName("players")]
    public List<Player> Players { get; set; } = null!;
}