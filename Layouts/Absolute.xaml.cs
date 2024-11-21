namespace Layouts;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}
    private void GridClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Grid());
    }
}