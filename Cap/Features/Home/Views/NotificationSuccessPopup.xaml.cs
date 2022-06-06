using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;
namespace Cap;

public partial class NotificationSuccessPopup
{
	public NotificationSuccessPopup()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}