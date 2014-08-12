using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Table_Concierg.DataTemplateSelectors
{
    public class AvailabilityTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WithAvailabilityTemplate { get; set; }
        public DataTemplate WithOutAvailabilityTemplate { get; set; }

        protected override global::Windows.UI.Xaml.DataTemplate SelectTemplateCore(object item)
        {
            var junk = item as Table_Concierg.MainPage.Item;

            if (junk.RegularMode)
                return WithOutAvailabilityTemplate;
            else
                return WithAvailabilityTemplate;
        }
    }
}