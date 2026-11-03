using System;
using System.Drawing;
using TEKSOLPRIME6.Common;
using Wisej.Web;

namespace TEKSOLPRIME6.Login;

/// <summary>
/// Login-screen styling built on the global AppTheme: colors, font, CSS and style helpers.
/// </summary>
internal static class LoginTheme
{
    /// <summary>Width of the left brand column in percent. Keep the page designer's column in sync with it.</summary>
    public const float BrandColumnPercent = 32F;

    // ---- Colors (global theme) ----
    public static Color Primary => AppTheme.Primary;
    public static Color PrimaryLight => AppTheme.PrimaryLight;
    public static Color PrimaryDeep => AppTheme.PrimaryDeep;
    public static Color Accent => AppTheme.Accent;
    public static Color AccentBright => AppTheme.AccentBright;
    public static Color Highlight => AppTheme.Highlight;
    public static Color Text => AppTheme.Text;
    public static Color TextMuted => AppTheme.TextMuted;
    public static Color Border => AppTheme.Border;
    public static Color Surface => AppTheme.Surface;
    public static Color SurfaceLight => AppTheme.SurfaceLight;
    public static Color Error => AppTheme.Error;

    public static Font CreateFont(float pixelSize, FontStyle style = FontStyle.Regular) =>
        AppTheme.CreateFont(pixelSize, style);

    // ---- CSS ----
    public static readonly string InputCss =
        $"border: 1px solid {Hex(Border)}; border-radius: 12px; overflow: hidden;";

    public static readonly string CardCss =
        $"border-radius: 20px; overflow: hidden; border: 1px solid {Rgba(Primary, 0.06)}; " +
        $"box-shadow: 0 20px 50px {Rgba(Primary, 0.18)};";

    public static readonly string PrimaryButtonCss =
        $"background: linear-gradient(90deg, {Hex(Accent)} 0%, {Hex(AccentBright)} 100%); " +
        $"border: none; border-radius: 26px; box-shadow: 0 8px 20px {Rgba(AccentBright, 0.35)};";

    public static readonly string SecondaryButtonCss =
        $"background: #FFFFFF; border: 1px solid {Hex(Border)}; border-radius: 26px;";

    public static readonly string BannerCss =
        $"background: linear-gradient(135deg, {Hex(Primary)} 0%, {Hex(AccentBright)} 100%); " +
        "border-radius: 0 0 100% 0 / 0 0 70% 0;";

    /// <summary>Left panel: gradient and curved edge. No shadow, because a shadow is cut off at the panel's bounds.</summary>
    public static readonly string BrandPanelCss =
        $"background: radial-gradient(circle at 18% 88%, {Rgba(Highlight, 0.4)} 0%, transparent 45%), " +
        $"radial-gradient(circle at 90% 8%, {Rgba(Color.White, 0.1)} 0%, transparent 35%), " +
        $"linear-gradient(160deg, {Hex(PrimaryLight)} 0%, {Hex(Primary)} 55%, {Hex(PrimaryDeep)} 100%); " +
        $"border-right: 8px solid {Hex(Highlight)}; " +
        "border-radius: 0 120px 120px 0 / 0 50% 50% 0; overflow: hidden;";

    

    /// <summary>
    /// Page background: one continuous gradient behind both columns, with the glow around the
    /// left panel's edge drawn as part of it. Nothing here is clipped at a column boundary.
    /// </summary>
    //public static readonly string BackdropCss =
    //    $"background: radial-gradient(ellipse 14% 80% at {BrandColumnPercent}% 50%, {Rgba(Highlight, 0.45)} 0%, transparent 100%), " +
    //    $"radial-gradient(ellipse 40% 90% at {BrandColumnPercent + 7}% 50%, {Rgba(AccentBright, 0.16)} 0%, transparent 70%), " +
    //    $"radial-gradient(circle at 92% 8%, {Rgba(AccentBright, 0.1)} 0%, transparent 40%), " +
    //    $"linear-gradient(90deg, {Hex(Surface)} 0%, {Hex(Border)} {BrandColumnPercent}%, {Hex(SurfaceLight)} 100%);";

    public static readonly string MeshCss =
        $"background-image: url('{LoginArt.NetworkMeshUri}'); " +
        "background-repeat: no-repeat; background-position: left bottom; background-size: contain;";


    // ---- Helpers ----
    public static void StyleCard(Control card)
    {
        card.BackColor = Color.White;
        card.CssStyle = CardCss;
    }

    public static void StylePrimaryButton(Button button, float fontPixelSize)
    {
        button.CssStyle = PrimaryButtonCss;
        button.Font = CreateFont(fontPixelSize, FontStyle.Bold);
        button.ForeColor = Color.White;
    }

    public static void StyleSecondaryButton(Button button, float fontPixelSize)
    {
        button.CssStyle = SecondaryButtonCss;
        button.Font = CreateFont(fontPixelSize, FontStyle.Bold);
        button.ForeColor = Primary;
    }

    private static string Hex(Color color) => ColorTranslator.ToHtml(color);

    private static string Rgba(Color color, double alpha) =>
        FormattableString.Invariant($"rgba({color.R}, {color.G}, {color.B}, {alpha})");
}