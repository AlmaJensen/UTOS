using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.PageModels;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class MenuPage : ContentPage
    {
        Label Logo = new Label() { Text = "Open Demo App", TextColor = Color.Black, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold };
        BoxView TopDivider = new BoxView() { HeightRequest = 2, BackgroundColor = Color.Black };

        Label Directions = new Label { Text = "Directions", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer DirectionsCommand = new TapGestureRecognizer();

        Label Schedule = new Label { Text = "Schedule", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer ScheduleCommand = new TapGestureRecognizer();

        Label PrivateSchedule = new Label { Text = "Personal Schedule", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer PrivateScheduleCommand = new TapGestureRecognizer();

        Label Speaker = new Label { Text = "Speakers", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer SpeakerCommand = new TapGestureRecognizer();

        Label Sponsors = new Label { Text = "Sponsors", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer SponsorsCommand = new TapGestureRecognizer();

        BoxView MidDivider = new BoxView() { HeightRequest = 1, BackgroundColor = Color.Black };

        Label OpenWest = new Label { Text = "Open West", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer OpenWestCommand = new TapGestureRecognizer();

        Label HackCenter = new Label { Text = "Hack Center", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer HackCenterCommand = new TapGestureRecognizer();

        Label Twitter = new Label { Text = "Twitter", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer TwitterCommand = new TapGestureRecognizer();

        Label Facebook = new Label { Text = "Facebook", Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer FacebookCommand = new TapGestureRecognizer();

        BoxView EndSpacer = new BoxView() {BackgroundColor = Color.Transparent, VerticalOptions = LayoutOptions.FillAndExpand };

        Label About = new Label { Text = "About", VerticalOptions = LayoutOptions.End, Style = (Style)Styles["LabelStyle"] };
        TapGestureRecognizer AboutCommand = new TapGestureRecognizer();

        public MenuPage()
        {
            Directions.GestureRecognizers.Add(DirectionsCommand);
            DirectionsCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.DirectionsCommand));

            Schedule.GestureRecognizers.Add(ScheduleCommand);
            ScheduleCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.ScheduleCommand));

            PrivateSchedule.GestureRecognizers.Add(PrivateScheduleCommand);
            PrivateScheduleCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.PrivateScheduleCommand));

            Speaker.GestureRecognizers.Add(SpeakerCommand);
            SpeakerCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.SpeakerCommand));

            Sponsors.GestureRecognizers.Add(SponsorsCommand);
            SponsorsCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.SponsorsCommand));

            About.GestureRecognizers.Add(AboutCommand);
            AboutCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.AboutCommand));

            OpenWest.GestureRecognizers.Add(OpenWestCommand);
            OpenWestCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.OpenWestCommand));

            Twitter.GestureRecognizers.Add(TwitterCommand);
            TwitterCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.TwitterCommand));

            Facebook.GestureRecognizers.Add(FacebookCommand);
            FacebookCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.FacebookCommand));

            HackCenter.GestureRecognizers.Add(HackCenterCommand);
            HackCenterCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.HackCenterCommand));

            var mainLayout = new StackLayout
            {
                BackgroundColor = Color.White,
                Margin = new Thickness(3),
                Children = {
                    Logo, TopDivider,
                   Directions, Schedule, PrivateSchedule, Speaker, MidDivider, OpenWest, HackCenter, Twitter, Facebook, EndSpacer, About
                }
            };

            if(Device.OS == TargetPlatform.Android)
            {
                mainLayout.Padding = new Thickness(0, 20, 0, 0);
                Logo.MinimumHeightRequest = 80;
            }
            if (Device.OS == TargetPlatform.iOS)
            {
                mainLayout.Padding = new Thickness(0, 15, 0, 0);
            }

            Content = mainLayout;             
        }

        static ResourceDictionary Styles = new ResourceDictionary()
        {
            ["LabelStyle"] = new Style(typeof(Label))
            {
                Setters =
                    {
                        new Setter { Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) },
                        new Setter { Property = Label.MarginProperty, Value = new Thickness(5,2,2,2) }
                    }
            }
        };

    }
}
