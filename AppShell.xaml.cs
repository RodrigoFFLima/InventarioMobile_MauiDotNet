namespace InventarioMobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SignupPage), typeof(SignupPage));
		//Routing.RegisterRoute(nameof(ProductsPage), typeof(ProductsPage));
	}
}
