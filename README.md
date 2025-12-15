# <img src="assets/NSS-128x128.png" align="left" />Nefarius.Steam.PartnerWebApi

[![.NET](https://github.com/nefarius/Nefarius.Steam.PartnerWebApi/actions/workflows/dotnet.yml/badge.svg)](https://github.com/nefarius/Nefarius.Steam.PartnerWebApi/actions/workflows/dotnet.yml)
![Requirements](https://img.shields.io/badge/Requires-.NET%20Standard%202.0-blue.svg)
[![Nuget](https://img.shields.io/nuget/v/Nefarius.Steam.PartnerWebApi)](https://www.nuget.org/packages/Nefarius.Steam.PartnerWebApi/)
[![Nuget](https://img.shields.io/nuget/dt/Nefarius.Steam.PartnerWebApi)](https://www.nuget.org/packages/Nefarius.Steam.PartnerWebApi/)

Steamworks Web API wrapper for .NET using [Refit](https://github.com/reactiveui/refit).

> [!IMPORTANT]
> This project is still evolving, so API-breaking changes might occur each update!

## About

A thin dotnet wrapper library for the Steamworks Web API that will grow with the author's needs.

Currently only covers parts of the `ISteamUser` interface.

## API Access

This API requires a
special [publisher web API key](https://partner.steamgames.com/doc/webapi_overview/auth#publisher-keys) you can only
obtain as a partner. This is **not the same** as the [Steam Web API Key](https://steamcommunity.com/dev/apikey) anyone
with a Steam account can register. Do not expect this library to work with such a key.

## Documentation

[Link to API docs](docs/index.md).

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

## 3rd party credits

- [Refit](https://github.com/reactiveui/refit)
- [Steamworks Web API Reference](https://partner.steamgames.com/doc/webapi)
- [Steam Web API](https://developer.valvesoftware.com/wiki/Steam_Web_API)
- [STEAMID I/O](https://steamid.io/)
