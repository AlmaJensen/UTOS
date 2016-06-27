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
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class AllSessionsPageModel : FreshBasePageModel
    {
        public IDataService DataService;
        public AllSessionsPageModel(IDataService dataService)
        {
            DataService = dataService;
        }
        public override void Init(object initData)
        {
            base.Init(initData);
            LoadCollection();
            Sessions = new ObservableCollection<Talk>();
        }

        private async void LoadCollection()
        {
            var talks = await DataService.GetSessions();
            Sessions = new ObservableCollection<Talk>(talks);
        }
        Talk _selectedEntry;
        public Talk SelectedEntry
        {
            get
            {
                return _selectedEntry;
            }
            set
            {
                _selectedEntry = value;
                if (value != null)
                    EntrySelected.Execute(value);
            }
        }
        public Command<Talk> EntrySelected
        {
            get
            {
                return new Command<Talk>(async (talk) => {
                    await CoreMethods.PushPageModel<TalkDetailPageModel>(talk);
                });
            }
        }
        public ObservableCollection<Talk> Sessions { get; set; } = new ObservableCollection<Talk>();
    }
}
