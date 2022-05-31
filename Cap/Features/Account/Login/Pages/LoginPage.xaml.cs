namespace Cap;

public partial class LoginPage : ContentPage
{
	LoginPageViewModel viewModel;
	public LoginPage()
	{
		viewModel = new LoginPageViewModel();
		InitializeComponent();
		BindingContext = viewModel;
		lblRegisterFucn();

    }

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
		labelErr.Text = "Mật khẩu của bạn không đúng";
		labelErr.TextColor = Colors.Red;
    }
	void lblRegisterFucn()
    {
		lblRegister.GestureRecognizers.Add(new TapGestureRecognizer()
		{
			Command = new Command(() =>
            {
				Shell.Current.GoToAsync(nameof(RegisterPage));
            })
		});
    }
}