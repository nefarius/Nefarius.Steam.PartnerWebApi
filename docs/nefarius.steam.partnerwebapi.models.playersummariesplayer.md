# PlayerSummariesPlayer

Namespace: Nefarius.Steam.PartnerWebApi.Models

```csharp
public sealed class PlayerSummariesPlayer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PlayerSummariesPlayer](./nefarius.steam.partnerwebapi.models.playersummariesplayer.md)

## Properties

### <a id="properties-avatar"/>**Avatar**

The full URL of the player's 32x32px avatar. If the user hasn't configured an avatar, this will be the default avatar.

```csharp
public Uri Avatar { get; set; }
```

#### Property Value

[Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri)<br>

### <a id="properties-avatarfull"/>**AvatarFull**

The full URL of the player's 184x184px avatar. If the user hasn't configured an avatar, this will be the default avatar.

```csharp
public Uri AvatarFull { get; set; }
```

#### Property Value

[Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri)<br>

### <a id="properties-avatarhash"/>**AvatarHash**

SHA1 hash of the avatar.

```csharp
public string AvatarHash { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-avatarmedium"/>**AvatarMedium**

The full URL of the player's 64x64px avatar. If the user hasn't configured an avatar, this will be the default avatar.

```csharp
public Uri AvatarMedium { get; set; }
```

#### Property Value

[Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri)<br>

### <a id="properties-communityvisibilitystate"/>**CommunityVisibilityState**

```csharp
public CommunityVisibilityState CommunityVisibilityState { get; set; }
```

#### Property Value

[CommunityVisibilityState](./nefarius.steam.partnerwebapi.models.communityvisibilitystate.md)<br>

### <a id="properties-personaname"/>**PersonaName**

The player's persona name (display name)

```csharp
public string PersonaName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-personastate"/>**PersonaState**

```csharp
public PlayerSummariesPersonaState PersonaState { get; set; }
```

#### Property Value

[PlayerSummariesPersonaState](./nefarius.steam.partnerwebapi.models.playersummariespersonastate.md)<br>

### <a id="properties-personastateflags"/>**PersonaStateFlags**

```csharp
public Nullable<Int32> PersonaStateFlags { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-primaryclanid"/>**PrimaryClanId**

```csharp
public string PrimaryClanId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-profilestate"/>**ProfileState**

If set, indicates the user has a community profile configured (will be set to '1')

```csharp
public PlayerSummariesProfileState ProfileState { get; set; }
```

#### Property Value

[PlayerSummariesProfileState](./nefarius.steam.partnerwebapi.models.playersummariesprofilestate.md)<br>

### <a id="properties-profileurl"/>**ProfileUrl**

The full URL of the player's Steam Community profile.

```csharp
public Uri ProfileUrl { get; set; }
```

#### Property Value

[Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri)<br>

### <a id="properties-realname"/>**RealName**

```csharp
public string RealName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-steamid"/>**SteamId**

64-bit Steam ID of the user.

```csharp
public string SteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-timecreated"/>**TimeCreated**

```csharp
public Nullable<Int32> TimeCreated { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**PlayerSummariesPlayer()**

```csharp
public PlayerSummariesPlayer()
```
