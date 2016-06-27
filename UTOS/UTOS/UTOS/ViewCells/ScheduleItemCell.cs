using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.API;
using Xamarin.Forms;

namespace UTOS.ViewCells
{
    public class ScheduleItemCell : ViewCell
    {
        public ScheduleItemCell()
        {
            Description.SetBinding(Label.TextProperty, nameof(Talk.title));
            Track.SetBinding(Label.TextProperty, nameof(Talk.track));
            MainLayout.Children.Add(Description);
            MainLayout.Children.Add(Track);
            View = MainLayout;
        }
        Label Description = new Label() { TextColor = Color.Black };
        Label Track = new Label() { TextColor = Color.Black };
        StackLayout MainLayout = new StackLayout();
    }
}
