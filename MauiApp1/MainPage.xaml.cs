namespace MauiApp1;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void nextPage(object sender , EventArgs e)
	{
		this.Content = new NewContent1();
	}

}

