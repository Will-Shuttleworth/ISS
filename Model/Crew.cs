using System.Text.Json.Serialization;

namespace ISS.Model;

public class Crew
{
    public class CrewMember
    {
        public string Craft { get; set; }
        public string Name { get; set; }
    }

    public class Root
    {
        public string Message { get; set; }
        public int Number { get; set; }
        public List<CrewMember> CrewMembers { get; set; }
    }

}

