namespace LearnMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var NavPage = new NavigationPage(new MainPage());
		NavPage.BarBackground = Colors.Black;
        NavPage.BarTextColor = Colors.White;
        MainPage = NavPage;
	}
}
