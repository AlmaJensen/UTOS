using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;

namespace UTOS.Helpers
{
    public class ScheduleHelper
    {
        public IEnumerable<string> GetTracksFromSchedule(IEnumerable<SessionDM> sessions) =>
            (from s in sessions select s.Track).Distinct();
        public IEnumerable<string> GetDaysFromSchedule(IEnumerable<SessionDM> sessions) =>
            (from s in sessions select s.Date).Distinct();
    }
}
