namespace LearnMaui;

public partial class InotifyChangedDemo : ContentPage
{
	Model.Employee emp = new Model.Employee();
	public InotifyChangedDemo()
	{
		InitializeComponent();
		emp = new Model.Employee()
		{
			Id = 1,
			Name = "ASDF"
		};
		BindingContext = emp;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		emp.Id = 2;
		emp.Name = "ZXCV";
	}
}