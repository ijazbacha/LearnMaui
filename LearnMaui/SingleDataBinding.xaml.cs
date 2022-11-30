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
			Name = "XYzzzzz"
		};
        //------ Single data binding -------
        //Binding empBinding = new Binding();
        //empBinding.Source = emp;
        //empBinding.Path = "Name";
        //      EmployeeLB.SetBinding(Label.TextProperty, empBinding);

        //------ Multiple data binding -------
        BindingContext = emp;

        //------ Single data binding using BindingContext -------
        EmployeeLB.BindingContext = emp;
        EmployeeLB.SetBinding(Label.TextProperty, "Name");

    }
}