# AuthenticateUserResponse

Namespace: Nefarius.Steam.PartnerWebApi.Models

Response from AuthenticateUser. Steam docs do not specify a detailed shape; this wrapper allows for a generic
 response or result property.

```csharp
public sealed class AuthenticateUserResponse
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AuthenticateUserResponse](./nefarius.steam.partnerwebapi.models.authenticateuserresponse.md)

## Properties

### <a id="properties-response"/>**Response**

Optional response payload from the API.

```csharp
public object Response { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

## Constructors

### <a id="constructors-.ctor"/>**AuthenticateUserResponse()**

```csharp
public AuthenticateUserResponse()
```
