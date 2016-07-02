using FreshMvvm;
using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UTOS.DataModels;
using UTOS.Services;
using Xamarin.Forms;
using System.Linq;
using UTOS.Helpers;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class AllSessionsPageModel : FreshBasePageModel
    {
        public IDataManager dataManager;
        private List<SessionDM> completeList = new List<SessionDM>();
        ScheduleHelper helper = new ScheduleHelper();

        public List<string> Days { get; set; } = new List<string>();
        public List<string> Tracks { get; set; } = new List<string>();

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
            completeList = talks.ToList();
            Days = helper.GetDaysFromSchedule(talks).ToList();
            Tracks = helper.GetTracksFromSchedule(talks).ToList();
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
