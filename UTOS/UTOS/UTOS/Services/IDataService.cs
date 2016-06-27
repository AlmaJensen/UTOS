using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;

namespace UTOS.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Talk>> GetSessions();
        Task<IEnumerable<Sponsor>> GetSponsors();
    }
}
