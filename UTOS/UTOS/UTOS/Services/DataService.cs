using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;

namespace UTOS.Services
{
    public class DataService : IDataService
    {

        public async Task<IEnumerable<Talk>> GetSessions()
        {
            var api = new API.API();
            return await api.GetSessions();
        }

        public async Task<IEnumerable<Sponsor>> GetSponsors()
        {
            var api = new API.API();
            return await api.GetSponsors();
        }
    }
}
