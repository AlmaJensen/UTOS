using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.Services;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class AboutPageModel : FreshBasePageModel
    {
        public IDataService DataService;
        public AboutPageModel(IDataService dataService)
        {
            DataService = dataService;
        }
    }
}
