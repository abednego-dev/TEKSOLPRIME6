using System.ComponentModel;
using System.Drawing;
using TEKSOLPRIME6.Login;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls;

/// <summary>Footer showing the licensee of this installation, right-aligned.</summary>
public partial class LoginFooter : UserControl
{
    public LoginFooter()
    {
        InitializeComponent();
        ApplyStyle();
    }

    [Category("Data"), DefaultValue("Company Name")]
    public string LicensedTo
    {
        get => lblLicensedTo.Text;
        set => lblLicensedTo.Text = value;
    }

    private void ApplyStyle()
    {
        lblCaption.Font = LoginTheme.CreateFont(14);
        lblCaption.ForeColor = LoginTheme.TextMuted;

        lblLicensedTo.Font = LoginTheme.CreateFont(14, FontStyle.Bold);
        lblLicensedTo.ForeColor = LoginTheme.Text;
    }
}