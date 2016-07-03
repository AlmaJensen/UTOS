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
        Label Schedule = new Label { Text = "Schedule" };
        TapGestureRecognizer ScheduleCommand = new TapGestureRecognizer();

        Label PrivateSchedule = new Label { Text = "Personal Schedule" };
        TapGestureRecognizer PrivateScheduleCommand = new TapGestureRecognizer();

        Label Sponsors = new Label { Text = "Sponsors" };
        TapGestureRecognizer SponsorsCommand = new TapGestureRecognizer();
        
        Label OpenWest = new Label { Text = "Open West" };
        TapGestureRecognizer OpenWestCommand = new TapGestureRecognizer();

        Label HackCenter = new Label { Text = "Hack Center" };
        TapGestureRecognizer HackCenterCommand = new TapGestureRecognizer();

        Label Twitter = new Label { Text = "Twitter" };
        TapGestureRecognizer TwitterCommand = new TapGestureRecognizer();

        Label Facebook = new Label { Text = "Facebook" };
        TapGestureRecognizer FacebookCommand = new TapGestureRecognizer();

        Label About = new Label { Text = "About", VerticalOptions = LayoutOptions.End };
        TapGestureRecognizer AboutCommand = new TapGestureRecognizer();

        public MenuPage()
        {
            Schedule.GestureRecognizers.Add(ScheduleCommand);
            ScheduleCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.ScheduleCommand));

            PrivateSchedule.GestureRecognizers.Add(PrivateScheduleCommand);
            PrivateScheduleCommand.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuPageModel.PrivateScheduleCommand));

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

            Content = new StackLayout
            {
                Margin = new Thickness(3),
                Children = {
                    Schedule, PrivateSchedule, OpenWest, HackCenter, Twitter, Facebook, About
                }
            };
        }

    }
}
