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
        PrivateScheduleDM GetPersonalSchedule();
        void UpdatePersonalSchedule(PrivateScheduleDM schedule);
        IEnumerable<SessionDM> GetPersonalScheduleID();
        void UpdatePersonalScheduleID(string idString);
        IEnumerable<SessionDM> GetCachedSessions();
        void UpdateCachedSessions(IEnumerable<SessionDM> sessions);
        DateTime GetSessionsCacheTime();
        void UpdateSessionCacheTime();
    }
}
