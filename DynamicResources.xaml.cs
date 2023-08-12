namespace Styles;

public partial class DynamicResources : ContentPage
{
	public DynamicResources()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Resources["dynamicStyle"] = Resources["fireBrickStyle"];

		/* Using a Style that we have already predefined in our Styles folder*/

		Application.Current.Resources.TryGetValue("buttonSpecial", out var newcolor);

		Resources["anotherDynamicStyle"] = (Style) newcolor;
	}
}