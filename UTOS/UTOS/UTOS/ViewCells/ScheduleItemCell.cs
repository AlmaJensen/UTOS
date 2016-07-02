using UTOS.DataModels;
using Xamarin.Forms;
using Xamarin.Forms.Themes;

namespace UTOS.ViewCells
{
    public class ScheduleItemCell : ViewCell
    {
        public ScheduleItemCell()
        {
            Description.SetBinding(Label.TextProperty, nameof(SessionDM.Title));
            Track.SetBinding(Label.TextProperty, nameof(SessionDM.Track));
            MainLayout.Children.Add(Description);
            MainLayout.Children.Add(Track);
            View = MainLayout;
        }
        Label Description = new Label() {};
        Label Track = new Label() {};
        StackLayout MainLayout = new StackLayout();
    }
}
