using FreshMvvm;
using Plugin.Share;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.DataModels;
using UTOS.Helpers;
using UTOS.Services;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class SpeakerDetailPageModel : FreshBasePageModel
    {
        private IDataManager dataManager;
        ScheduleHelper helper = new ScheduleHelper();
        public ObservableCollection<SessionDM> Sessions { get; set; } = new ObservableCollection<SessionDM>();

        public string Name { get; set; }
        public ImageSource ImageSr { get; set; }
        public string Twitter  { get; set; }

        public Command ShareCommand
        {
            get
            {
                return new Command(async (sender) => {
                    await CrossShare.Current.Share("OpenWest Conference Speaker: " + Name);
                });
            }
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
                _selectedEntry = null;
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

        public SpeakerDetailPageModel(IDataManager dataService)
        {
            dataManager = dataService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            var speaker = initData as SpeakerDM;

            if(string.IsNullOrEmpty(speaker?.GravatarImageString))
                ImageSr = ImageSource.FromUri(new Uri(Resources.DefaultGravitarImage));
            else
                ImageSr = ImageSource.FromUri(new Uri(speaker.GravatarImageString));

            Twitter = speaker.Twitter;
            Name = speaker.Name;

            LoadCollection();
        }

        private async void LoadCollection()
        {
            var talks = await dataManager.GetAllSessions();
            Sessions = new ObservableCollection<SessionDM>(helper.GetSessionsBySpeaker(talks, Name));
        }
    }
}
