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
        StackLayout MainLayout = new StackLayout() { Orientation = StackOrientation.Horizontal, Padding = new Thickness(10) };
        CircleImage Hero = new CircleImage() { Aspect = Aspect.Fill, HeightRequest = 75, WidthRequest = 75, Margin = new Thickness(15) };
        Label Name = new Label() { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)), FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
        Label TwitterHandle = new Label() { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))};
        StackLayout SpeakerInfo = new StackLayout() { Orientation = StackOrientation.Horizontal };

        Label Time = new Label();
        Label TalkTitle = new Label()
        {
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            Margin = new Thickness(5),
            HorizontalOptions = LayoutOptions.Center,
            FontAttributes = FontAttributes.Bold
        };
        Label Track = new Label();
        Label Description = new Label() { VerticalOptions = LayoutOptions.FillAndExpand, Margin = new Thickness(5) };
        Button AddedToggle = new Button();
        public TalkDetailPage()
        {
            Name.SetBinding(Label.TextProperty, "Speaker.Name");
            TwitterHandle.SetBinding(Label.TextProperty, "Speaker.Twitter");
            Hero.SetBinding(Image.SourceProperty, nameof(TalkDetailPageModel.ImageSr));
            AddedToggle.SetBinding(Button.TextProperty, nameof(TalkDetailPageModel.AddedToggleText));
            AddedToggle.SetBinding(Button.CommandProperty, nameof(TalkDetailPageModel.ToggleCommand));

            SpeakerInfo.Children.Add(Hero);
            MainLayout.Children.Add(Hero);
            var innerLayout = new StackLayout()
            {
                Children =
                {
                    Name, TwitterHandle
                }
            };
            var lowerLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(5),
                Children =
                {
                    Time, Track
                }
            };
            MainLayout.Children.Add(innerLayout);
            MainLayout.Children.Add(lowerLayout);

            Time.SetBinding(Label.TextProperty, "SelectedTalk.DateAndTime");
            TalkTitle.SetBinding(Label.TextProperty, "SelectedTalk.Title");
            Track.SetBinding(Label.TextProperty, "SelectedTalk.Track");
            var descriptionScroll = new ScrollView();
            descriptionScroll.Content = Description;
            Description.SetBinding(Label.TextProperty, "SelectedTalk.Description");


            Content = new StackLayout
            {
                Children = {
                  TalkTitle, MainLayout, lowerLayout, descriptionScroll, AddedToggle
                }  
            };
        }
    }
}
