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
        Label Description = new Label() { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
        Label Track = new Label() { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
        StackLayout MainLayout = new StackLayout() { Padding = new Thickness(5), BackgroundColor = Color.White, Margin = new Thickness(2) };
    }
}
