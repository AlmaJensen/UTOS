using FreshEssentials;
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
    public class AllSessionsPage : ContentPage
    {
        BindablePicker Day = new BindablePicker() { Title = "Day", HorizontalOptions = LayoutOptions.FillAndExpand, Margin = new Thickness(5) };
        BindablePicker Track = new BindablePicker() { Title = "Track", HorizontalOptions = LayoutOptions.FillAndExpand, Margin = new Thickness(5) };
        Button Reset = new Button { Text = "Reset", Margin = new Thickness(5) };
        SearchBar Search = new SearchBar() { Margin = new Thickness(5) };
        ListView SessionList = new ListView(ListViewCachingStrategy.RecycleElement)
        {
            HasUnevenRows = true,
            VerticalOptions = LayoutOptions.FillAndExpand,
            IsGroupingEnabled = true,
        };
        public AllSessionsPage()
        {
            Day.SetBinding(BindablePicker.ItemsSourceProperty, nameof(AllSessionsPageModel.Days));
            Track.SetBinding(BindablePicker.ItemsSourceProperty, nameof(AllSessionsPageModel.Tracks));

            Track.SetBinding(BindablePicker.SelectedItemProperty, nameof(AllSessionsPageModel.SelectedTrack));
            Day.SetBinding(BindablePicker.SelectedItemProperty, nameof(AllSessionsPageModel.SelectedDay));

            Search.SetBinding(SearchBar.SearchCommandProperty, nameof(AllSessionsPageModel.SearchCommand));
            Search.SetBinding(SearchBar.TextProperty, nameof(AllSessionsPageModel.SearchText));

            SessionList.ItemTemplate = new DataTemplate(typeof(ScheduleItemCell));
            //SessionList.GroupHeaderTemplate = new DataTemplate(typeof(GroupingTemplate));
            SessionList.SetBinding(ListView.ItemsSourceProperty, nameof(AllSessionsPageModel.Sessions));
            SessionList.SetBinding(ListView.SelectedItemProperty, nameof(AllSessionsPageModel.SelectedEntry));

            var pickerHolder = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Day, Track, Reset
                }
            };


            Content = new StackLayout
            {
                Children = {
                   Search, pickerHolder, SessionList
                }
            };
        }
    }
}
