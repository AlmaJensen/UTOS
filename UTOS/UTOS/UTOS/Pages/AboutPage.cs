using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.PageModels;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class AboutPage : ContentPage
    {
        Label WrittenBy = new Label { Text = "Written By:", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), HorizontalOptions = LayoutOptions.Center };
        Label Author = new Label { Text = "Alma Jensen", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
        Label Descritpion = new Label() { Margin = new Thickness(5) };
        Button SourceLink = new Button() { Text = "Source Code" };
        Label PackagesLabel = new Label { Text = "Packages Used:", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
        ListView PackagesUsed = new ListView() { Margin = new Thickness(5) };

        public AboutPage()
        {
            Descritpion.SetBinding(Label.TextProperty, nameof(AboutPageModel.DescriptionString));
            SourceLink.SetBinding(Button.CommandProperty, nameof(AboutPageModel.SourceCommand));
            PackagesUsed.SetBinding(ListView.ItemsSourceProperty, nameof(AboutPageModel.PackagesUsed));
            Content = new StackLayout
            {
                Children = {
                    WrittenBy, Author, Descritpion, SourceLink, PackagesLabel, PackagesUsed
                }
            };
        }
    }
}
