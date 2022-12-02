using LearnMaui.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.Selectors
{
    public class ClothDataTempleteSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var cloth = item as Cloth;
            if (!cloth.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ClothRes", out var clothRes);
                return clothRes as DataTemplate;
            }
            return new DataTemplate();
        }
    }
}
