

using System;

namespace ISS.Model;

class CrewMemberRoot
{
    public string Message { get; set; }
    public int Number { get; set; }
    public List<CrewMember> CrewMembers { get; set; }
}

