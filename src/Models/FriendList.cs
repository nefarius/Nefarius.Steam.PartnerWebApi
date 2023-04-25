using System.Runtime.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     Relationship filter
/// </summary>
public enum FriendListRelationship
{
    [EnumMember(Value = "all")]
    All,
    [EnumMember(Value = "friend")]
    Friend
}