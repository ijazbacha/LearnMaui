using LearnMaui.MVVM.ViewModel;

namespace LearnMaui.MVVM.Views;

public partial class PersonPage : ContentPage
{
	public PersonPage()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}