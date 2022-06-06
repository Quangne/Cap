using CommunityToolkit.Maui.Views;

namespace Cap;

public partial class CheckInfoPage : ContentPage
{
	public CheckInfoPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var popup = new InvitationPopup();
        popup.Size = new Size(355, 411);
        var result = await this.ShowPopupAsync(popup);
        if (result is bool boolResult)
        {
            if (boolResult)
            {
                var successPopup = new NotificationSuccessPopup();
                successPopup.Size = new Size(335, 298);
                this.ShowPopup(successPopup);
            }
            else
            {
                var failPopup = new NotificationFailPopup();
                failPopup.Size = new Size(335, 298);
                this.ShowPopup(failPopup);
            }
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(TabPage));
    }
}