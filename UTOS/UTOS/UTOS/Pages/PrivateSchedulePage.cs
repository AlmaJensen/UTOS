using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.PageModels;
using UTOS.ViewCells;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class PrivateSchedulePage : ContentPage
    {
        ListView SessionList = new ListView(ListViewCachingStrategy.RecycleElement)
        {
            HasUnevenRows = true,
            VerticalOptions = LayoutOptions.FillAndExpand
        };
        public PrivateSchedulePage()
        {
            SessionList.ItemTemplate = new DataTemplate(typeof(ScheduleItemCell));
            SessionList.SetBinding(ListView.ItemsSourceProperty, nameof(PrivateSchedulePageModel.Sessions));
            SessionList.SetBinding(ListView.SelectedItemProperty, nameof(PrivateSchedulePageModel.SelectedEntry));


            Content = new StackLayout
            {
                Children = {
                    SessionList
                }
            };
        }
    }
}
