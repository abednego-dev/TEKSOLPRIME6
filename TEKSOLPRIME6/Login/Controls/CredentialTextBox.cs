using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls;

/// <summary>A text field with a leading icon tile. Styled from the global theme.</summary>
public partial class CredentialTextBox : UserControl
{
    private const char MaskCharacter = '●';

    public CredentialTextBox()
    {
        InitializeComponent();
        ApplyStyle();
        txtInput.KeyDown += TxtInput_KeyDown;
    }

    /// <summary>Raised when the user presses Enter inside the field.</summary>
    public event EventHandler? SubmitRequested;

    [Category("Appearance"), DefaultValue(null)]
    public string? IconSource
    {
        get => picIcon.ImageSource;
        set => picIcon.ImageSource = value;
    }

    [Category("Appearance"), DefaultValue("")]
    public string Placeholder
    {
        get => txtInput.Watermark;
        set => txtInput.Watermark = value;
    }

    [Category("Behavior"), DefaultValue(false)]
    public bool IsPassword
    {
        get => txtInput.PasswordChar != '\0';
        set => txtInput.PasswordChar = value ? MaskCharacter : '\0';
    }

    [Browsable(true), DefaultValue("")]
    public override string Text
    {
        get => txtInput.Text;
        set => txtInput.Text = value;
    }

    public void FocusInput() => txtInput.Focus();

    public void Clear() => txtInput.Clear();

    protected virtual void OnSubmitRequested(EventArgs e) => SubmitRequested?.Invoke(this, e);

    private void ApplyStyle()
    {
        BackColor = Color.White;
        CssStyle = LoginTheme.InputCss;
        pnlIcon.BackColor = LoginTheme.Primary;
        txtInput.Font = LoginTheme.CreateFont(16);
        txtInput.ForeColor = LoginTheme.Text;
    }

    private void TxtInput_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            OnSubmitRequested(EventArgs.Empty);
        }
    }
}