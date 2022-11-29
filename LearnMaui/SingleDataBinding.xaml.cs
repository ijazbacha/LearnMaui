namespace LearnMaui;

public partial class SingleDataBinding : ContentPage
{
	public SingleDataBinding()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        LearnMaui.Model.Employee emp = new LearnMaui.Model.Employee()
		{
			Id = 1,
			Name = "XYZ"
		};
		Binding empBinding = new Binding();
		empBinding.Source = emp;
		empBinding.Path = "Name";
        EmployeeLB.SetBinding(Label.TextProperty, empBinding);

    }
}