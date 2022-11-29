namespace LearnMaui;

public partial class InputControl : ContentPage
{
	public InputControl()
	{
		InitializeComponent();
	}

	private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		Slider1Result.Text = Slider1.Value.ToString();
	}

	private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		Slider1Result.Text = Stepper.Value.ToString();
	}
}