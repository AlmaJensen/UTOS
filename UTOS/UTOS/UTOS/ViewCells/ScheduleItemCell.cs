using UTOS.DataModels;
using Xamarin.Forms;

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
        Label Description = new Label() { TextColor = Color.Black };
        Label Track = new Label() { TextColor = Color.Black };
        StackLayout MainLayout = new StackLayout();
    }
}
