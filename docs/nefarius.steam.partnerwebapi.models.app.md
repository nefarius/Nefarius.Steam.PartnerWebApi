# App

Namespace: Nefarius.Steam.PartnerWebApi.Models

App entry in publisher app ownership.

```csharp
public sealed class App
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [App](./nefarius.steam.partnerwebapi.models.app.md)

## Properties

### <a id="properties-appid"/>**AppId**

App ID.

```csharp
public int AppId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-ownersteamid"/>**OwnerSteamId**

Owner Steam ID.

```csharp
public string OwnerSteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-ownsapp"/>**OwnsApp**

Whether the user owns the app.

```csharp
public bool OwnsApp { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-permanent"/>**Permanent**

Whether ownership is permanent.

```csharp
public bool Permanent { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-sitelicense"/>**Sitelicense**

Whether this is a site license.

```csharp
public bool Sitelicense { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-timedtrial"/>**TimedTrial**

Whether this is a timed trial.

```csharp
public bool TimedTrial { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-timeexpired"/>**TimeExpired**

When the license expires (if applicable).

```csharp
public string TimeExpired { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-timestamp"/>**Timestamp**

When the app was acquired.

```csharp
public DateTime Timestamp { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### <a id="properties-usercanceled"/>**UserCanceled**

Whether the user canceled.

```csharp
public bool UserCanceled { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### <a id="constructors-.ctor"/>**App()**

```csharp
public App()
```
