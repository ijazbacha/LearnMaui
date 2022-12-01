using LearnMaui.MVVM.ViewModel;

namespace LearnMaui.MVVM.Views;

public partial class CommandExample : ContentPage
{
	public CommandExample()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();
	}
}