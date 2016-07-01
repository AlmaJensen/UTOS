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

        void UpdateCachedSessions(GeneralScheduleDM sessions);
        GeneralScheduleDM GetCachedSessions();

        void UpdatePersonalSchedule(PrivateScheduleDM schedule);
        PrivateScheduleDM GetPersonalSchedule();
    }
}
