using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace UTOS.Pages
{
    public class SpeakerDetailPage : ContentPage
    {
        Label Name = new Label() { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)), FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
        Label TwitterHandle = new Label() { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
        Button Share = new Button() { Text = "Share" };
        ListView Sessions = new ListView( ListViewCachingStrategy.RecycleElement) { };
        public SpeakerDetailPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}
