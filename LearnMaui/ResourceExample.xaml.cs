using Android.OS;
using static Android.Content.Res.Resources;

namespace LearnMaui;

public partial class ResourceExample : ContentPage
{
	public ResourceExample()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await LoadMauiAsset();
	}

	async Task LoadMauiAsset()
{
    using var stream = await FileSystem.OpenAppPackageFileAsync("Employee.json");
    using var reader = new StreamReader(stream);

    var contents = reader.ReadToEnd();
		var result = System.Text.Json.JsonSerializer.Deserialize<Employee>(contents);
}

}

public class Employee
{
	public string Name { get; set; }
	public int Salary { get; set; }
}