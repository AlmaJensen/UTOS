using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTOS.ViewCells
{
    public class SpeakerDetail : ViewCell
    {
        public SpeakerDetail()
        {
            MainLayout.Children.Add(Hero);
            var innerLayout = new StackLayout()
            {
                Children =
                {
                    Name, TwitterHandle
                }
            };
            MainLayout.Children.Add(innerLayout);
            View = MainLayout;
        }
        Image Hero = new Image();
        Label Name = new Label();
        Label TwitterHandle = new Label();
        StackLayout MainLayout = new StackLayout() {Orientation = StackOrientation.Horizontal};
    }

}
