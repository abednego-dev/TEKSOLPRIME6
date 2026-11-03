using System.Drawing;
using TEKSOLPRIME6.Login.Controls;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Controls
{
    partial class LoginCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        // Required method for Designer support - do not modify the contents with the code editor.
        private void InitializeComponent()
        {
            this.tlpLayout = new TableLayoutPanel();
            this.loginHeader = new LoginHeader();
            this.txtUsername = new CredentialTextBox();
            this.txtPassword = new CredentialTextBox();
            this.lblError = new Label();
            this.btnLogin = new Button();
            this.lnkForgotPassword = new LinkLabel();
            this.tlpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 1;
            this.tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tlpLayout.Controls.Add(this.loginHeader, 0, 0);
            this.tlpLayout.Controls.Add(this.txtUsername, 0, 1);
            this.tlpLayout.Controls.Add(this.txtPassword, 0, 2);
            this.tlpLayout.Controls.Add(this.lblError, 0, 3);
            this.tlpLayout.Controls.Add(this.btnLogin, 0, 4);
            this.tlpLayout.Controls.Add(this.lnkForgotPassword, 0, 5);
            this.tlpLayout.Dock = DockStyle.Fill;
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 6;
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            this.tlpLayout.Size = new Size(440, 568);
            this.tlpLayout.TabIndex = 0;
            // 
            // loginHeader
            // 
            this.loginHeader.Dock = DockStyle.Fill;
            this.loginHeader.Margin = new Padding(0);
            this.loginHeader.Name = "loginHeader";
            this.loginHeader.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = DockStyle.Fill;
            this.txtUsername.IconSource = "Resources/Icons/icon-user.png";
            this.txtUsername.Margin = new Padding(40, 20, 40, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Placeholder = "Username";
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = DockStyle.Fill;
            this.txtPassword.IconSource = "Resources/Icons/icon-lock.png";
            this.txtPassword.IsPassword = true;
            this.txtPassword.Margin = new Padding(40, 20, 40, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Placeholder = "Password";
            this.txtPassword.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.Dock = DockStyle.Fill;
            this.lblError.Margin = new Padding(40, 0, 40, 0);
            this.lblError.Name = "lblError";
            this.lblError.TabIndex = 3;
            this.lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = DockStyle.Fill;
            this.btnLogin.Margin = new Padding(40, 8, 40, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.Anchor = AnchorStyles.None;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.TabIndex = 5;
            this.lnkForgotPassword.Text = "Forgot your password?";
            // 
            // LoginCard
            // 
            this.Controls.Add(this.tlpLayout);
            this.MinimumSize = new Size(360, 568);
            this.Name = "LoginCard";
            this.Size = new Size(440, 568);
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private LoginHeader loginHeader;
        private CredentialTextBox txtUsername;
        private CredentialTextBox txtPassword;
        private Label lblError;
        private Button btnLogin;
        private LinkLabel lnkForgotPassword;
    }
}