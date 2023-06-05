using ISS.Model;
using System.Net.Http.Json;

namespace ISS.Services.CrewService;

public class CrewService
{
    HttpClient httpClient;

    public CrewService()
    {
        httpClient = new HttpClient();
    }

    List<Root> crewMembersList = new();

    public async Task<List<Root>> GetCrewMembers()
    {
        if (crewMembersList?.Count > 0)
            return crewMembersList;

        var url = "http://api.open-notify.org/astros.json";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            crewMembersList = await response.Content.ReadFromJsonAsync<List<Root>>();
        }

        return crewMembersList;
    }
}

