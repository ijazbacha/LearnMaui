using LearnMaui.MVVM.Models;
using LearnMaui.MVVM.ViewModel;

namespace LearnMaui.MVVM.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
        
		BindingContext = new ProductViewModel();
	}
}