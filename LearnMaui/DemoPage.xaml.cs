namespace LearnMaui;

public partial class DemoPage : ContentPage
{
	public DemoPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}
}