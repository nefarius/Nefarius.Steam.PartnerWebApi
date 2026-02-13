# ISteamUserAuth

Namespace: Nefarius.Steam.PartnerWebApi

Used to access user authentication. Requires a publisher API key and must be called from a secure server, not from clients.

```csharp
public interface ISteamUserAuth
```

## Methods

### <a id="methods-authenticateuser"/>**AuthenticateUser(AuthenticateUserRequest)**

Authenticates a user using steamid, an RSA-encrypted session key, and an AES-encrypted loginkey. Callers must generate the 32-byte session key, encrypt it with Steam's RSA public key, and AES-encrypt the hashed loginkey with that session key; pass the encrypted blobs as base64 strings in the request.

```csharp
Task<AuthenticateUserResponse> AuthenticateUser(AuthenticateUserRequest request)
```

#### Parameters

`request` [AuthenticateUserRequest](./nefarius.steam.partnerwebapi.models.authenticateuserrequest.md)<br>
Form body with steamid, sessionkey (base64), and encrypted_loginkey (base64).

#### Returns

An instance of [AuthenticateUserResponse](./nefarius.steam.partnerwebapi.models.authenticateuserresponse.md).

### <a id="methods-authenticateuserticket"/>**AuthenticateUserTicket(String, UInt32, String, String)**

Validates an auth ticket from GetAuthTicketForWebApi and returns the user's 64-bit SteamID if valid. The ticket must be passed as a hexadecimal string. The identity string must match the one passed when creating the ticket.

```csharp
Task<AuthenticateUserTicketResponse> AuthenticateUserTicket(string apiKey, uint appId, string ticket, string identity)
```

#### Parameters

`apiKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Steamworks Web API publisher authentication key.

`appId` [UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>
AppID of the game.

`ticket` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Hexadecimal string of the binary ticket from GetAuthTicketForWebApi.

`identity` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Identifying string passed to GetAuthTicketForWebApi when the ticket was created.

#### Returns

An instance of [AuthenticateUserTicketResponse](./nefarius.steam.partnerwebapi.models.authenticateuserticketresponse.md) containing the user's SteamID and related data.

**Remarks:**

This call requires a publisher API key and MUST be called from a secure server, not from clients. Also available for game servers via api.steampowered.com using a Web API user authentication key (rate limited).
