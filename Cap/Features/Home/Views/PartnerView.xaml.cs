namespace Cap;

public partial class PartnerView 
{
	public PartnerView()
	{
		InitializeComponent();
	}

    private void Buttonlogin_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(PairPage));
    }
}