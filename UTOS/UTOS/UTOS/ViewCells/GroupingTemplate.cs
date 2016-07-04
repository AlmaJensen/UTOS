using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;
using Xamarin.Forms;

namespace UTOS.ViewCells
{
    public class GroupingTemplate : ViewCell
    {
        Label Title = new Label()
        {
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Margin = new Thickness(10),
            HorizontalOptions = LayoutOptions.Center,
            FontAttributes = FontAttributes.Bold
        };

        public GroupingTemplate()
        {
            Title.SetBinding(Label.TextProperty, nameof(GroupingModel.DisplayDate));
            View = new StackLayout
            {
                Children = {
                    Title
                }
            };
        }
    }
}
