using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;
using Xamarin.Forms;

namespace UTOS.ViewCells
{
    public class SpeakerGroupingTemplate : ViewCell
    {
        Label Title = new Label()
        {
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            Margin = new Thickness(10),
            HorizontalOptions = LayoutOptions.Center,
            FontAttributes = FontAttributes.Bold
        };
        public SpeakerGroupingTemplate()
        {
            Title.SetBinding(Label.TextProperty, nameof(SpeakerGroupingModel.GroupName));
            View = new StackLayout
            {
                BackgroundColor = Color.FromHex("686868"),
                Children = {
                    Title
                }
            };
        }

    }
}
