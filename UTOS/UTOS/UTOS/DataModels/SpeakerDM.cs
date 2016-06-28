using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTOS.DataModels
{
    public class SpeakerDM
    {
        public string Name { get; set; }
        public string Twitter { get; set; }
        public string GravatarImageString { get; set; }
        public ImageSource GravatarImageSource { get; set; }
    }
}
