using System.Drawing;
using TEKSOLPRIME6.Login.Controls;
using Wisej.Web;

namespace TEKSOLPRIME6.Login.Pages
{
    partial class LoginPage
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
            this.tlpMain = new Wisej.Web.TableLayoutPanel();
            this.brandPanel = new TEKSOLPRIME6.Login.Controls.BrandPanel();
            this.tlpContent = new Wisej.Web.TableLayoutPanel();
            this.tlpCardHost = new Wisej.Web.TableLayoutPanel();
            this.loginCard = new TEKSOLPRIME6.Login.Controls.LoginCard();
            this.loginFooter = new TEKSOLPRIME6.Login.Controls.LoginFooter();
            this.tlpMain.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpCardHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 32F));
            this.tlpMain.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 68F));
            this.tlpMain.Controls.Add(this.brandPanel, 0, 0);
            this.tlpMain.Controls.Add(this.tlpContent, 1, 0);
            this.tlpMain.Dock = Wisej.Web.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1095, 680);
            this.tlpMain.TabIndex = 0;
            // 
            // brandPanel
            // 
            this.brandPanel.Dock = Wisej.Web.DockStyle.Fill;
            this.brandPanel.Margin = new Wisej.Web.Padding(0);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Size = new System.Drawing.Size(350, 680);
            this.brandPanel.TabIndex = 0;
            // 
            // tlpContent
            // 
            this.tlpContent.BackColor = System.Drawing.Color.Transparent;
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tlpContent.Controls.Add(this.tlpCardHost, 0, 0);
            this.tlpContent.Controls.Add(this.loginFooter, 0, 1);
            this.tlpContent.Dock = Wisej.Web.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(350, 0);
            this.tlpContent.Margin = new Wisej.Web.Padding(0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 2;
            this.tlpContent.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tlpContent.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 44F));
            this.tlpContent.Size = new System.Drawing.Size(745, 680);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpCardHost
            // 
            this.tlpCardHost.BackColor = System.Drawing.Color.Transparent;
            this.tlpCardHost.ColumnCount = 3;
            this.tlpCardHost.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tlpCardHost.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
            this.tlpCardHost.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tlpCardHost.Controls.Add(this.loginCard, 1, 1);
            this.tlpCardHost.Dock = Wisej.Web.DockStyle.Fill;
            this.tlpCardHost.Location = new System.Drawing.Point(0, 0);
            this.tlpCardHost.Margin = new Wisej.Web.Padding(0);
            this.tlpCardHost.Name = "tlpCardHost";
            this.tlpCardHost.RowCount = 3;
            this.tlpCardHost.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tlpCardHost.RowStyles.Add(new Wisej.Web.RowStyle());
            this.tlpCardHost.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tlpCardHost.Size = new System.Drawing.Size(745, 636);
            this.tlpCardHost.TabIndex = 0;
            // 
            // loginCard
            // 
            this.loginCard.Anchor = Wisej.Web.AnchorStyles.None;
            this.loginCard.Location = new System.Drawing.Point(152, 34);
            this.loginCard.Margin = new Wisej.Web.Padding(0, 16, 0, 16);
            this.loginCard.Name = "loginCard";
            this.loginCard.TabIndex = 0;
            // 
            // loginFooter
            // 
            this.loginFooter.Dock = Wisej.Web.DockStyle.Fill;
            this.loginFooter.Location = new System.Drawing.Point(0, 636);
            this.loginFooter.Margin = new Wisej.Web.Padding(0);
            this.loginFooter.Name = "loginFooter";
            this.loginFooter.Size = new System.Drawing.Size(745, 44);
            this.loginFooter.TabIndex = 1;
            // 
            // LoginPage
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.tlpMain);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1095, 604);
            this.tlpMain.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.tlpCardHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private BrandPanel brandPanel;
        private TableLayoutPanel tlpContent;
        private TableLayoutPanel tlpCardHost;
        private LoginCard loginCard;
        private LoginFooter loginFooter;
    }
}