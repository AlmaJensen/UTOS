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
        Image Hero = new Image();
        Label Name = new Label();
        Label TwitterHandle = new Label();
        StackLayout SpeakerInfo = new StackLayout() { Orientation = StackOrientation.Horizontal };

        Label Time = new Label();
        Label TalkTitle = new Label();
        Label Track = new Label();
        Label Description = new Label() { VerticalOptions = LayoutOptions.FillAndExpand };
        ListView Speaker = new ListView(ListViewCachingStrategy.RecycleElement);
        public TalkDetailPage()
        {
            Name.SetBinding(Label.TextProperty, "Speakers.name");
            TwitterHandle.SetBinding(Label.TextProperty, "Speakers.twitter");
            Hero.SetBinding(Image.SourceProperty, "Speakers.gravatar_hash");
            SpeakerInfo.Children.Add(Hero);
            var innerLayout = new StackLayout()
            {
                Children =
                {
                    Name, TwitterHandle
                }
            };
            SpeakerInfo.Children.Add(innerLayout);

            Speaker.HasUnevenRows = true;
            Speaker.ItemTemplate = new DataTemplate(typeof(SpeakerDetail));
            Speaker.SetBinding(ListView.ItemsSourceProperty, nameof(TalkDetailPageModel.Speakers));
            Time.SetBinding(Label.TextProperty, "SelectedTalk.ts");
            TalkTitle.SetBinding(Label.TextProperty, "SelectedTalk.title");
            Track.SetBinding(Label.TextProperty, "SelectedTalk.track");
            var descriptionScroll = new ScrollView();
            descriptionScroll.Content = Description;
            Description.SetBinding(Label.TextProperty, "SelectedTalk.description");


            Content = new StackLayout
            {
                Children = {
                   Time, TalkTitle, Track, descriptionScroll
                }
            };
        }
    }
}
