namespace LearnMaui;

public partial class CommondDemo : ContentPage
{
	public CommondDemo()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Demo Title", "Sub text", "OK", "Cancel");
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("Checked Option" , $"Selected:{e.Value}", "OK");
	}

	private void Searching_SearchButtonPressed(object sender, EventArgs e)
	{
		DisplayAlert("Searching Text", $"You Search {Searching.Text}", "OK");
	}

	private void SwipeItem_Delete(object sender, EventArgs e)
	{
		DisplayAlert("Delete Item", "Are you Sure to delete item?", "Yes", "No");
	}

	private void SwipeItem_Add(object sender, EventArgs e)
	{
        DisplayAlert("Add Item", "Are you Sure to add item?", "Yes", "No");
    }
}