using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.DataModels;
using Xamarin.Forms;

namespace UTOS.ViewCells
{
    public class SpeakerCell : ViewCell
    {
        public SpeakerCell()
        {
            Name.SetBinding(Label.TextProperty, nameof(SpeakerDM.Name));
            MainLayout.Children.Add(Name);
            View = MainLayout;
        }
        Label Name = new Label() { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
        StackLayout MainLayout = new StackLayout() { Padding = new Thickness(5), BackgroundColor = Color.White, Margin = new Thickness(2) };
    }
}
