namespace Cap;

public partial class LoginPage : ContentPage
{
	LoginPageViewModel viewModel;
	public LoginPage()
	{
		viewModel = new LoginPageViewModel();
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
		labelErr.Text = "Mật khẩu của bạn không đúng";
		labelErr.TextColor = Colors.Red;
    }
}