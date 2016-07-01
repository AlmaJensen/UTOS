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
        private enum StorageKeys { UserSchedule, LastCacheDate, CompleteSchedule, UserScheduleID}
        public void UpdateCachedSessions(GeneralScheduleDM sessions)
        {
            BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString());
            BlobCache.LocalMachine.InsertObject(StorageKeys.CompleteSchedule.ToString(), sessions);
        }
        public GeneralScheduleDM GetCachedSessions()
        {
            var response = BlobCache.LocalMachine.GetObject<GeneralScheduleDM> (StorageKeys.CompleteSchedule.ToString());
            return response as GeneralScheduleDM;
        }

        public void UpdatePersonalSchedule(PrivateScheduleDM schedule)
        {
            BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString(StorageKeys.UserSchedule.ToString()));
            BlobCache.LocalMachine.InsertObject(StorageKeys.UserSchedule.ToString(), schedule);
        }
        public PrivateScheduleDM GetPersonalSchedule()
        {
            var schedule = (PrivateScheduleDM)BlobCache.LocalMachine.GetObject<PrivateScheduleDM>(StorageKeys.UserSchedule.ToString());
            return schedule;
        }
    }
}
