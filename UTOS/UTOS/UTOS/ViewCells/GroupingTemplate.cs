using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTOS.ViewCells
{
    public class GroupingTemplate : ViewCell
    {
        Label Title = new Label() { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), Margin = new Thickness(10) };

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
