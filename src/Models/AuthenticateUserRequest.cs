using System.Diagnostics.CodeAnalysis;

using Refit;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     Request body for AuthenticateUser. Binary fields must be passed as base64 strings (e.g.
///     <c>Convert.ToBase64String(encryptedBytes)</c>).
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AuthenticateUserRequest
{
    /// <summary>
    ///     The user's 64-bit SteamID (unencrypted).
    /// </summary>
    [AliasAs("steamid")]
    public string SteamId { get; set; } = null!;

    /// <summary>
    ///     Base64-encoded 32-byte random session key, encrypted with RSA using Steam's public key.
    /// </summary>
    [AliasAs("sessionkey")]
    public string SessionKeyBase64 { get; set; } = null!;

    /// <summary>
    ///     Base64-encoded hashed loginkey, AES-encrypted with the session key.
    /// </summary>
    [AliasAs("encrypted_loginkey")]
    public string EncryptedLoginKeyBase64 { get; set; } = null!;
}