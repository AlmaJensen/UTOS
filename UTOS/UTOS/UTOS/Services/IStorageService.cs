using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;

namespace UTOS.Services
{
    public interface IStorageService
    {

        void UpdateCachedSessions(IEnumerable<SessionDM> sessions);
        IEnumerable<SessionDM> GetCachedSessions();

        void UpdatePersonalSchedule(PrivateScheduleDM schedule);
        PrivateScheduleDM GetPersonalSchedule();

        void UpdatePersonalScheduleID(string idString);
        string GetPersonalScheduleID();

        

        DateTime GetSessionsCacheTime();
        void UpdateSessionCacheTime(DateTime time);
    }
}
