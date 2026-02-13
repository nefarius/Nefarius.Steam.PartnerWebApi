# Player

Namespace: Nefarius.Steam.PartnerWebApi.Models

Player ban info from GetPlayerBans.

```csharp
public sealed class Player
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Player](./nefarius.steam.partnerwebapi.models.player.md)

## Properties

### <a id="properties-communitybanned"/>**CommunityBanned**

Whether the player is community banned.

```csharp
public bool CommunityBanned { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-dayssincelastban"/>**DaysSinceLastBan**

Days since last ban.

```csharp
public int DaysSinceLastBan { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-economyban"/>**EconomyBan**

Economy ban type (e.g. none, banned).

```csharp
public string EconomyBan { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-numberofgamebans"/>**NumberOfGameBans**

Number of game bans.

```csharp
public int NumberOfGameBans { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-numberofvacbans"/>**NumberOfVACBans**

Number of VAC bans.

```csharp
public int NumberOfVACBans { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-steamid"/>**SteamId**

Steam ID.

```csharp
public string SteamId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-vacbanned"/>**VACBanned**

Whether the player has VAC bans.

```csharp
public bool VACBanned { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### <a id="constructors-.ctor"/>**Player()**

```csharp
public Player()
```
