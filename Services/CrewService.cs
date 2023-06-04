using System.Net.Http.Json;

namespace ISS.Services;

public class CrewService
{
    HttpClient httpClient;

    public CrewService()
    {
        httpClient = new HttpClient();
    }

    List<Crew> crewList = new();

    public async Task<List<Crew>> GetCrew()
    {
        if (crewList.Count > 0)
            return crewList;

        string url = "http://api.open-notify.org/astros.json";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            crewList = await response.Content.ReadFromJsonAsync<List<Crew>>();
        }

        return crewList;
    }
}

