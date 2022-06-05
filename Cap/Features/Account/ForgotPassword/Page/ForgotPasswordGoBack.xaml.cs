namespace Cap;

public partial class ForgotPasswordGoBack : ContentPage
{
	public ForgotPasswordGoBack()
	{
		InitializeComponent();
	}

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(TabPage));
    }
}