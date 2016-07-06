using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;
using UTOS.Helpers;
using UTOS.Services;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class PrivateSchedulePageModel : FreshBasePageModel
    {
        private IDataManager dataManager;
        ScheduleHelper helper = new ScheduleHelper();
        public ObservableCollection<SessionDM> Sessions { get; set; } = new ObservableCollection<SessionDM>();
        public PrivateSchedulePageModel(IDataManager dataService)
        {
            dataManager = dataService;
        }
        public override void Init(object initData)
        {
            base.Init(initData);            
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            LoadCollection();
        }

        private async void LoadCollection()
        {
            var sessions = await dataManager.GetAllSessions();
            var toload = helper.SessionInSchedule(sessions);

            Sessions.Clear();
            foreach (var s in toload)
                Sessions.Add(s);

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
    }
}
