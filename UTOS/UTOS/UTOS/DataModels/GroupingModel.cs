using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.DataModels
{
    public class GroupingModel
    {
        public string DisplayDate { get; set; }
        public List<SessionDM> GroupedSessions { get; set; }
    }
}
