using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.DataModels
{
    public class GroupingModel : ObservableCollection<SessionDM>
    {
        public string DisplayDate { get; set; }
    }
}
