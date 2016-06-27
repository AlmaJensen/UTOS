using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.API
{
    public class DataResources
    {
        public const string SessionsURL = "http://www.openwest.org/custom/api.php?f=session_list&amp;h=1";
        public const string SponsorsURL = "http://www.openwest.org/custom/api.php?f=sponsor_list&amp;h=1";
        public const string MapURL = "http://www.openwest.org/custom/api.php?f=map_list";
    }
}
