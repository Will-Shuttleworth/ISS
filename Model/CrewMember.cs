using Newtonsoft.Json;

namespace ISS.Model;

public class CrewMember
{
    [JsonProperty("craft")]
    public string Craft { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

}

