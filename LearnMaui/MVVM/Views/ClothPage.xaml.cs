using LearnMaui.MVVM.ViewModel;

namespace LearnMaui.MVVM.Views;

public partial class ClothPage : ContentPage
{
	public ClothPage()
	{
		InitializeComponent();
		BindingContext = new ClothViewModel();
	}
}