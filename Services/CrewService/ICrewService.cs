using ISS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.Services.CrewService
{
    public interface ICrewService
    {
        Task<List<CrewMember>> GetCrewMembers();
    }
}
