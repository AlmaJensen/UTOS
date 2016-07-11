using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.DataModels
{
    public class SpeakerGroupingModel : ObservableCollection<SpeakerDM>
    {
        public string GroupName { get; set; }
        public string ShortName { get; set; } //will be used for jump lists
    }
}
