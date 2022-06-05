namespace Cap;

public partial class ForgotPasswordVerify : ContentPage
{
    private int _countSeconds = 60;

    [Obsolete]
    public ForgotPasswordVerify()
	{
		InitializeComponent();
        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            _countSeconds--;
            CountDownLabel.Text = $"{_countSeconds}s";
            if (_countSeconds == 0)
            {
                ResendLabel.IsVisible = true;
                CountDownLabel.IsVisible = false;
                ErrLabel.IsVisible = true;
            }
            else ResendLabel.IsVisible = false;
            return Convert.ToBoolean(_countSeconds);
        });
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ChangePasswordPage));
    }
}