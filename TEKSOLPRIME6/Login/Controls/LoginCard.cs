using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls;

/// <summary>
/// The sign-in card. It only raises events and exposes the fields; the page runs the sign-in logic.
/// </summary>
public partial class LoginCard : UserControl
{
    private readonly string _loginButtonText;

    public LoginCard()
    {
        InitializeComponent();
        ApplyStyle();

        _loginButtonText = btnLogin.Text;

        btnLogin.Click += BtnLogin_Click;
        txtUsername.SubmitRequested += TxtUsername_SubmitRequested;
        txtPassword.SubmitRequested += TxtPassword_SubmitRequested;
        lnkForgotPassword.Click += LnkForgotPassword_Click;
    }

    /// <summary>Raised when the user presses Login or Enter. The fields may be empty.</summary>
    public event EventHandler? LoginRequested;

    /// <summary>Raised when the user clicks "Forgot your password?".</summary>
    public event EventHandler? ForgotPasswordRequested;

    [Category("Data"), DefaultValue("Bank Name")]
    public string BankName
    {
        get => loginHeader.BankName;
        set => loginHeader.BankName = value;
    }

    [Category("Data"), DefaultValue(null)]
    public string? LogoSource
    {
        get => loginHeader.LogoSource;
        set => loginHeader.LogoSource = value;
    }

    /// <summary>The client logo as an image object (legacy picImage.Image).</summary>
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Image? LogoImage
    {
        get => loginHeader.LogoImage;
        set => loginHeader.LogoImage = value;
    }

    [Category("Data"), DefaultValue("v0.0.0")]
    public string AppVersion
    {
        get => loginHeader.AppVersion;
        set => loginHeader.AppVersion = "v6.0.0";
    }

    [Category("Data"), DefaultValue("Core Banking System (CBS)")]
    public string Subtitle
    {
        get => loginHeader.Subtitle;
        set => loginHeader.Subtitle = value;
    }

    [Category("Data"), DefaultValue("Welcome to")]
    public string WelcomeText
    {
        get => loginHeader.WelcomeText;
        set => loginHeader.WelcomeText = value;
    }

    [Category("Data"), DefaultValue("Forgot your password?")]
    public string ForgotPasswordText
    {
        get => lnkForgotPassword.Text;
        set => lnkForgotPassword.Text = value;
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Username
    {
        get => txtUsername.Text;
        set => txtUsername.Text = value;
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Password
    {
        get => txtPassword.Text;
        set => txtPassword.Text = value;
    }

    /// <summary>Shows or hides the busy state while a sign-in is in progress.</summary>
    public void SetBusy(bool isBusy)
    {
        txtUsername.Enabled = !isBusy;
        txtPassword.Enabled = !isBusy;
        btnLogin.Enabled = !isBusy;
        lnkForgotPassword.Enabled = !isBusy;
        btnLogin.Text = isBusy ? "Signing in..." : _loginButtonText;
    }

    public void ShowError(string message) => lblError.Text = message;

    public void ClearError() => lblError.Text = string.Empty;

    public void ClearPassword()
    {
        txtPassword.Clear();
        txtPassword.FocusInput();
    }

    /// <summary>Clears the username and password.</summary>
    public void ClearCredentials()
    {
        txtUsername.Clear();
        txtPassword.Clear();
    }

    public void FocusUsername() => txtUsername.FocusInput();

    protected virtual void OnLoginRequested(EventArgs e) => LoginRequested?.Invoke(this, e);

    protected virtual void OnForgotPasswordRequested(EventArgs e) => ForgotPasswordRequested?.Invoke(this, e);

    private void ApplyStyle()
    {
        LoginTheme.StyleCard(this);
        LoginTheme.StylePrimaryButton(btnLogin, 20);

        lblError.Font = LoginTheme.CreateFont(14);
        lblError.ForeColor = LoginTheme.Error;

        lnkForgotPassword.Font = LoginTheme.CreateFont(15);
    }

    private void SubmitLogin() => OnLoginRequested(EventArgs.Empty);

    private void BtnLogin_Click(object? sender, EventArgs e) => SubmitLogin();

    // Legacy behavior: Enter on the username logs in when the password is already filled, otherwise moves on.
    private void TxtUsername_SubmitRequested(object? sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtPassword.Text))
        {
            SubmitLogin();
        }
        else
        {
            txtPassword.FocusInput();
        }
    }

    private void TxtPassword_SubmitRequested(object? sender, EventArgs e) => SubmitLogin();

    private void LnkForgotPassword_Click(object? sender, EventArgs e) => OnForgotPasswordRequested(EventArgs.Empty);
}