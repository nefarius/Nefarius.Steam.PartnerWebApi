<img src="assets/NSS-128x128.png" align="right" />

# Nefarius.Steam.PartnerWebApi

[![.NET](https://github.com/nefarius/Nefarius.Steam.PartnerWebApi/actions/workflows/dotnet.yml/badge.svg)](https://github.com/nefarius/Nefarius.Steam.PartnerWebApi/actions/workflows/dotnet.yml) ![Requirements](https://img.shields.io/badge/Requires-.NET%20Standard%202.0-blue.svg) [![Nuget](https://img.shields.io/nuget/v/Nefarius.NuGet.Template)](https://www.nuget.org/packages/Nefarius.NuGet.Template/) [![Nuget](https://img.shields.io/nuget/dt/Nefarius.NuGet.Template)](https://www.nuget.org/packages/Nefarius.NuGet.Template/)

Steamworks Web API wrapper for .NET using [Refit](https://github.com/reactiveui/refit).

## About

TBD

## Example

```csharp
using Nefarius.Steam.PartnerWebApi;
using Nefarius.Steam.PartnerWebApi.Models;

using Refit;

string apiKey = "get api key from config file";

ISteamUser steamApi = RestService.For<ISteamUser>("https://partner.steam-api.com");

AppOwnershipResponse ownership = await steamApi.CheckAppOwnership(apiKey, "76561197992990756", "774361");

bool ownsApp = ownership.AppOwnership.OwnsApp;
```
