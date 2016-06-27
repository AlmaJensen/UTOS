using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.PageModels;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class TalkDetailPage : ContentPage
    {
        Label Time = new Label();
        Label TalkTitle = new Label();
        Label Track = new Label();
        Label Description = new Label();
        public TalkDetailPage()
        {
            Time.SetBinding(Label.TextProperty, "SeletectedTalk.ts");
            Content = new StackLayout
            {
                Children = {
                    Time, TalkTitle, Track, Description
                }
            };
        }
    }
}
