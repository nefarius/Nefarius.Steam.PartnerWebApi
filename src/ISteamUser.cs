using System.Diagnostics.CodeAnalysis;

using Nefarius.Steam.PartnerWebApi.Models;

using Refit;

namespace Nefarius.Steam.PartnerWebApi;

/// <summary>
///     Used to access information and interact with users.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
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

    /// <summary>
    ///     Gets the pricing information for one or more apps.
    /// </summary>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="steamId">SteamID of user.</param>
    /// <param name="appIds">Array of app IDs (max: 100).</param>
    /// <returns>An instance of <see cref="PriceInfoRequest" />.</returns>
    [Get("/ISteamUser/GetAppPriceInfo/v1/")]
    Task<PriceInfoRequest> GetAppPriceInfo([AliasAs("key")] string apiKey, [AliasAs("steamid")] string steamId,
        [AliasAs("appids")] [Query(CollectionFormat.Csv)]
        string[] appIds);

    /// <summary>
    ///     You can use GetDeletedSteamIDs to retrieve a list of deleted accounts that owned your game(s) before deletion. This
    ///     API was created to allow for the deletion of user related data for GDPR and other personal information related
    ///     purposes.
    /// </summary>
    /// <remarks>
    ///     The provided Steamworks Publisher Key is used for both authentication and to generate the list of appids to
    ///     check against.
    /// </remarks>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="rowVersion">
    ///     An unsigned 64-bit value used to page through deleted accounts. Pass 0 when calling this API
    ///     for the first time, then pass the value returned from the previous call for each additional request. This value
    ///     will need to be stored on your server for future calls.
    /// </param>
    /// <returns>An instance of <see cref="DeletedSteamIdsResponse" />.</returns>
    [Get("/ISteamUser/GetDeletedSteamIDs/v1/")]
    Task<DeletedSteamIdsResponse> GetDeletedSteamIDs([AliasAs("key")] string apiKey,
        [AliasAs("rowversion")] ulong rowVersion = 0);

    /// <summary>
    ///     TODO: can't test currently
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="steamId"></param>
    /// <param name="relationship"></param>
    /// <returns></returns>
    [Get("/ISteamUser/GetFriendList/v1/")]
    Task<dynamic> GetFriendList([AliasAs("key")] string apiKey, [AliasAs("steamid")] string steamId,
        [AliasAs("relationship")] FriendListRelationship relationship = FriendListRelationship.Friend);

    /// <summary>
    ///     Gets player ban details.
    /// </summary>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="steamIds">One or more Steam IDs to query.</param>
    /// <returns>An instance of <see cref="PlayerBansResponse" />.</returns>
    [Get("/ISteamUser/GetPlayerBans/v1/")]
    Task<PlayerBansResponse> GetPlayerBans([AliasAs("key")] string apiKey,
        [AliasAs("steamids")] [Query(CollectionFormat.Csv)] string[] steamIds);

    /// <summary>
    ///     Returns basic profile information for a list of 64-bit Steam IDs.
    /// </summary>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="steamIds">One or more Steam IDs to query.</param>
    /// <returns>An instance of <see cref="PlayerSummariesResponse" />.</returns>
    [Get("/ISteamUser/GetPlayerSummaries/v2/")]
    Task<PlayerSummariesResponse> GetPlayerSummaries([AliasAs("key")] string apiKey,
        [AliasAs("steamids")] [Query(CollectionFormat.Csv)] string[] steamIds);

    /// <summary>
    ///     Checks the app ownership status for a given Steam ID.  
    /// </summary>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="steamId">SteamID of user.</param>
    /// <returns>An instance of <see cref="PublisherAppOwnershipResponse" />.</returns>
    [Get("/ISteamUser/GetPublisherAppOwnership/v3/")]
    Task<PublisherAppOwnershipResponse> GetPublisherAppOwnership([AliasAs("key")] string apiKey,
        [AliasAs("steamid")] string steamId);

    /// <summary>
    ///     TODO: can't test currently
    /// </summary>
    /// <param name="apiKey">Steamworks Web API publisher authentication key.</param>
    /// <param name="steamId">SteamID of user.</param>
    /// <returns></returns>
    [Get("/ISteamUser/GetUserGroupList/v1/")]
    Task<dynamic> GetUserGroupList([AliasAs("key")] string apiKey, [AliasAs("steamid")] string steamId);

    /// <summary>
    ///     TODO: can't test currently
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="vanityUrl"></param>
    /// <returns></returns>
    [Get("/ISteamUser/ResolveVanityURL/v1/")]
    Task<dynamic> ResolveVanityURL([AliasAs("key")] string apiKey, [AliasAs("vanityurl")] Uri vanityUrl);
}