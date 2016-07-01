using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.DataModels
{
    public class GeneralScheduleDM
    {
        public DateTime LastCacheDateTime { get; set; }
        public List<SessionDM> PlannedSessions { get; set; }
    }
}
