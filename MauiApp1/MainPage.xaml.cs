namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		
		if (count == 1)
			CounterBtn.Text = $"Hiciste click {count} vez";
		else
			CounterBtn.Text = $"Hiciste click {count} veces";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

