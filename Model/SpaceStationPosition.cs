using Newtonsoft.Json;

namespace ISS.Model;

public class IssPosition
{
    [JsonProperty("latitude")]
    public string Latitude { get; set; }

    [JsonProperty("longitude")]
    public string Longitude { get; set; }
}

