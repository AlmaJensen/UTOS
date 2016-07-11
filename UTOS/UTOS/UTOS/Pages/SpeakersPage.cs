using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.DataModels;
using UTOS.PageModels;
using UTOS.ViewCells;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class SpeakersPage : ContentPage
    {
        ListView Speakers = new ListView( ListViewCachingStrategy.RecycleElement )
        {
            VerticalOptions = LayoutOptions.FillAndExpand,
            IsGroupingEnabled = true,
            SeparatorVisibility = SeparatorVisibility.None, 
            GroupDisplayBinding = new Binding(nameof(SpeakerGroupingModel.GroupName)),
            GroupShortNameBinding = new Binding(nameof(SpeakerGroupingModel.ShortName)),
            ItemTemplate = new DataTemplate(typeof(SpeakerCell)),
            GroupHeaderTemplate = new DataTemplate(typeof(SpeakerGroupingTemplate)),
        };
        public SpeakersPage()
        {
            Speakers.SetBinding(ListView.ItemsSourceProperty, nameof(SpeakersPageModel.Speakers));
            Speakers.SetBinding(ListView.SelectedItemProperty, nameof(SpeakersPageModel.SelectedEntry));
            Speakers.ItemTapped += Speakers_ItemTapped;
            Content = new StackLayout
            {
                Children = {
                    Speakers
                }
            };
        }

        private void Speakers_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Speakers.SelectedItem = null;
        }
    }
}
