namespace LearnMaui.MVVM.Views;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SecondPage());
	}
}