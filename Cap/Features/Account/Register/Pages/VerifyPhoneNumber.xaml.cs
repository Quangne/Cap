namespace Cap;

public partial class VerifyPhoneNumber : ContentPage
{
    private int _countSeconds = 60;

    public VerifyPhoneNumber()
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
            }
             else ResendLabel.IsVisible = false;
            return Convert.ToBoolean(_countSeconds);
        });
    }

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
        ErrLabel.IsVisible = true;
        Shell.Current.GoToAsync(nameof(TabPage));
    }
}