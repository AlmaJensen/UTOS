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
        //private string dateFormat = "ddd, H:mm";
        public IEnumerable<string> GetTracksFromSchedule(IEnumerable<SessionDM> sessions)
        {
            var tracks = (from s in sessions select s.Track).Distinct();
            return tracks;
        }
        public IEnumerable<string> GetDaysFromSchedule(IEnumerable<SessionDM> sessions) =>
            (from s in sessions select s.Date).Distinct();
        public IEnumerable<string> GetDaysAndTimesFromSchedule(IEnumerable<SessionDM> sessions) =>
            (from s in sessions select s.DateAndTime).Distinct();

        public IEnumerable<SessionDM> FilterSessionsByTrack(string track, IEnumerable<SessionDM> sessions) =>
            (from s in sessions
             where s.Track == track
             select s);
        public IEnumerable<SessionDM> FilterSessionsByDay(string day, IEnumerable<SessionDM> sessions) =>
            (from s in sessions
             where s.Date == day
             select s);
        public IEnumerable<SessionDM> FilterSessionsBySearch(string searchValue, IEnumerable<SessionDM> sessions)
        {
            var d = searchValue.ToUpper();
            return (from s in sessions
                    where s.Title.ToUpper().Contains(d) ||
                    s.Description.ToUpper().Contains(d) ||
                    s.Date.ToUpper().Contains(d) ||
                    s.Track.ToUpper().Contains(d) ||
                    s.Speaker.Name.ToUpper().Contains(d)
                    select s);
        }

        public IEnumerable<SessionDM> SessionInSchedule(IEnumerable<SessionDM> sessions) =>
            (from s in sessions
             where s.AddedToSchedule == true
             select s);
        public IEnumerable<GroupingModel> SessionGrooper(IEnumerable<SessionDM> sessions)
        {
            var sorted = new List<GroupingModel>();
            var days = GetDaysAndTimesFromSchedule(sessions);
            foreach (var d in days)
                sorted.Add(new GroupingModel { DisplayDate = d });
            foreach(var s in sessions)
            {
                var group = sorted.FindIndex(x => x.DisplayDate == s.DateAndTime);
                sorted[group].Add(s);
            }
            return sorted;
        }
    }   
}
