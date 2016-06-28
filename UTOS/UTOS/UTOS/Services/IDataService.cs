using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;
using UTOS.DataModels;

namespace UTOS.Services
{
    public interface IDataService
    {
        Task<IEnumerable<SessionDM>> GetSessions();
        Task<IEnumerable<Sponsor>> GetSponsors();
    }
}
