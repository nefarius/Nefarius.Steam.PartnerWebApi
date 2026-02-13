using System.Runtime.Serialization;

namespace Nefarius.Steam.PartnerWebApi.Models;

/// <summary>
///     Relationship filter for friend list.
/// </summary>
public enum FriendListRelationship
{
    /// <summary>All relationships.</summary>
    [EnumMember(Value = "all")]
    All,

    /// <summary>Friend only.</summary>
    [EnumMember(Value = "friend")]
    Friend
}