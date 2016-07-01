using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class WebPageModel : FreshBasePageModel
    {
        public string URL { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            if (initData is string)
                URL = initData as string;
        }
    }
}
