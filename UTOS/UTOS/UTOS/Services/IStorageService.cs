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
        Task<PrivateScheduleDM> GetPersonalSchedule();
        Task<bool> UpdatePersonalSchedule();
        Task<IEnumerable<SessionDM>> GetPersonalScheduleID();
        Task<bool> UpdatePersonalScheduleID();
        Task<IEnumerable<SessionDM>> GetCachedSessions();
        Task<bool> UpdateCachedSessions();
        Task<DateTime> GetSessionsCacheTime();
        Task<bool> UpdateSessionCacheTime();
    }
}
