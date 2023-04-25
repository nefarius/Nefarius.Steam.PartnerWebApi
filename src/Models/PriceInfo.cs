using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PriceInfo
{
    [JsonPropertyName("packageid")]
    public int PackageId { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("initial_price")]
    public int InitialPrice { get; set; }

    [JsonPropertyName("final_price")]
    public int FinalPrice { get; set; }

    [JsonPropertyName("discount_percent")]
    public int DiscountPercent { get; set; }
}

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class PriceInfoRequest
{
    [JsonPropertyName("price_info")]
    public Dictionary<string, PriceInfo?> PriceInfo { get; set; }
}