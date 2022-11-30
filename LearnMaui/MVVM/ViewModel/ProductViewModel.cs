using LearnMaui.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.MVVM.ViewModel
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public ProductViewModel()
        {
            Product = new Product()
            {
                Name = "Iphone",
                Desc = "Iphone 14",
                AvailQty = 5,
                ProductWeight = 100,
                IsPopular = false,
                CreatedDate = new DateTime(2022, 11, 30)
            };
        }
    }
}
