using LearnMaui.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearnMaui.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class ClothViewModel
    {
        public ObservableCollection<Cloth> Cloths { get; set; } = 
            new ObservableCollection<Cloth>();
        public bool IsRefresh { get; set; }

        public ICommand RefreshCommand =>
            new Command(async () =>
            {
                IsRefresh = true;
                await Task.Delay(2000);
                ItemRefresh(Cloths.Count);
                IsRefresh = false;
            });

        public ICommand ReachedCommand =>
            new Command(() =>
            {
                ItemRefresh(Cloths.Count);
            });


        public ClothViewModel()
        {
            ItemRefresh();
        }

        private void ItemRefresh(int lastItem=0)
        {
            var ItemPerPage = 3;
            var Items = new ObservableCollection<Cloth>()
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
                    HasOffer = true,
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
                    HasOffer = true,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = true,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = true,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = true,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = true,
                    OfferPrice = 0
                },
                new Cloth()
                {
                    Title = "dotnet bot",
                    Price = 12.0m,
                    Stock = 10,
                    Image = "dotnet_bot.svg",
                    HasOffer = true,
                    OfferPrice = 0
                },

            };
            var PageItems = Items.Skip(lastItem).Take(ItemPerPage);
            foreach(var Item in PageItems)
            {
                Cloths.Add(Item);
            }
        }
    }
}
