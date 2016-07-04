using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;
using UTOS.DataModels;
using UTOS.Services;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class TalkDetailPageModel : FreshBasePageModel
    {
        private IDataManager dataManager;
        public SessionDM SelectedTalk { get; set; } = new SessionDM();
        public SpeakerDM Speaker { get; set; } = new SpeakerDM();
        public string AddedToggleText { get; set; }

        private string add = "Add to Schedule";
        private string remove = "Remove from Schedule";

        public ImageSource ImageSr { get; set; }

        public TalkDetailPageModel(IDataManager dataService)
        {
            dataManager = dataService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            
            SelectedTalk = initData as SessionDM;
            if (SelectedTalk == null)
                SelectedTalk = new SessionDM();
            else
                Speaker = SelectedTalk.Speaker;

            if (SelectedTalk.AddedToSchedule)
                AddedToggleText = remove;
            else
                AddedToggleText = add;

            ImageSr = ImageSource.FromUri(new Uri(Speaker.GravatarImageString));

        }
        public Command ToggleCommand
        {
            get
            {
                return new Command((sender) => {
                    ToggleAddedToSchedule();
                });
            }
        }

        private void ToggleAddedToSchedule()
        {
            if (SelectedTalk.AddedToSchedule)
            {
                AddedToggleText = add;
                SelectedTalk.AddedToSchedule = false;
            }
            else
            {
                AddedToggleText = remove;
                SelectedTalk.AddedToSchedule = true;
            }
            dataManager.UpdateSingleSession(SelectedTalk);
        }
    }
}
