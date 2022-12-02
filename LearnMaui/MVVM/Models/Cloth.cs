using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.MVVM.Models
{
    public class Cloth
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool HasOffer { get; set; }
        public decimal OfferPrice { get; set; }
    }
}
