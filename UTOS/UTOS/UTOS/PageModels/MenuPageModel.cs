using FreshMvvm;
using Plugin.ExternalMaps;
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
        public Command DirectionsCommand
        {
            get
            {
                return new Command(async () => 
                {
                    await CrossExternalMaps.Current.NavigateTo("South Towne Exposition Center", "9575 state St", "Sandy", "UT", "84070", "USA", "USA");
                });
            }
        }

        public Command ScheduleCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<AllSessionsPageModel>(); }); } }
        public Command PrivateScheduleCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<PrivateSchedulePageModel>(); }); } }
        public Command SpeakerCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<SpeakersPageModel>(); }); } }
        public Command SponsorsCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<SponsorsPageModel>(); }); } }
        public Command AboutCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<AboutPageModel>(); }); } }
        public Command OpenWestCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<WebPageModel>(Resources.OpenWestURL); }); } }
        public Command TwitterCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<WebPageModel>(Resources.TwitterURL); }); } }
        public Command FacebookCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<WebPageModel>(Resources.FacebookURL); }); } }
        public Command HackCenterCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<WebPageModel>(Resources.HackCenter); }); } }
    }
}
