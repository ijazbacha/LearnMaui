using LearnMaui.MVVM.ViewModel;

namespace LearnMaui.MVVM.Views;

public partial class BindCollectionView : ContentPage
{
	public BindCollectionView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModelForCollection();

    }
}