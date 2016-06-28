using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.API
{
    public class Talk
    {
        public int talkid { get; set; }
        public DateTime ts { get; set; }
        public string title { get; set; }
        public string track { get; set; }
        public string description { get; set; }
        public int joindin_sessionid { get; set; }
        public int duration { get; set; }
        public string type { get; set; }
        public List<Speaker> speakers { get; set; }
        public string date { get; set; }
        public string time { get; set; }

    }
}
