using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     Response from AuthenticateUser. Steam docs do not specify a detailed shape; this wrapper allows for a generic
///     response or result property.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AuthenticateUserResponse
{
    /// <summary>
    ///     Optional response payload from the API.
    /// </summary>
    [JsonPropertyName("response")]
    public object? Response { get; set; }
}
