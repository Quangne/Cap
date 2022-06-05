namespace Cap;

public partial class ForgotPasswordPage : ContentPage
{
    public ForgotPasswordPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ForgotPasswordVerify));
    }
}