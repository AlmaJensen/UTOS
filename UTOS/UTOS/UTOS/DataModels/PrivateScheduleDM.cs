using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.DataModels
{
    public class PrivateScheduleDM
    {
        public string UTOSScheduleID { get; set; }
        public List<SessionDM> PlannedSessions { get; set; }
    }
}
