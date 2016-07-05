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
        SearchBar Search = new SearchBar() { Margin = new Thickness(5), HorizontalOptions = LayoutOptions.FillAndExpand};
        ListView SessionList = new ListView(ListViewCachingStrategy.RecycleElement)
        {            
            HasUnevenRows = true,
            VerticalOptions = LayoutOptions.FillAndExpand,
            IsGroupingEnabled = true,
            SeparatorVisibility = SeparatorVisibility.None,
        };
        Grid searchGrid = new Grid
        {
            VerticalOptions = LayoutOptions.FillAndExpand,
            RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                },
            ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = GridLength.Auto },
                }
        };
        public AllSessionsPage()
        {
            searchGrid.Children.Add(Search, 0, 0);
            searchGrid.Children.Add(Reset, 1, 0);
            Day.SetBinding(BindablePicker.ItemsSourceProperty, nameof(AllSessionsPageModel.Days));
            Track.SetBinding(BindablePicker.ItemsSourceProperty, nameof(AllSessionsPageModel.Tracks));

            Track.SetBinding(BindablePicker.SelectedItemProperty, nameof(AllSessionsPageModel.SelectedTrack));
            Day.SetBinding(BindablePicker.SelectedItemProperty, nameof(AllSessionsPageModel.SelectedDay));

            Reset.SetBinding(Button.CommandProperty, nameof(AllSessionsPageModel.ResetCommand));

            Search.SetBinding(SearchBar.SearchCommandProperty, nameof(AllSessionsPageModel.SearchCommand));
            Search.SetBinding(SearchBar.TextProperty, nameof(AllSessionsPageModel.SearchText));

            SessionList.ItemTemplate = new DataTemplate(typeof(ScheduleItemCell));
            SessionList.GroupHeaderTemplate = new DataTemplate(typeof(GroupingTemplate));
            SessionList.SetBinding(ListView.ItemsSourceProperty, nameof(AllSessionsPageModel.Sessions));
            SessionList.SetBinding(ListView.SelectedItemProperty, nameof(AllSessionsPageModel.SelectedEntry));

            var pickerHolder = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Day, Track,
                }
            };
            //var searchHolder = new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    Children =
            //    {
            //        Search, Reset
            //    }
            //};

            var mainLayout = new StackLayout
            {
                BackgroundColor = Color.FromHex("EFEFEF"),
                Children = {
                   searchGrid, pickerHolder, SessionList
                }
            };

            Content = mainLayout;
        }
    }
}
