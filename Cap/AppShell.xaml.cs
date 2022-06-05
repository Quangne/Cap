namespace Cap;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
        Routing.RegisterRoute(nameof(VerifyPhoneNumber), typeof(VerifyPhoneNumber));
        Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
        Routing.RegisterRoute(nameof(ForgotPasswordGoBack), typeof(ForgotPasswordGoBack));
        Routing.RegisterRoute(nameof(ForgotPasswordVerify), typeof(ForgotPasswordVerify));
        Routing.RegisterRoute(nameof(TabPage), typeof(TabPage));
        Routing.RegisterRoute(nameof(MyIDPage), typeof(MyIDPage));
        Routing.RegisterRoute(nameof(FindIdPage), typeof(FindIdPage));
        Routing.RegisterRoute(nameof(PairPage), typeof(PairPage));
    }
}
