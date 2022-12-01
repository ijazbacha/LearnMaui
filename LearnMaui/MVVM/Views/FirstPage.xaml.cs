namespace LearnMaui.MVVM.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SecondPage(UserName.Text));
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new ThirdPage());
	}
}