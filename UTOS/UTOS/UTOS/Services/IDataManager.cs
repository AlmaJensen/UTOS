using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;

namespace UTOS.Services
{
    public interface IDataManager
    {
        Task<IEnumerable<SessionDM>> GetAllSessions();
        void UpdateSingleSession(SessionDM session);
    }
}
