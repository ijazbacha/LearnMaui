using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.MVVM.ViewModel
{
    public class ProductViewModelForCollection
    {
        public List<string> ProductView { get; set; }

        public ProductViewModelForCollection()
        {
            ProductView = new List<string>()
            {
                "Samsung",
                "Iphone",
                "Microsoft",
                "Windows"
            };
        }
    }
}
