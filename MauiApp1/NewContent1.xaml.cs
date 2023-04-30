namespace MauiApp1;

public partial class NewContent1 : ContentView
{
	public NewContent1()
	{
		InitializeComponent();
	}

	public String welcome_text
	{
		get { return welcome.Text; }
		set 
		{
			welcome.Text = value;
		}
	}
}