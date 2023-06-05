using Newtonsoft.Json;

namespace ISS.Model;

public class Root
{
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("people")]
    public List<People> People { get; set; }
}

