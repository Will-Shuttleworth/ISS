using System.Net.Http.Json;

namespace ISS.Services;

public class SpaceStationService
{
    HttpClient httpClient;

    public SpaceStationService()
    {
        httpClient = new HttpClient();
    }

    List<SpaceStation> locationList = new();

    public async Task<List<SpaceStation>> GetSpaceStationLocation()
    {
        if (locationList.Count > 0)
            return locationList;

        var url = "http://api.open-notify.org/iss-now.json";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            locationList =  await response.Content.ReadFromJsonAsync<List<SpaceStation>>();
        }

        return locationList;
    }
}

