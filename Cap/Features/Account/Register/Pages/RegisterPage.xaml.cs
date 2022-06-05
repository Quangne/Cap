namespace Cap;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new ForgotPasswordGoBack());
        Shell.Current.GoToAsync(nameof(VerifyPhoneNumber));
    }
}