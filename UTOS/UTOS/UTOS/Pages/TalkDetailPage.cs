using ImageCircle.Forms.Plugin.Abstractions;
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
        StackLayout MainLayout = new StackLayout() { Orientation = StackOrientation.Horizontal };
        CircleImage Hero = new CircleImage() { Aspect = Aspect.Fill, HeightRequest = 75, WidthRequest = 75 };
        Label Name = new Label();
        Label TwitterHandle = new Label();
        StackLayout SpeakerInfo = new StackLayout() { Orientation = StackOrientation.Horizontal };

        Label Time = new Label();
        Label TalkTitle = new Label();
        Label Track = new Label();
        Label Description = new Label() { VerticalOptions = LayoutOptions.FillAndExpand };
        public TalkDetailPage()
        {
            Name.SetBinding(Label.TextProperty, "Speaker.Name");
            TwitterHandle.SetBinding(Label.TextProperty, "Speaker.Twitter");
            Hero.SetBinding(Image.SourceProperty, "Speaker.GravatarImageSource");
            SpeakerInfo.Children.Add(Hero);
            MainLayout.Children.Add(Hero);
            var innerLayout = new StackLayout()
            {
                Children =
                {
                    Name, TwitterHandle
                }
            };
            MainLayout.Children.Add(innerLayout);

            Time.SetBinding(Label.TextProperty, "SelectedTalk.DateAndTime");
            TalkTitle.SetBinding(Label.TextProperty, "SelectedTalk.Title");
            Track.SetBinding(Label.TextProperty, "SelectedTalk.Track");
            var descriptionScroll = new ScrollView();
            descriptionScroll.Content = Description;
            Description.SetBinding(Label.TextProperty, "SelectedTalk.Description");


            Content = new StackLayout
            {
                Children = {
                  MainLayout, Time, TalkTitle, Track, descriptionScroll
                }  
            };
        }
    }
}
