namespace Layouts;

public partial class Grid : ContentPage
{
	public Grid()
	{
		InitializeComponent();
	}

    private void BaStackClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stack());
    }
    
}