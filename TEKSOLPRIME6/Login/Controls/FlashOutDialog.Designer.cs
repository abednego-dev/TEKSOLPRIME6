using Wisej.Web;
using System.Drawing;

namespace TEKSOLPRIME6.Login.Controls;

partial class FlashOutDialog
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
        this.lblMessage = new Label();
        this.tlpPassword = new TableLayoutPanel();
        this.lblPassword = new Label();
        this.txtPassword = new TextBox();
        this.lblError = new Label();
        this.tlpButtons = new TableLayoutPanel();
        this.btnFlashOut = new Button();
        this.btnClose = new Button();
        this.tlpLayout.SuspendLayout();
        this.tlpPassword.SuspendLayout();
        this.tlpButtons.SuspendLayout();
        this.SuspendLayout();
        // 
        // tlpLayout
        // 
        this.tlpLayout.ColumnCount = 1;
        this.tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tlpLayout.Controls.Add(this.lblMessage, 0, 0);
        this.tlpLayout.Controls.Add(this.tlpPassword, 0, 1);
        this.tlpLayout.Controls.Add(this.lblError, 0, 2);
        this.tlpLayout.Controls.Add(this.tlpButtons, 0, 3);
        this.tlpLayout.Dock = DockStyle.Fill;
        this.tlpLayout.Name = "tlpLayout";
        this.tlpLayout.Padding = new Padding(28, 24, 28, 20);
        this.tlpLayout.RowCount = 4;
        this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
        this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        this.tlpLayout.Size = new Size(480, 292);
        this.tlpLayout.TabIndex = 0;
        // 
        // lblMessage
        // 
        this.lblMessage.Dock = DockStyle.Fill;
        this.lblMessage.Name = "lblMessage";
        this.lblMessage.TabIndex = 0;
        this.lblMessage.Text = "Your account session is active.\r\nPlease re-enter password to close active session\r\nor contact administrator.";
        this.lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tlpPassword
        // 
        this.tlpPassword.ColumnCount = 2;
        this.tlpPassword.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        this.tlpPassword.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tlpPassword.Controls.Add(this.lblPassword, 0, 0);
        this.tlpPassword.Controls.Add(this.txtPassword, 1, 0);
        this.tlpPassword.Dock = DockStyle.Fill;
        this.tlpPassword.Margin = new Padding(0);
        this.tlpPassword.Name = "tlpPassword";
        this.tlpPassword.RowCount = 1;
        this.tlpPassword.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tlpPassword.TabIndex = 1;
        // 
        // lblPassword
        // 
        this.lblPassword.Anchor = AnchorStyles.Left;
        this.lblPassword.AutoSize = true;
        this.lblPassword.Margin = new Padding(0, 0, 14, 0);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.TabIndex = 0;
        this.lblPassword.Text = "Password";
        // 
        // txtPassword
        // 
        this.txtPassword.AutoSize = false;
        this.txtPassword.Dock = DockStyle.Fill;
        this.txtPassword.Margin = new Padding(0, 6, 0, 6);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '●';
        this.txtPassword.TabIndex = 0;
        // 
        // lblError
        // 
        this.lblError.Dock = DockStyle.Fill;
        this.lblError.Name = "lblError";
        this.lblError.TabIndex = 2;
        this.lblError.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tlpButtons
        // 
        this.tlpButtons.ColumnCount = 4;
        this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tlpButtons.Controls.Add(this.btnFlashOut, 1, 0);
        this.tlpButtons.Controls.Add(this.btnClose, 2, 0);
        this.tlpButtons.Dock = DockStyle.Fill;
        this.tlpButtons.Margin = new Padding(0);
        this.tlpButtons.Name = "tlpButtons";
        this.tlpButtons.RowCount = 1;
        this.tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tlpButtons.TabIndex = 3;
        // 
        // btnFlashOut
        // 
        this.btnFlashOut.Dock = DockStyle.Fill;
        this.btnFlashOut.Margin = new Padding(6, 8, 6, 8);
        this.btnFlashOut.Name = "btnFlashOut";
        this.btnFlashOut.TabIndex = 0;
        this.btnFlashOut.Text = "Flash Out";
        // 
        // btnClose
        // 
        this.btnClose.Dock = DockStyle.Fill;
        this.btnClose.Margin = new Padding(6, 8, 6, 8);
        this.btnClose.Name = "btnClose";
        this.btnClose.TabIndex = 1;
        this.btnClose.Text = "Close";
        // 
        // FlashOutDialog
        // 
        this.AcceptButton = this.btnFlashOut;
        this.CancelButton = this.btnClose;
        this.ControlBox = false;
        this.Controls.Add(this.tlpLayout);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = "FlashOutDialog";
        this.Size = new Size(480, 292);
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Flash Out";
        this.tlpLayout.ResumeLayout(false);
        this.tlpPassword.ResumeLayout(false);
        this.tlpPassword.PerformLayout();
        this.tlpButtons.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tlpLayout;
    private Label lblMessage;
    private TableLayoutPanel tlpPassword;
    private Label lblPassword;
    private TextBox txtPassword;
    private Label lblError;
    private TableLayoutPanel tlpButtons;
    private Button btnFlashOut;
    private Button btnClose;
}