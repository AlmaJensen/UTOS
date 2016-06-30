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
        public void UpdateCachedSessions(IEnumerable<SessionDM> sessions)
        {
            BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString());
            BlobCache.LocalMachine.InsertObject(StorageKeys.CompleteSchedule.ToString(), sessions);
        }
        public IEnumerable<SessionDM> GetCachedSessions()
        {
            var response = BlobCache.LocalMachine.GetObject<SessionDM> (StorageKeys.CompleteSchedule.ToString());
            return response as IEnumerable<SessionDM>;
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

        public void UpdatePersonalScheduleID(string idString)
        {
            BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString(StorageKeys.UserScheduleID.ToString()));
            BlobCache.LocalMachine.InsertObject(StorageKeys.UserSchedule.ToString(), idString);
        }
        public string GetPersonalScheduleID()
        {
            var id = BlobCache.LocalMachine.GetObject<PrivateScheduleDM>(StorageKeys.UserScheduleID.ToString());
            return id.ToString();
        }


        public void UpdateSessionCacheTime(DateTime time)
        {
            BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString(StorageKeys.LastCacheDate.ToString()));
            BlobCache.LocalMachine.InsertObject(StorageKeys.UserSchedule.ToString(), time);
        }
        public DateTime GetSessionsCacheTime()
        {
            var time = BlobCache.LocalMachine.GetObject<PrivateScheduleDM>(StorageKeys.LastCacheDate.ToString());
            return DateTime.Now;
        }
    }
}
