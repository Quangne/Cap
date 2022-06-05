namespace Cap;

public partial class ChangePasswordPage : ContentPage
{
	public ChangePasswordPage()
	{
		InitializeComponent();
	}

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ForgotPasswordGoBack));
    }
}