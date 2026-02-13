# PlayerSummariesPlayer

Namespace: Nefarius.Steam.PartnerWebApi.Models

Player summary from GetPlayerSummaries.

```csharp
public sealed class PlayerSummariesPlayer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PlayerSummariesPlayer](./nefarius.steam.partnerwebapi.models.playersummariesplayer.md)

## Properties

### <a id="properties-avatar"/>**Avatar**

The full URL of the player's 32x32px avatar. If the user hasn't configured an avatar, this will be the default ?
 avatar.

```csharp
public Uri Avatar { get; set; }
```

#### Property Value

Uri<br>

### <a id="properties-avatarfull"/>**AvatarFull**

The full URL of the player's 184x184px avatar. If the user hasn't configured an avatar, this will be the default ?
 avatar.

```csharp
public Uri AvatarFull { get; set; }
```

#### Property Value

Uri<br>

### <a id="properties-avatarhash"/>**AvatarHash**

SHA1 hash of the avatar.

```csharp
public string AvatarHash { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-avatarmedium"/>**AvatarMedium**

The full URL of the player's 64x64px avatar. If the user hasn't configured an avatar, this will be the default ?
 avatar.

```csharp
public Uri AvatarMedium { get; set; }
```

#### Property Value

Uri<br>

### <a id="properties-communityvisibilitystate"/>**CommunityVisibilityState**

This represents whether the profile is visible or not, and if it is visible, why you are allowed to see it. Note
 that because this WebAPI does not use authentication, there are only two possible values returned: 1 - the profile
 is not visible to you (Private, Friends Only, etc), 3 - the profile is "Public", and the data is visible. Mike
 Blaszczak's
 post on Steam forums
 says, "The community visibility state this API returns is different than the privacy state. It's the effective
 visibility state from the account making the request to the account being viewed given the requesting
 account's relationship to the viewed account."

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

Current persona state.

```csharp
public PlayerSummariesPersonaState PersonaState { get; set; }
```

#### Property Value

[PlayerSummariesPersonaState](./nefarius.steam.partnerwebapi.models.playersummariespersonastate.md)<br>

### <a id="properties-personastateflags"/>**PersonaStateFlags**

Persona state flags.

```csharp
public Nullable<Int32> PersonaStateFlags { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-primaryclanid"/>**PrimaryClanId**

Primary clan ID.

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

Uri<br>

### <a id="properties-realname"/>**RealName**

Real name (if set and visible).

```csharp
public string RealName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-steamid"/>**SteamId**

64bit SteamID of the user

```csharp
public string SteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-timecreated"/>**TimeCreated**

Account creation time (Unix timestamp).

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
