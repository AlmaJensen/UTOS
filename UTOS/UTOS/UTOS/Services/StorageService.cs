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


        public void UpdateCachedSessions(IEnumerable<SessionDM> sessions)
        {
           BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString());
           BlobCache.LocalMachine.InsertObject(StorageKeys.CompleteSchedule.ToString(), sessions);
        }





        PrivateScheduleDM IStorageService.GetPersonalSchedule()
        {
            var schedule = (PrivateScheduleDM)BlobCache.LocalMachine.GetObject<PrivateScheduleDM>(StorageKeys.UserSchedule.ToString());

        }

        public void UpdatePersonalSchedule(PrivateScheduleDM schedule)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SessionDM> IStorageService.GetPersonalScheduleID()
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonalScheduleID(string idString)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SessionDM> IStorageService.GetCachedSessions()
        {
            throw new NotImplementedException();
        }

        DateTime IStorageService.GetSessionsCacheTime()
        {
            throw new NotImplementedException();
        }

        void IStorageService.UpdateSessionCacheTime()
        {
            throw new NotImplementedException();
        }
    }
}
