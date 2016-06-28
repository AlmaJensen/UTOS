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

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class TalkDetailPageModel : FreshBasePageModel
    {
        public SessionDM SelectedTalk { get; set; } = new SessionDM();
        public SpeakerDM Speaker { get; set; } = new SpeakerDM();
        public override void Init(object initData)
        {
            base.Init(initData);
            
            SelectedTalk = initData as SessionDM;
            if (SelectedTalk == null)
                SelectedTalk = new SessionDM();
            else
                Speaker = SelectedTalk.Speaker;
                
        }
    }
}
