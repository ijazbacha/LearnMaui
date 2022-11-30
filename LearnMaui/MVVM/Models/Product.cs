using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.MVVM.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AvailQty { get; set; }
        public int ProductWeight { get; set; }
        public bool IsPopular { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
