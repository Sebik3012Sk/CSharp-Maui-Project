namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public enum Login
	{
		username = 0,
		password = 1
	}

	NewContent1 newContent = new NewContent1();

	String[] login_matej = { "Matej", "bla bla" };

    String[] login_sebastian = { "Sebastian", "nejvic tajny heslo" };

    public MainPage()
	{
		InitializeComponent();
	}

	private void nextPage(object sender , EventArgs e)
	{
		if(username.Text == login_matej[(int)Login.username] && password.Text == login_matej[(int)Login.password])
		{
			newContent.welcome_text = "Welcome " + login_matej[(int)Login.username] + " to .NET MAUI!";
            Content = newContent;
        }
        else if (username.Text == login_sebastian[(int)Login.username] && password.Text == login_sebastian[(int)Login.password])
        {
            newContent.welcome_text = "Welcome " + login_sebastian[(int)Login.username] + " to .NET MAUI!";
            Content = newContent;
        }
    }

    private void nextPageGuest(object sender, EventArgs e)
	{
        newContent.welcome_text = "Welcome Guest to .NET MAUI!";
        Content = newContent;
    }

}