using ImageSourceIssue.ViewModel;

namespace ImageSourceIssue;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel ViewModel;
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        ViewModel = vm;
        BindingContext = ViewModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        ViewModel.TestImage = ImageSource.FromFile("dotnet_bot.png");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        ViewModel.TestImage = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(ViewModel.base64image)));
    }
}

