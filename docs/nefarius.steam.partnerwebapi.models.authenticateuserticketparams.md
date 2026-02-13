# AuthenticateUserTicketParams

Namespace: Nefarius.Steam.PartnerWebApi.Models

Parameters returned by AuthenticateUserTicket.

```csharp
public sealed class AuthenticateUserTicketParams
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AuthenticateUserTicketParams](./nefarius.steam.partnerwebapi.models.authenticateuserticketparams.md)

## Properties

### <a id="properties-ownersteamid"/>**OwnerSteamId**

The 64-bit SteamID of the game owner (may differ from steamid if using Steam Family Sharing).

```csharp
public string OwnerSteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-publisherbanned"/>**PublisherBanned**

Whether the user has a publisher ban.

```csharp
public bool PublisherBanned { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-result"/>**Result**

Status of the authentication (e.g. "OK").

```csharp
public string Result { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-steamid"/>**SteamId**

The 64-bit SteamID of the authenticated user.

```csharp
public string SteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-vacbanned"/>**VacBanned**

Whether the user has a VAC ban.

```csharp
public bool VacBanned { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### <a id="constructors-.ctor"/>**AuthenticateUserTicketParams()**

```csharp
public AuthenticateUserTicketParams()
```
