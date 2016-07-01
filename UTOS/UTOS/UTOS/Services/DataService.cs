using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;
using UTOS.DataModels;

namespace UTOS.Services
{
    public class DataService : IDataService
    {
        StorageService storage = new StorageService();
        public async Task<IEnumerable<SessionDM>> GetSessions()
        {
            var api = new API.API();
            var sessions =  await api.GetSessions();
            return ConvertSessions(sessions);
        }

        private IEnumerable<SessionDM> ConvertSessions(IEnumerable<Talk> sessions)
        {
            var talks = new List<SessionDM>();
            foreach(var s in sessions)
            {
                if (s.type == "Talk")
                    talks.Add(ModelConverters.ConvertTalkToDM(s));
            }
            return talks;
        }

        public async Task<IEnumerable<Sponsor>> GetSponsors()
        {
            var api = new API.API();
            return await api.GetSponsors();
        }
    }
}
