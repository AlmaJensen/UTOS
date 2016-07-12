using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace UTOS.Pages
{
    public class SponsorsPage : ContentPage
    {
        ListView Sponsors = new ListView(ListViewCachingStrategy.RecycleElement) { VerticalOptions = LayoutOptions.FillAndExpand };
        public SponsorsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    Sponsors
                }
            };
        }
    }
}
