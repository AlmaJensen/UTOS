using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.PageModels;
using UTOS.ViewCells;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class TalkDetailPage : ContentPage
    {
        Label Time = new Label();
        Label TalkTitle = new Label();
        Label Track = new Label();
        Label Description = new Label() { VerticalOptions = LayoutOptions.FillAndExpand };
        ListView Speaker = new ListView(ListViewCachingStrategy.RecycleElement);
        public TalkDetailPage()
        {
            Speaker.HasUnevenRows = true;
            Speaker.ItemTemplate = new DataTemplate(typeof(SpeakerDetail));
            Speaker.SetBinding(ListView.ItemsSourceProperty, nameof(TalkDetailPageModel.Speakers));
            Time.SetBinding(Label.TextProperty, "SelectedTalk.ts");
            TalkTitle.SetBinding(Label.TextProperty, "SelectedTalk.title");
            Track.SetBinding(Label.TextProperty, "SelectedTalk.track");
            Description.SetBinding(Label.TextProperty, "SelectedTalk.description");


            Content = new StackLayout
            {
                Children = {
                   Speaker, Time, TalkTitle, Track, Description
                }
            };
        }
    }
}
