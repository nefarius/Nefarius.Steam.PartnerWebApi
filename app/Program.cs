// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;

using Nefarius.Steam.PartnerWebApi;
using Nefarius.Steam.PartnerWebApi.Models;

using Refit;

IConfigurationBuilder builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("config.json", false);

IConfiguration config = builder.Build();

string? apiKey = config.GetSection("ApiKey").Get<string>();

if (apiKey is null)
{
    throw new InvalidOperationException("API Key missing, can't continue!");
}


ISteamUser steamApi = RestService.For<ISteamUser>("https://partner.steam-api.com");

// TODO: implement me!

//var result = await steamApi.GetPlayerSummaries(apiKey, new[] { "76561197992990756", "76561197969911571" });

var result = await steamApi.GetPublisherAppOwnership(apiKey, "76561197992990756");

Console.ReadKey();