using System;
using System.Collections.Generic;
using System.Text.Json.Serialization; 

namespace ISS.Model;

public class CrewMemberRoot
{
    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("people")]
    public List<CrewMember> CrewMembers { get; set; }
}
