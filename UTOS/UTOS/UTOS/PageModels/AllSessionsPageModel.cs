using FreshMvvm;
using PropertyChanged;
using System.Collections.ObjectModel;
using UTOS.DataModels;
using UTOS.Services;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class AllSessionsPageModel : FreshBasePageModel
    {
        public IDataManager dataManager;
        public AllSessionsPageModel(IDataManager dataService)
        {
            dataManager = dataService;
        }
        public override void Init(object initData)
        {
            base.Init(initData);
            LoadCollection();
        }

        private async void LoadCollection()
        {
            var talks = await dataManager.GetAllSessions();
            Sessions = new ObservableCollection<SessionDM>(talks);
        }
        SessionDM _selectedEntry;
        public SessionDM SelectedEntry
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
        public Command<SessionDM> EntrySelected
        {
            get
            {
                return new Command<SessionDM>(async (talk) => {
                    await CoreMethods.PushPageModel<TalkDetailPageModel>(talk);
                });
            }
        }
        public ObservableCollection<SessionDM> Sessions { get; set; } = new ObservableCollection<SessionDM>();
    }
}
