# AppOwnership

Namespace: Nefarius.Steam.PartnerWebApi.Models

Checks if the specified user owns the app.

```csharp
public sealed class AppOwnership
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppOwnership](./nefarius.steam.partnerwebapi.models.appownership.md)

## Properties

### <a id="properties-ownersteamid"/>**OwnerSteamId**

Indicates the true owner of the app.

```csharp
public string OwnerSteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-ownsapp"/>**OwnsApp**

Indicates if the user is the actual owner or the app.

```csharp
public bool OwnsApp { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-permanent"/>**Permanent**

Whether the user permanently owns your app. Not true for ownership via Family Sharing, free weekends, or site
 license.

```csharp
public bool Permanent { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-result"/>**Result**

Result code from the API.

```csharp
public string Result { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-sitelicense"/>**SiteLicense**

Indicates if user is borrowing this license from a PC Cafe site.

```csharp
public bool SiteLicense { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-timedtrial"/>**TimedTrial**

Indicates if this is a timed trial.

```csharp
public bool TimedTrial { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-timestamp"/>**Timestamp**

Time that the app was acquired.

```csharp
public DateTime Timestamp { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

## Constructors

### <a id="constructors-.ctor"/>**AppOwnership()**

```csharp
public AppOwnership()
```
