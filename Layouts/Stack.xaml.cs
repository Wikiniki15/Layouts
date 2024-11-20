namespace Layouts;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void BaFlexClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flex());
    }
}