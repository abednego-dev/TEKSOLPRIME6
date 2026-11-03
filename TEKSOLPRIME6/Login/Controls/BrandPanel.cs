using TEKSOLPRIME6.Login;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls;

/// <summary>Static product branding on the left of the login screen. The same for every client.</summary>
public partial class BrandPanel : UserControl
{
    public BrandPanel()
    {
        InitializeComponent();
        ApplyStyle();
    }

    private void ApplyStyle()
    {
        BackColor = LoginTheme.Primary;
        CssStyle = LoginTheme.BrandPanelCss;
        pnlMesh.CssStyle = LoginTheme.MeshCss;
    }
}