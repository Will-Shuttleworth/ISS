using Newtonsoft.Json;

namespace ISS.Model;

public class People
{
    [JsonProperty("craft")]
    public string Craft { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

