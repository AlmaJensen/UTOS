using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;
using UTOS.DataModels;

namespace UTOS.Services
{
    public class DataManager : IDataManager
    {
        IStorageService storageService = new StorageService();
        IDataService dataService = new DataService();

        public async Task<IEnumerable<SessionDM>> GetAllSessions()
        {
            var sessionData = storageService.GetCachedSessions();
            if (sessionData?.PlannedSessions != null)
            {
                if (sessionData.LastCacheDateTime < DateTime.Now.AddHours(-12))
                    await RefreshCache();
                return sessionData.PlannedSessions;
            }
            else
            {
                return await RefreshCache();
            }
        }

        private async Task<IEnumerable<SessionDM>> RefreshCache()
        {
            var sessions = await dataService.GetSessions();
            if(sessions != null)
            {
                var dm = new GeneralScheduleDM
                {
                    LastCacheDateTime = DateTime.Now,
                    PlannedSessions = sessions.ToList()
                };
                storageService.UpdateCachedSessions(dm);
            }
            return sessions;
        }


        public void AddToPersonalSchedule() { }
        public void RemoveFromPersonalSchedule() { }

    }
}
