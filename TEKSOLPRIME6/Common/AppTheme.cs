using System;
using System.Drawing;

namespace TEKSOLPRIME6.Common;

/// <summary>
/// Single source of truth for colors and font across the whole application.
/// </summary>
public static class AppTheme
{
    public static readonly Color Primary = Color.FromArgb(10, 63, 160);       // #0A3FA0
    public static readonly Color PrimaryLight = Color.FromArgb(11, 79, 192);  // #0B4FC0
    public static readonly Color PrimaryDeep = Color.FromArgb(8, 47, 122);    // #082F7A
    public static readonly Color Accent = Color.FromArgb(10, 92, 214);        // #0A5CD6
    public static readonly Color AccentBright = Color.FromArgb(30, 123, 240); // #1E7BF0
    public static readonly Color Highlight = Color.FromArgb(45, 140, 255);    // #2D8CFF
    public static readonly Color Text = Color.FromArgb(11, 42, 107);          // #0B2A6B
    public static readonly Color TextMuted = Color.FromArgb(85, 104, 138);    // #55688A
    public static readonly Color Border = Color.FromArgb(207, 224, 246);      // #CFE0F6
    public static readonly Color Surface = Color.FromArgb(234, 242, 253);     // #EAF2FD
    public static readonly Color SurfaceLight = Color.FromArgb(247, 250, 255);// #F7FAFF
    public static readonly Color Error = Color.FromArgb(192, 57, 43);         // #C0392B

    private const string FontFamily = "Arial";

    public static Font CreateFont(float pixelSize, FontStyle style = FontStyle.Regular) =>
        new(FontFamily, pixelSize, style, GraphicsUnit.Pixel);

    public static string Hex(Color color) => ColorTranslator.ToHtml(color);

    public static string Rgba(Color color, double alpha) =>
        FormattableString.Invariant($"rgba({color.R}, {color.G}, {color.B}, {alpha})");
}