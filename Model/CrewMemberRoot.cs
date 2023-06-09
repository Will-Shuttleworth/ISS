using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ISS.Model;

public class CrewMemberRoot
{
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("people")]
    public List<CrewMember> CrewMembers { get; set; }
}
