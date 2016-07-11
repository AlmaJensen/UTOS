using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTOS
{
    public class Resources
    {
        public const string GravatarBaseURL = "https://www.gravatar.com/avatar/";
        public const string GravatarEnding = ".jpg";
        public static List<string> PackagesUsed { get; } = new List<string>()
        {
            "Xamarin Forms", "Akavache", "Fresh MVVM", "Fresh Essentials", "Newtonsoft Json", "Fody", "Fody Property Changed", "Xam Plugin Connectivity", "Image Circle"
            , "Splat", ".Net Http", "SQLLite", "External Maps", "Share"
        };
        public const string TwitterURL = "https://twitter.com/openwestconf";
        public const string FacebookURL = "https://www.facebook.com/OpenWest";
        public const string OpenWestURL = "https://www.openwest.org/";
        public const string HackCenter = "https://www.openwest.org/hackcenter/";
        public const string SourceCode = "https://github.com/AlmaJensen/UTOS";
        public const string DefaultGravitarImage = "https://www.gravatar.com/avatar/19e7872cd8df0be958e21e3dd7c34aba.jpg";

        public static  Dictionary<string, Color> TrackColors = new Dictionary<string, Color>()
        {
            ["200A - Business"] = Color.FromHex("703116"),
            ["200B - Ops"] = Color.FromHex("EB6522"),
            ["200C - Data"] = Color.FromHex("94D6E8"),
            ["200D - QA/CI"] = Color.FromHex("C9272D"),
            ["300A - Architecture"] = Color.FromHex("582C8F"),
            ["300B - Languages"] = Color.FromHex("C0C083"),
            ["300C - Languages"] = Color.FromHex("758181"),
            ["300D - Languages"] = Color.FromHex("758181"),
            ["400 - Web"] = Color.FromHex("DA87BA"),
            ["EH2 -A - JS(Client)"] = Color.FromHex("F2CC4E"),
            ["EH2 -B - Tools"] = Color.FromHex("703116"),
            ["EH2 -C - Geek Life"] = Color.FromHex("8EB03E"),
            ["EH2 -D - Security"] = Color.FromHex("582C8F"),
            ["200D - Community"] = Color.FromHex("C9272D"),
            ["400 - Mobile"] = Color.FromHex("DA87BA"),
            ["400 - UI/UX"] = Color.FromHex("DA87BA"),
            ["EH2 -C - Hardware"] = Color.FromHex("8EB03E"),

        };
    }
}
