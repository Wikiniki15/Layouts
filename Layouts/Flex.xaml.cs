namespace Layouts;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}
    private void BaAbsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Absolute());
    }
}