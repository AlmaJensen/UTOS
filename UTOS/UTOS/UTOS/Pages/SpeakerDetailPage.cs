using ImageCircle.Forms.Plugin.Abstractions;
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
    public class SpeakerDetailPage : ContentPage
    {
        Label Name = new Label() { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(0,10,0,0) };
        CircleImage Hero = new CircleImage() { Aspect = Aspect.Fill, HeightRequest = 150, WidthRequest = 150, Margin = new Thickness(15), HorizontalOptions = LayoutOptions.Center };
        Label TwitterHandle = new Label() { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)), HorizontalOptions = LayoutOptions.Center };
        Button Share = new Button() { Text = "Share" };
        ListView Sessions = new ListView( ListViewCachingStrategy.RecycleElement) { HasUnevenRows = true };
        public SpeakerDetailPage()
        {
            Name.SetBinding(Label.TextProperty, nameof(SpeakerDetailPageModel.Name));
            TwitterHandle.SetBinding(Label.TextProperty, nameof(SpeakerDetailPageModel.Twitter));
            Hero.SetBinding(Image.SourceProperty, nameof(SpeakerDetailPageModel.ImageSr));
            Share.SetBinding(Button.CommandProperty, nameof(SpeakerDetailPageModel.ShareCommand));

            Sessions.ItemTemplate = new DataTemplate(typeof(ScheduleItemCell));
            Sessions.SetBinding(ListView.ItemsSourceProperty, nameof(PrivateSchedulePageModel.Sessions));
            Sessions.SetBinding(ListView.SelectedItemProperty, nameof(PrivateSchedulePageModel.SelectedEntry));

            Sessions.ItemTapped += SessionList_ItemTapped;

            Content = new StackLayout
            {
                Children = {
                    Name, Hero, TwitterHandle, Sessions, Share
                }
            };
        }

        private void SessionList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Sessions.SelectedItem = null;
        }
    }
}
