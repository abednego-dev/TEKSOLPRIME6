using System;
using System.Drawing;
using TEKSOLPRIME6.Login;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls;

/// <summary>
/// Popup shown when the account already has an active session. Raises an event when the user
/// presses Flash Out; the login page runs the legacy logic.
/// </summary>
public partial class FlashOutDialog : Form
{
    private readonly string _flashOutButtonText;

    public FlashOutDialog()
    {
        InitializeComponent();
        ApplyStyle();

        _flashOutButtonText = btnFlashOut.Text;

        btnFlashOut.Click += BtnFlashOut_Click;
        btnClose.Click += BtnClose_Click;
        Load += FlashOutDialog_Load;
    }

    /// <summary>Raised when the user presses Flash Out. The password may be empty.</summary>
    public event EventHandler? FlashOutRequested;

    /// <summary>The password typed in the popup (legacy txtFlashOutPassword.Text).</summary>
    public string Password => txtPassword.Text;

    public void SetBusy(bool isBusy)
    {
        txtPassword.Enabled = !isBusy;
        btnFlashOut.Enabled = !isBusy;
        btnClose.Enabled = !isBusy;
        btnFlashOut.Text = isBusy ? "Please wait..." : _flashOutButtonText;
    }

    public void ShowMessage(string message) => lblError.Text = message;

    protected virtual void OnFlashOutRequested(EventArgs e) => FlashOutRequested?.Invoke(this, e);

    private void ApplyStyle()
    {
        BackColor = Color.White;

        LoginTheme.StylePrimaryButton(btnFlashOut, 16);
        LoginTheme.StyleSecondaryButton(btnClose, 16);

        lblMessage.Font = LoginTheme.CreateFont(15);
        lblMessage.ForeColor = LoginTheme.Text;

        lblPassword.Font = LoginTheme.CreateFont(15);
        lblPassword.ForeColor = LoginTheme.Text;

        txtPassword.Font = LoginTheme.CreateFont(16);
        txtPassword.ForeColor = LoginTheme.Text;

        lblError.Font = LoginTheme.CreateFont(14);
        lblError.ForeColor = LoginTheme.Error;
    }

    private void FlashOutDialog_Load(object? sender, EventArgs e) => txtPassword.Focus();

    private void BtnFlashOut_Click(object? sender, EventArgs e) => OnFlashOutRequested(EventArgs.Empty);

    private void BtnClose_Click(object? sender, EventArgs e) => Close();
}