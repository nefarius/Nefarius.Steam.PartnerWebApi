using System.Diagnostics.CodeAnalysis;

using Nefarius.Steam.PartnerWebApi.Models;

using Refit;

namespace Nefarius.Steam.PartnerWebApi;

/// <summary>
///     Used to access user authentication. Requires a publisher API key and must be called from a secure server, not from
///     clients.
/// </summary>
/// <remarks>
///     See <see href="https://partner.steamgames.com/doc/webapi/isteamuserauth">ISteamUserAuth</see> for Steam
///     documentation.
/// </remarks>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public interface ISteamUserAuth
{
    /// <summary>
    ///     Authenticates a user using steamid, an RSA-encrypted session key, and an AES-encrypted loginkey. Callers must
    ///     generate the 32-byte session key, encrypt it with Steam's RSA public key, and AES-encrypt the hashed loginkey
    ///     with that session key; pass the encrypted blobs as base64 strings in the request.
    /// </summary>
    /// <param name="request">Form body with steamid, sessionkey (base64), and encrypted_loginkey (base64).</param>
    /// <returns>An instance of <see cref="AuthenticateUserResponse" />.</returns>
    [Post("/ISteamUserAuth/AuthenticateUser/v1/")]
    Task<AuthenticateUserResponse> AuthenticateUser(
        [Body(BodySerializationMethod.UrlEncoded)]
        AuthenticateUserRequest request);

    /// <summary>
    ///     Validates an auth ticket from GetAuthTicketForWebApi and returns the user's 64-bit SteamID if valid. The ticket
    ///     must be passed as a hexadecimal string. The identity string must match the one passed when creating the ticket.
    /// </summary>
    /// <remarks>
    ///     This call requires a publisher API key and MUST be called from a secure server, not from clients. Also
    ///     available for game servers via api.steampowered.com using a Web API user authentication key (rate limited).
    /// </remarks>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="appId">AppID of the game.</param>
    /// <param name="ticket">Hexadecimal string of the binary ticket from GetAuthTicketForWebApi.</param>
    /// <param name="identity">Identifying string passed to GetAuthTicketForWebApi when the ticket was created.</param>
    /// <returns>An instance of <see cref="AuthenticateUserTicketResponse" /> containing the user's SteamID and related data.</returns>
    [Get("/ISteamUserAuth/AuthenticateUserTicket/v1/")]
    Task<AuthenticateUserTicketResponse> AuthenticateUserTicket(
        [AliasAs("key")] string apiKey,
        [AliasAs("appid")] uint appId,
        [AliasAs("ticket")] string ticket,
        [AliasAs("identity")] string identity);
}