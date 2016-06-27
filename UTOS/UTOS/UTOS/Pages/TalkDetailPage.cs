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
        Label Description = new Label();
        ListView Speaker = new ListView(ListViewCachingStrategy.RecycleElement);
        public TalkDetailPage()
        {
            Speaker.HasUnevenRows = true;
            Speaker.ItemTemplate = new DataTemplate(typeof(SpeakerDetail));
            Speaker.SetBinding(ListView.ItemsSourceProperty, nameof(TalkDetailPageModel.Speakers));
            Time.SetBinding(Label.TextProperty, "SeletectedTalk.ts");
            Content = new StackLayout
            {
                Children = {
                    Time, TalkTitle, Speaker, Track, Description
                }
            };
        }
    }
}
