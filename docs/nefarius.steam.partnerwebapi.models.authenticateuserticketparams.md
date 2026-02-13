# AuthenticateUserTicketParams

Namespace: Nefarius.Steam.PartnerWebApi.Models

Parameters returned by AuthenticateUserTicket.

```csharp
public sealed class AuthenticateUserTicketParams
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AuthenticateUserTicketParams](./nefarius.steam.partnerwebapi.models.authenticateuserticketparams.md)

## Properties

### **Result**

Status of the authentication (e.g. "OK").

```csharp
public string Result { get; set; }
```

### **SteamId**

The 64-bit SteamID of the authenticated user.

```csharp
public string SteamId { get; set; }
```

### **OwnerSteamId**

The 64-bit SteamID of the game owner (may differ from steamid if using Steam Family Sharing).

```csharp
public string OwnerSteamId { get; set; }
```

### **VacBanned**

Whether the user has a VAC ban.

```csharp
public bool VacBanned { get; set; }
```

### **PublisherBanned**

Whether the user has a publisher ban.

```csharp
public bool PublisherBanned { get; set; }
```
