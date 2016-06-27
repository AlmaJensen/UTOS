using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class TalkDetailPageModel : FreshBasePageModel
    {
        public Talk SelectedTalk { get; set; } = new Talk();
        public ObservableCollection<Speaker> Speakers { get; set; } = new ObservableCollection<Speaker>();
        public override void Init(object initData)
        {
            base.Init(initData);
            
            SelectedTalk = initData as Talk;
            if (SelectedTalk == null)
                SelectedTalk = new Talk();
            if (SelectedTalk.speakers.Count > 0)
            {
                Speakers = new ObservableCollection<Speaker>(SelectedTalk.speakers);
            }
                
        }
    }
}
