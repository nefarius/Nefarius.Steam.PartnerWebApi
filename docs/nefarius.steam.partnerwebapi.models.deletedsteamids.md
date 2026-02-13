# DeletedSteamIds

Namespace: Nefarius.Steam.PartnerWebApi.Models

Deleted Steam IDs response from GetDeletedSteamIds.

```csharp
public sealed class DeletedSteamIds
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DeletedSteamIds](./nefarius.steam.partnerwebapi.models.deletedsteamids.md)

## Properties

### <a id="properties-rowversion"/>**RowVersion**

Row version for pagination.

```csharp
public ulong RowVersion { get; set; }
```

#### Property Value

[UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>

### <a id="properties-steamids"/>**SteamIds**

List of deleted Steam ID entries.

```csharp
public List<DeletedSteamIdEntry> SteamIds { get; set; }
```

#### Property Value

[List&lt;DeletedSteamIdEntry&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**DeletedSteamIds()**

```csharp
public DeletedSteamIds()
```
