using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;
using UTOS.Services;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class SponsorsPageModel : FreshBasePageModel
    {
        public IDataService DataService;
        public ObservableCollection<Sponsor> Sessions { get; set; } = new ObservableCollection<Sponsor>();
        public SponsorsPageModel(IDataService dataService)
        {
            DataService = dataService;
        }
        private async void LoadCollection()
        {
            var sponsors = await DataService.GetSponsors();
            Sessions = new ObservableCollection<Sponsor>(sponsors);
        }
    }
}
