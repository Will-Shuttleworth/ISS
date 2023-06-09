using ISS.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ISS.Services.CrewService;

public class CrewService : ICrewService
{
    HttpClient httpClient;

    public CrewService()
    {
        httpClient = new HttpClient();
    }

    public async Task<List<CrewMember>> GetCrewMembers()
    {
        List<CrewMember> _crewMembers = new List<CrewMember>();
        

        var url = "http://api.open-notify.org/astros.json";

        var response = await httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode) 
        {
            CrewMemberRoot rawContent = await response.Content.ReadFromJsonAsync<CrewMemberRoot>();
            _crewMembers = rawContent.CrewMembers;
        }

        return _crewMembers;
    }
}

