using LearnMaui.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.MVVM.ViewModel
{
    public class ClothViewModel
    {
        public ObservableCollection<Cloth> Cloths { get; set; }

        public ClothViewModel()
        {
            Cloths = new ObservableCollection<Cloth>()
            {
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = false,
                    OfferPrice = 0
                },

            };
        }
    }
}
