using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.API
{
    public class Sponsor
    {
        public int sponID { get; set; }
        public string companyName { get; set; }
        public string sponsorLevel { get; set; }
        public string companyDescription { get; set; }
        public string logoPath { get; set; }
        public string siteURL { get; set; }
        public string boothLocation { get; set; }

    }
}
