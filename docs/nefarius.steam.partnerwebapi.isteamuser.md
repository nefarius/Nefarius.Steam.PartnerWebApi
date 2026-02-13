# ISteamUser

Namespace: Nefarius.Steam.PartnerWebApi

Used to access information and interact with users.

```csharp
public interface ISteamUser
```

## Methods

### <a id="methods-checkappownership"/>**CheckAppOwnership(String, String, String)**

Checks if the specified user owns the app.

```csharp
Task<AppOwnershipResponse> CheckAppOwnership(string apiKey, string ownerSteamId, string appId)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`ownerSteamId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steam ID of the user to check ownership for.

`appId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
AppID to check for ownership.

#### Returns

An instance of [AppOwnershipResponse](./nefarius.steam.partnerwebapi.models.appownershipresponse.md).

### <a id="methods-getapppriceinfo"/>**GetAppPriceInfo(String, String, String[])**

Gets the pricing information for one or more apps.

```csharp
Task<PriceInfoRequest> GetAppPriceInfo(string apiKey, string steamId, String[] appIds)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`steamId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
SteamID of user.

`appIds` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Array of app IDs (max: 100).

#### Returns

An instance of [PriceInfoRequest](./nefarius.steam.partnerwebapi.models.priceinforequest.md).

### <a id="methods-getdeletedsteamids"/>**GetDeletedSteamIDs(String, UInt64)**

You can use GetDeletedSteamIDs to retrieve a list of deleted accounts that owned your game(s) before deletion. This
 API was created to allow for the deletion of user related data for GDPR and other personal information related
 purposes.

```csharp
Task<DeletedSteamIdsResponse> GetDeletedSteamIDs(string apiKey, ulong rowVersion)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`rowVersion` [UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>
An unsigned 64-bit value used to page through deleted accounts. Pass 0 when calling this API
 for the first time, then pass the value returned from the previous call for each additional request. This value
 will need to be stored on your server for future calls.

#### Returns

An instance of [DeletedSteamIdsResponse](./nefarius.steam.partnerwebapi.models.deletedsteamidsresponse.md).

**Remarks:**

The provided Steamworks Publisher Key is used for both authentication and to generate the list of appids to
 check against.

### <a id="methods-getfriendlist"/>**GetFriendList(String, String, FriendListRelationship)**

TODO: can't test currently

```csharp
Task<Object> GetFriendList(string apiKey, string steamId, FriendListRelationship relationship)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`steamId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steam ID of the user whose friend list to retrieve.

`relationship` [FriendListRelationship](./nefarius.steam.partnerwebapi.models.friendlistrelationship.md)<br>
The type of relationship to filter by (e.g. friend, all).

#### Returns

[Task&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)

### <a id="methods-getplayerbans"/>**GetPlayerBans(String, String[])**

Gets player ban details.

```csharp
Task<PlayerBansResponse> GetPlayerBans(string apiKey, String[] steamIds)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`steamIds` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
One or more Steam IDs to query.

#### Returns

An instance of [PlayerBansResponse](./nefarius.steam.partnerwebapi.models.playerbansresponse.md).

### <a id="methods-getplayersummaries"/>**GetPlayerSummaries(String, String[])**

Returns basic profile information for a list of 64-bit Steam IDs.

```csharp
Task<PlayerSummariesResponse> GetPlayerSummaries(string apiKey, String[] steamIds)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`steamIds` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
One or more Steam IDs to query.

#### Returns

An instance of [PlayerSummariesResponse](./nefarius.steam.partnerwebapi.models.playersummariesresponse.md).

### <a id="methods-getpublisherappownership"/>**GetPublisherAppOwnership(String, String)**

Checks the app ownership status for a given Steam ID.

```csharp
Task<PublisherAppOwnershipResponse> GetPublisherAppOwnership(string apiKey, string steamId)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`steamId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
SteamID of user.

#### Returns

An instance of [PublisherAppOwnershipResponse](./nefarius.steam.partnerwebapi.models.publisherappownershipresponse.md).

### <a id="methods-getpublisherappownershipchanges"/>**GetPublisherAppOwnershipChanges(String, UInt64, UInt64)**

This method can be used to determine what SteamIDs have ownership changes starting from a particular package or key
 row version number. From the list of SteamIDs returned, a call to GetPublisherAppOwnership can then return the
 associated ownership data for the applications in the group associated with the key passed in. A partner may wish
 to track this data in conjunction with linked Steam Accounts to better understand the state of product ownership on
 Steam.

```csharp
Task<OwnershipChangesRequest> GetPublisherAppOwnershipChanges(string apiKey, ulong packageRowVersion, ulong cdKeyRowVersion)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`packageRowVersion` [UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>
The unsigned 64-bit row version to read package changes from. The row version of data
 read up to will be returned for use in future calls.

`cdKeyRowVersion` [UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>
The unsigned 64-bit row version to read CD Key changes from. The row version of data read
 up to will be returned for use in future calls.

#### Returns

An instance of [OwnershipChangesRequest](./nefarius.steam.partnerwebapi.models.ownershipchangesrequest.md).

### <a id="methods-getusergrouplist"/>**GetUserGroupList(String, String)**

TODO: can't test currently

```csharp
Task<Object> GetUserGroupList(string apiKey, string steamId)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`steamId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
SteamID of user.

#### Returns

[Task&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)

### <a id="methods-resolvevanityurl"/>**ResolveVanityURL(String, Uri)**

TODO: can't test currently

```csharp
Task<Object> ResolveVanityURL(string apiKey, Uri vanityUrl)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`vanityUrl` [Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri)<br>
The vanity URL (e.g. Steam community profile custom URL) to resolve to a Steam ID.

#### Returns

[Task&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)
