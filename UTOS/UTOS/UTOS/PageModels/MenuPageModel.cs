using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.Pages;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class MenuPageModel : FreshBasePageModel
    {
        public Command ScheduleCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<AllSessionsPageModel>(); }); } }
        public Command SponsorsCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<AllSessionsPageModel>(); }); } }
        public Command AboutCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<AllSessionsPageModel>(); }); } }
    }
}
