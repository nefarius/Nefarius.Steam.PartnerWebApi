using Nefarius.Steam.PartnerWebApi.Models;

using Refit;

namespace Nefarius.Steam.PartnerWebApi;

/// <summary>
///     Used to access information and interact with users.
/// </summary>
public interface ISteamUser
{
    /// <summary>
    ///     Checks if the specified user owns the app.
    /// </summary>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="ownerSteamId">Steamworks Web API publisher authentication key.</param>
    /// <param name="appId">AppID to check for ownership.</param>
    /// <returns>An instance of <see cref="AppOwnershipResponse" />.</returns>
    [Get("/ISteamUser/CheckAppOwnership/v2/")]
    Task<AppOwnershipResponse> CheckAppOwnership([AliasAs("key")] string apiKey,
        [AliasAs("steamid")] string ownerSteamId, [AliasAs("appid")] string appId);

    /// <summary>
    ///     This method can be used to determine what SteamIDs have ownership changes starting from a particular package or key
    ///     row version number. From the list of SteamIDs returned, a call to GetPublisherAppOwnership can then return the
    ///     associated ownership data for the applications in the group associated with the key passed in. A partner may wish
    ///     to track this data in conjunction with linked Steam Accounts to better understand the state of product ownership on
    ///     Steam.
    /// </summary>
    /// <example>
    ///     To begin, make a call to GetPublisherAppOwnershipChanges passing in packagerowversion and cdkeyrowversion with
    ///     the values of 0 (zero).
    /// </example>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="packageRowVersion">
    ///     The unsigned 64-bit row version to read package changes from. The row version of data
    ///     read up to will be returned for use in future calls.
    /// </param>
    /// <param name="cdKeyRowVersion">
    ///     The unsigned 64-bit row version to read CD Key changes from. The row version of data read
    ///     up to will be returned for use in future calls.
    /// </param>
    /// <returns>An instance of <see cref="OwnershipChangesRequest" />.</returns>
    [Get("/ISteamUser/GetPublisherAppOwnershipChanges/v1/")]
    Task<OwnershipChangesRequest> GetPublisherAppOwnershipChanges([AliasAs("key")] string apiKey,
        [AliasAs("packagerowversion")] ulong packageRowVersion = 0,
        [AliasAs("cdkeyrowversion")] ulong cdKeyRowVersion = 0);
}