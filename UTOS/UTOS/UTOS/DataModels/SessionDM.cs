using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.DataModels
{
    public class SessionDM
    {
        public int TalkId { get; set; }
        public string DateAndTime { get; set; }
        public string Title { get; set; }
        public string Track { get; set; }
        public string Description { get; set; }
        public SpeakerDM Speaker { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool AddedToSchedule { get; set; } = false;
    }
}
