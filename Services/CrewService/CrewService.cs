using ISS.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ISS.Services.CrewService;

public class CrewService
{
    HttpClient httpClient;

    public CrewService()
    {
        httpClient = new HttpClient();
    }

    public async Task<CrewMemberRoot> GetCrewMembers()
    {
        CrewMemberRoot _crewMember = new CrewMemberRoot();
        

        var url = "http://api.open-notify.org/astros.json";

        var response = await httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode) 
        {
            _crewMember = await response.Content.ReadFromJsonAsync<CrewMemberRoot>();
        }

        return _crewMember;
    }
}

