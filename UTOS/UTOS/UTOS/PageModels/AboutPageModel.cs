using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.Services;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class AboutPageModel : FreshBasePageModel
    {
        public List<string> PackagesUsed { get; set; } = Resources.PackagesUsed;
        public Command SourceCommand { get { return new Command(async () => { await CoreMethods.PushPageModel<WebPageModel>(Resources.SourceCode); }); } }
        public string DescriptionString { get; set; } = 
            "This App was written initially for use in conjuction with the 2016 OpenWest conference.  Use is for conference attendees and for a demonstration of Xamarin Forms mobile app development.  The source code is freely available on Github and may be used and modified per MIT regulations.";
    }
}
