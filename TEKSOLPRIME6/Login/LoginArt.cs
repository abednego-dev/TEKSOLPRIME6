using System;

namespace TEKSOLPRIME6.Login;

/// <summary>
/// Decorative artwork for the login screens, embedded as SVG data so no files need deploying.
/// </summary>
internal static class LoginArt
{
    private const string NetworkMeshSvg = """
        <svg xmlns="http://www.w3.org/2000/svg" width="460" height="420" viewBox="0 0 460 420">
          <defs>
            <radialGradient id="glow">
              <stop offset="0" stop-color="#6BB6FF" stop-opacity="0.85"/>
              <stop offset="1" stop-color="#6BB6FF" stop-opacity="0"/>
            </radialGradient>
            <radialGradient id="fade" cx="0.1" cy="1" r="0.95" fx="0.1" fy="1">
              <stop offset="0" stop-color="#FFFFFF" stop-opacity="1"/>
              <stop offset="0.5" stop-color="#FFFFFF" stop-opacity="0.7"/>
              <stop offset="1" stop-color="#FFFFFF" stop-opacity="0"/>
            </radialGradient>
            <mask id="reveal">
              <rect width="460" height="420" fill="url(#fade)"/>
            </mask>
          </defs>
          <g mask="url(#reveal)">
            <path fill="none" stroke="#FFFFFF" stroke-opacity="0.28" stroke-width="1" d="
              M40 80L150 60L270 90L390 65
              M40 80L20 180M40 80L110 200M150 60L110 200M150 60L215 165
              M270 90L215 165M270 90L320 205M390 65L320 205M390 65L430 175
              M20 180L110 200L215 165L320 205L430 175
              M20 180L60 290M110 200L60 290M110 200L165 280M215 165L165 280
              M215 165L265 300M320 205L265 300M320 205L370 275M430 175L370 275
              M60 290L165 280L265 300L370 275
              M60 290L20 370M60 290L110 385M165 280L110 385M165 280L215 360
              M265 300L215 360M265 300L320 390M370 275L320 390M370 275L425 365
              M20 370L110 385L215 360L320 390L425 365"/>
            <g fill="url(#glow)">
              <circle cx="215" cy="165" r="16"/><circle cx="165" cy="280" r="16"/>
              <circle cx="370" cy="275" r="16"/><circle cx="215" cy="360" r="16"/>
              <circle cx="20" cy="180" r="16"/><circle cx="425" cy="365" r="16"/>
            </g>
            <g fill="#FFFFFF" fill-opacity="0.75">
              <circle cx="40" cy="80" r="2.5"/><circle cx="150" cy="60" r="2.5"/>
              <circle cx="270" cy="90" r="2.5"/><circle cx="390" cy="65" r="2.5"/>
              <circle cx="110" cy="200" r="2.5"/><circle cx="320" cy="205" r="2.5"/>
              <circle cx="430" cy="175" r="2.5"/><circle cx="60" cy="290" r="2.5"/>
              <circle cx="265" cy="300" r="2.5"/><circle cx="20" cy="370" r="2.5"/>
              <circle cx="110" cy="385" r="2.5"/><circle cx="320" cy="390" r="2.5"/>
            </g>
            <g fill="#FFFFFF">
              <circle cx="215" cy="165" r="4"/><circle cx="165" cy="280" r="4"/>
              <circle cx="370" cy="275" r="4"/><circle cx="215" cy="360" r="4"/>
              <circle cx="20" cy="180" r="4"/><circle cx="425" cy="365" r="4"/>
            </g>
          </g>
        </svg>
        """;

    public static readonly string NetworkMeshUri = ToDataUri(NetworkMeshSvg);

    // Percent-encoded (no ';' or quotes) so it is safe inside a CSS url(...).
    private static string ToDataUri(string svg) =>
        "data:image/svg+xml," + Uri.EscapeDataString(svg);
}