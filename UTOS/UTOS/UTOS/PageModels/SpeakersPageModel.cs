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
    public class SpeakersPageModel : FreshBasePageModel
    {
        public ObservableCollection<SpeakerGroupingModel> Speakers { get; set; } = new ObservableCollection<SpeakerGroupingModel>();
        private IDataManager dataManager;
        ScheduleHelper helper = new ScheduleHelper();

        public SpeakersPageModel(IDataManager dataService)
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
            var s = helper.SpeakerGrouper(talks);
            Speakers = new ObservableCollection<SpeakerGroupingModel>(s);
        }

        SpeakerDM _selectedEntry;
        public SpeakerDM SelectedEntry
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
                _selectedEntry = null;
            }
        }

        public Command<SpeakerDM> EntrySelected
        {
            get
            {
                return new Command<SpeakerDM>(async (talk) => {
                    await CoreMethods.PushPageModel<SpeakerDetailPageModel>(talk);
                });
            }
        }
    }
}
