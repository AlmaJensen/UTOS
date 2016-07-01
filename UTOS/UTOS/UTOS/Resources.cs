using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS
{
    public class Resources
    {
        public const string GravatarBaseURL = "https://www.gravatar.com/avatar/";
        public const string GravatarEnding = ".jpg";
        public List<string> PackagesUsed { get; } = new List<string>()
        {
            "Xamarin Forms", "Akavache", "Fresh MVVM", "Fresh Essentials", "Newtonsoft Json", "Fody", "Fody Property Changed", "Xam Plugin Connectivity", "Image Circle"
            , "Splat", ".Net Http", "SQLLite"
        };
        public const string TwitterURL = "https://twitter.com/openwestconf";
        public const string FacebookURL = "https://www.facebook.com/OpenWest";
        public const string OpenWestURL = "https://www.openwest.org/";
        public const string HackCenter = "https://www.openwest.org/hackcenter/";
    }
}
