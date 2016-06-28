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
        public TalkDetailPage()
        {
            Name.SetBinding(Label.TextProperty, "Speakers.Name");
            TwitterHandle.SetBinding(Label.TextProperty, "Speakers.Twitter");
            Hero.SetBinding(Image.SourceProperty, "Speakers.GravatarImageSource");
            SpeakerInfo.Children.Add(Hero);
            var innerLayout = new StackLayout()
            {
                Children =
                {
                    Name, TwitterHandle
                }
            };
            SpeakerInfo.Children.Add(innerLayout);

            Time.SetBinding(Label.TextProperty, "SelectedTalk.DateAndTime");
            TalkTitle.SetBinding(Label.TextProperty, "SelectedTalk.Title");
            Track.SetBinding(Label.TextProperty, "SelectedTalk.Track");
            var descriptionScroll = new ScrollView();
            descriptionScroll.Content = Description;
            Description.SetBinding(Label.TextProperty, "SelectedTalk.Description");


            Content = new StackLayout
            {
                Children = {
                   Time, TalkTitle, Track, descriptionScroll
                }
            };
        }
    }
}
