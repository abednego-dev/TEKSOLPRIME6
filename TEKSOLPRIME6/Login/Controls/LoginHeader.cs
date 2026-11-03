using System.ComponentModel;
using System.Drawing;
using TEKSOLPRIME6.Login;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls;

/// <summary>Top of the login card: banner, client logo, welcome text, bank name and version.</summary>
public partial class LoginHeader : UserControl
{
    public LoginHeader()
    {
        InitializeComponent();
        ApplyStyle();
    }

    [Category("Data"), DefaultValue("Bank Name")]
    public string BankName
    {
        get => lblBankName.Text;
        set => lblBankName.Text = value;
    }

    [Category("Data"), DefaultValue(null)]
    public string? LogoSource
    {
        get => picLogo.ImageSource;
        set => picLogo.ImageSource = value;
    }

    /// <summary>The client logo as an image object (legacy picImage.Image).</summary>
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Image? LogoImage
    {
        get => picLogo.Image;
        set => picLogo.Image = value;
    }

    [Category("Data"), DefaultValue("v0.0.0")]
    public string AppVersion
    {
        get => lblVersion.Text;
        set => lblVersion.Text = value;
    }

    [Category("Data"), DefaultValue("Core Banking System (CBS)")]
    public string Subtitle
    {
        get => lblSubtitle.Text;
        set => lblSubtitle.Text = value;
    }

    [Category("Data"), DefaultValue("Welcome to")]
    public string WelcomeText
    {
        get => lblWelcome.Text;
        set => lblWelcome.Text = value;
    }

    private void ApplyStyle()
    {
        pnlBanner.CssStyle = LoginTheme.BannerCss;

        lblWelcome.Font = LoginTheme.CreateFont(24);
        lblWelcome.ForeColor = LoginTheme.Text;

        lblBankName.Font = LoginTheme.CreateFont(28, FontStyle.Bold);
        lblBankName.ForeColor = LoginTheme.Text;

        lblSubtitle.Font = LoginTheme.CreateFont(16);
        lblSubtitle.ForeColor = LoginTheme.TextMuted;

        lblVersion.Font = LoginTheme.CreateFont(14);
        lblVersion.ForeColor = LoginTheme.TextMuted;

        pnlLineLeft.BackColor = LoginTheme.Border;
        pnlLineRight.BackColor = LoginTheme.Border;
    }
}