namespace LearnMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var NavPage = new NavigationPage(new FlyoutPageDemo());
		NavPage.BarBackground = Colors.Black;
        NavPage.BarTextColor = Colors.White;
        MainPage = new ModesExample();
	}
}
