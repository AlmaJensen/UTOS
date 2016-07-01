using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UTOS.PageModels;
using Xamarin.Forms;

namespace UTOS.Pages
{
    public class WebPage : ContentPage
    {
        WebView web = new WebView() { VerticalOptions = LayoutOptions.FillAndExpand};
        public WebPage()
        {
            web.SetBinding(WebView.SourceProperty, nameof(WebPageModel.URL));
            Content = new StackLayout
            {
                Children = {
                    web
                }
            };
        }
    }
}
