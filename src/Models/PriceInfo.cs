using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>Price info for a package.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PriceInfo
{
    /// <summary>Package ID.</summary>
    [JsonPropertyName("packageid")]
    public int PackageId { get; set; }

    /// <summary>Currency code.</summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;

    /// <summary>Initial price.</summary>
    [JsonPropertyName("initial_price")]
    public int InitialPrice { get; set; }

    /// <summary>Final price.</summary>
    [JsonPropertyName("final_price")]
    public int FinalPrice { get; set; }

    /// <summary>Discount percentage.</summary>
    [JsonPropertyName("discount_percent")]
    public int DiscountPercent { get; set; }
}

/// <summary>Request payload for GetPriceInfo.</summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PriceInfoRequest
{
    /// <summary>Price info by key.</summary>
    [JsonPropertyName("price_info")]
    public Dictionary<string, PriceInfo?> PriceInfo { get; set; } = null!;
}