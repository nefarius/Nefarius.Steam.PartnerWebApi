# OwnershipChanges

Namespace: Nefarius.Steam.PartnerWebApi.Models

Ownership changes from GetAppOwnershipChanges.

```csharp
public class OwnershipChanges
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OwnershipChanges](./nefarius.steam.partnerwebapi.models.ownershipchanges.md)

## Properties

### <a id="properties-cdkeyrowversion"/>**CdKeyRowVersion**

CD key row version for pagination.

```csharp
public ulong CdKeyRowVersion { get; set; }
```

#### Property Value

[UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>

### <a id="properties-moredata"/>**MoreData**

Whether more data is available.

```csharp
public bool MoreData { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-packagerowversion"/>**PackageRowVersion**

Package row version for pagination.

```csharp
public ulong PackageRowVersion { get; set; }
```

#### Property Value

[UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>

### <a id="properties-steamids"/>**Steamids**

List of Steam ID entries.

```csharp
public List<SteamIdEntry> Steamids { get; set; }
```

#### Property Value

[List&lt;SteamIdEntry&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**OwnershipChanges()**

```csharp
public OwnershipChanges()
```
