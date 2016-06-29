using Akavache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;

namespace UTOS.Services
{
    public class StorageService : IStorageService
    {
        private enum StorageKeys { UserSchedule, LastCacheDate, CompleteSchedule, }
        public Task<IEnumerable<SessionDM>> GetCachedSessions()
        {
            
        }

        public Task<PrivateScheduleDM> GetPersonalSchedule()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SessionDM>> GetPersonalScheduleID()
        {
            throw new NotImplementedException();
        }

        public Task<DateTime> GetSessionsCacheTime()
        {
            throw new NotImplementedException();
        }

        public void UpdateCachedSessions(IEnumerable<SessionDM> sessions)
        {
           BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString());
           BlobCache.LocalMachine.InsertObject(StorageKeys.CompleteSchedule.ToString(), sessions);
        }

        public Task<bool> UpdatePersonalSchedule()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePersonalScheduleID()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSessionCacheTime()
        {
            throw new NotImplementedException();
        }




    }
}
