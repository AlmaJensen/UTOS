using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.API
{
    public class Speaker
    {
        public int speakerid { get; set; }
        public string name { get; set; }
        public int? cfp_speakerid { get; set; }
        public int? joindin_speakerid { get; set; }
        public string twitter { get; set; }
        public object alt_twitter { get; set; }
        public string gravatar_hash { get; set; }
        public string updated_at { get; set; }
    }
}
