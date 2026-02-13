# AuthenticateUserRequest

Namespace: Nefarius.Steam.PartnerWebApi.Models

Request body for AuthenticateUser. Binary fields must be passed as base64 strings.

```csharp
public sealed class AuthenticateUserRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AuthenticateUserRequest](./nefarius.steam.partnerwebapi.models.authenticateuserrequest.md)

## Properties

### **SteamId**

The user's 64-bit SteamID (unencrypted).

```csharp
public string SteamId { get; set; }
```

### **SessionKeyBase64**

Base64-encoded 32-byte random session key, encrypted with RSA using Steam's public key.

```csharp
public string SessionKeyBase64 { get; set; }
```

### **EncryptedLoginKeyBase64**

Base64-encoded hashed loginkey, AES-encrypted with the session key.

```csharp
public string EncryptedLoginKeyBase64 { get; set; }
```
