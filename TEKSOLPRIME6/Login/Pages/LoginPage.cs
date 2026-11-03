using System;
using System.Linq;
using TEKSOLPRIME6.Login;
using TEKSOLPRIME6.Login.Controls;
//using TEKSOLPRIME6.Dashboard.Models;
//using TEKSOLPRIME6.Dashboard.Services;
//using TEKSOLPRIME6.Login.Models;
using Wisej.Web;


namespace TEKSOLPRIME6.Login.Pages;

/// <summary>
/// The sign-in screen. This file holds only the UI wiring; the legacy Logon logic goes in the
/// marked methods below.
/// </summary>
public partial class LoginPage : Page
{
    private FlashOutDialog _flashOutDialog;

    public LoginPage()
    {
        InitializeComponent();
        ApplyStyle();

        if (DesignMode)
        {
            return;
        }

        loginCard.AppVersion = GetAppVersion();
        loginCard.LoginRequested += LoginCard_LoginRequested;
        loginCard.ForgotPasswordRequested += LoginCard_ForgotPasswordRequested;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        Logon_Load();
        loginCard.FocusUsername();
    }

    // ================================================================ LEGACY INTEGRATION POINTS

    /// <summary>
    /// Legacy Logon_Load. Paste its body here. Fill the screen with:
    ///   loginCard.Subtitle     (was LblIndustrydesc)
    ///   loginCard.BankName     (was LblSoftwarename, set from the company name)
    ///   loginCard.LogoSource   (was picImage, a data URI or image path)
    ///   loginFooter.LicensedTo (was LblCompanyName, just the company name)
    /// </summary>
    private void Logon_Load()
    {
        loginCard.ClearCredentials();

        // TODO (legacy): Call_License(); Load_CompanyDetails(); ...
    }

    /// <summary>Legacy Login_User. Paste the method here. Read the fields with loginCard.Username and loginCard.Password.</summary>
    private void Login_User()
    {
        // TODO (legacy): paste Login_User() here.
    }

    /// <summary>Legacy DisplayRelogin. Shows the Flash Out popup.</summary>
    public void DisplayRelogin()
    {
        try
        {
            var dialog = new FlashOutDialog();
            dialog.FlashOutRequested += FlashOutDialog_FlashOutRequested;
            dialog.FormClosed += (s, e) => _flashOutDialog = null;

            _flashOutDialog = dialog;
            dialog.ShowDialog();
        }
        catch (Exception)
        {
            // TODO (legacy): logger.WriteLog(ex.ToString());
        }
    }

    /// <summary>
    /// Legacy btnRelogin_Click (txtFlashOutPassword_EnterKeyDown was a duplicate; Enter now presses Flash Out).
    /// Paste the btnRelogin_Click body here and use e.Password in place of txtFlashOutPassword.Text.
    /// Instead of frm.Close() and panFlashLogin.Hide(), call _flashOutDialog?.Close().
    /// Instead of clearing the fields, call loginCard.ClearCredentials().
    /// </summary>
    //private void FlashOutDialog_FlashOutRequested(object? sender, FlashOutRequestedEventArgs e)
    //{
    //    // TODO (legacy): paste btnRelogin_Click here.
    //}

    private void FlashOutDialog_FlashOutRequested(object? sender, EventArgs e)
    {
        // TODO (legacy): paste btnRelogin_Click here.
    }

    /// <summary>The "Forgot your password?" link. The legacy Logon code you shared has no handler for it.</summary>
    private void LoginCard_ForgotPasswordRequested(object? sender, EventArgs e)
    {
        // TODO: decide what the link does.
    }

    // Also paste these legacy methods below, with the replacement table applied:
    //   public bool BuildUserSession(List<sec_UserRepo> userdata, out string msg)
    //   public void ClearUserSession()

    // ================================================================ HELPERS

    /// <summary>
    /// Replaces the legacy "Context.Session.IsLoggedOn = true;". Opens the dashboard. Call it after
    /// BuildUserSession succeeds:
    ///   ShowDashboard(userdata[0].User_Id, userdata[0].User_Role_Name,
    ///                 userdata[0].Home_Branch, GlobalValue.Head_office_Host_Value_Date);
    /// </summary>
    //private void ShowDashboard(string userId, string roleName, string branchCode, DateTime businessDate)
    //{
    //    var session = new UserSession(
    //        userId,
    //        userId,
    //        roleName,
    //        branchCode,
    //        DateOnly.FromDateTime(businessDate),
    //        // TODO: replace with the user's real permissions once the dashboard menu is migrated.
    //        StubUsers.AllPermissions.ToHashSet());

    //    AppNavigator.ShowDashboard(session);
    //}

    private void LoginCard_LoginRequested(object? sender, EventArgs e)
    {
        try
        {
            Login_User();
        }
        catch (Exception)
        {
        }
    }

    private void ApplyStyle()
    {
        BackColor = LoginTheme.Surface;
        //CssStyle = LoginTheme.BackdropCss;
    }

    private static string GetAppVersion()
    {
        var version = typeof(LoginPage).Assembly.GetName().Version;
        return version is null ? "v0.0.0" : $"v{version.ToString(3)}";
    }
}