using Newtonsoft.Json;

namespace ISS.Model;

public class IssPositionRoot
{
    [JsonProperty("iss_position")]
    public IssPosition IssPosition { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("timestamp")]
    public int Timestamp { get; set; }
}

