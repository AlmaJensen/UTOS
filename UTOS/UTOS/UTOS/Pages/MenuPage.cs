using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class MenuPage : ContentPage
    {
        Label Schedule = new Label { Text = "Schedule" };
        TapGestureRecognizer ScheduleCommand = new TapGestureRecognizer();
        Label Sponsors = new Label { Text = "Sponsors" };
        TapGestureRecognizer SponsorsCommand = new TapGestureRecognizer();
        Label About = new Label { Text = "About" };
        TapGestureRecognizer AboutCommand = new TapGestureRecognizer();
        public MenuPage()
        {
            Schedule.GestureRecognizers.Add(ScheduleCommand);
            Sponsors.GestureRecognizers.Add(SponsorsCommand);
            About.GestureRecognizers.Add(AboutCommand);
            Content = new StackLayout
            {
                Children = {
                    Schedule, Sponsors, About
                }
            };
        }

    }
}
