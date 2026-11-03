using Wisej.Web;
using System.Drawing;

namespace TEKSOLPRIME6.Login.Controls
{
    partial class LoginHeader
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
            this.tlpLayout = new Wisej.Web.TableLayoutPanel();
            this.pnlBanner = new Wisej.Web.Panel();
            this.picLogo = new Wisej.Web.PictureBox();
            this.lblWelcome = new Wisej.Web.Label();
            this.lblBankName = new Wisej.Web.Label();
            this.lblSubtitle = new Wisej.Web.Label();
            this.tlpVersion = new Wisej.Web.TableLayoutPanel();
            this.pnlLineLeft = new Wisej.Web.Panel();
            this.lblVersion = new Wisej.Web.Label();
            this.pnlLineRight = new Wisej.Web.Panel();
            this.tlpLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 1;
            this.tlpLayout.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tlpLayout.Controls.Add(this.pnlBanner, 0, 0);
            this.tlpLayout.Controls.Add(this.picLogo, 0, 1);
            this.tlpLayout.Controls.Add(this.lblWelcome, 0, 2);
            this.tlpLayout.Controls.Add(this.lblBankName, 0, 3);
            this.tlpLayout.Controls.Add(this.lblSubtitle, 0, 4);
            this.tlpLayout.Controls.Add(this.tlpVersion, 0, 5);
            this.tlpLayout.Dock = Wisej.Web.DockStyle.Fill;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 6;
            this.tlpLayout.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 56F));
            this.tlpLayout.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 100F));
            this.tlpLayout.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 32F));
            this.tlpLayout.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 40F));
            this.tlpLayout.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tlpLayout.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 26F));
            this.tlpLayout.Size = new System.Drawing.Size(420, 280);
            this.tlpLayout.TabIndex = 0;
            // 
            // pnlBanner
            // 
            this.pnlBanner.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Margin = new Wisej.Web.Padding(0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(420, 56);
            this.pnlBanner.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Dock = Wisej.Web.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(0, 64);
            this.picLogo.Margin = new Wisej.Web.Padding(0, 8, 0, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(420, 88);
            this.picLogo.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = Wisej.Web.DockStyle.Fill;
            this.lblWelcome.Location = new System.Drawing.Point(3, 159);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(414, 26);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankName
            // 
            this.lblBankName.Dock = Wisej.Web.DockStyle.Fill;
            this.lblBankName.Location = new System.Drawing.Point(3, 191);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(414, 34);
            this.lblBankName.TabIndex = 3;
            this.lblBankName.Text = "Bank Name";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = Wisej.Web.DockStyle.Fill;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 231);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(414, 20);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "Core Banking System (CBS)";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpVersion
            // 
            this.tlpVersion.ColumnCount = 3;
            this.tlpVersion.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tlpVersion.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
            this.tlpVersion.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tlpVersion.Controls.Add(this.pnlLineLeft, 0, 0);
            this.tlpVersion.Controls.Add(this.lblVersion, 1, 0);
            this.tlpVersion.Controls.Add(this.pnlLineRight, 2, 0);
            this.tlpVersion.Dock = Wisej.Web.DockStyle.Fill;
            this.tlpVersion.Location = new System.Drawing.Point(40, 254);
            this.tlpVersion.Margin = new Wisej.Web.Padding(40, 0, 40, 0);
            this.tlpVersion.Name = "tlpVersion";
            this.tlpVersion.RowCount = 1;
            this.tlpVersion.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tlpVersion.Size = new System.Drawing.Size(340, 26);
            this.tlpVersion.TabIndex = 5;
            // 
            // pnlLineLeft
            // 
            this.pnlLineLeft.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.pnlLineLeft.Location = new System.Drawing.Point(0, 12);
            this.pnlLineLeft.Margin = new Wisej.Web.Padding(0, 0, 10, 0);
            this.pnlLineLeft.Name = "pnlLineLeft";
            this.pnlLineLeft.Size = new System.Drawing.Size(134, 2);
            this.pnlLineLeft.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = Wisej.Web.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(147, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v6.0.0";
            // 
            // pnlLineRight
            // 
            this.pnlLineRight.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.pnlLineRight.Location = new System.Drawing.Point(206, 12);
            this.pnlLineRight.Margin = new Wisej.Web.Padding(10, 0, 0, 0);
            this.pnlLineRight.Name = "pnlLineRight";
            this.pnlLineRight.Size = new System.Drawing.Size(134, 2);
            this.pnlLineRight.TabIndex = 2;
            // 
            // LoginHeader
            // 
            this.Controls.Add(this.tlpLayout);
            this.MinimumSize = new System.Drawing.Size(320, 280);
            this.Name = "LoginHeader";
            this.Size = new System.Drawing.Size(420, 280);
            this.tlpLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpVersion.ResumeLayout(false);
            this.tlpVersion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private Panel pnlBanner;
        private PictureBox picLogo;
        private Label lblWelcome;
        private Label lblBankName;
        private Label lblSubtitle;
        private TableLayoutPanel tlpVersion;
        private Panel pnlLineLeft;
        private Label lblVersion;
        private Panel pnlLineRight;
    }
}