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

            if (SelectedTalk.AddedToWebSchedule)
                AddedToggleText = remove;
            else
                AddedToggleText = add;
                
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
            if (SelectedTalk.AddedToWebSchedule)
            {
                AddedToggleText = remove;
                SelectedTalk.AddedToWebSchedule = false;
            }
            else
            {
                AddedToggleText = add;
                SelectedTalk.AddedToWebSchedule = true;
            }
            dataManager.UpdateSingleSession(SelectedTalk);
        }
    }
}
