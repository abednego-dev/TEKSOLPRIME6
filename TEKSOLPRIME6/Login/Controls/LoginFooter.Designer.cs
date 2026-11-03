using Wisej.Web;
using System.Drawing;

namespace TEKSOLPRIME6.Login.Controls
{
    partial class LoginFooter
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
            this.lblCaption = new Label();
            this.lblLicensedTo = new Label();
            this.tlpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.BackColor = Color.Transparent;
            this.tlpLayout.ColumnCount = 3;
            this.tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tlpLayout.Controls.Add(this.lblCaption, 1, 0);
            this.tlpLayout.Controls.Add(this.lblLicensedTo, 2, 0);
            this.tlpLayout.Dock = DockStyle.Fill;
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.Padding = new Padding(0, 0, 32, 0);
            this.tlpLayout.RowCount = 1;
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tlpLayout.Size = new Size(600, 44);
            this.tlpLayout.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = AnchorStyles.None;
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = Color.Transparent;
            this.lblCaption.Margin = new Padding(0, 0, 8, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Licensed To:";
            // 
            // lblLicensedTo
            // 
            this.lblLicensedTo.Anchor = AnchorStyles.None;
            this.lblLicensedTo.AutoSize = true;
            this.lblLicensedTo.BackColor = Color.Transparent;
            this.lblLicensedTo.Name = "lblLicensedTo";
            this.lblLicensedTo.TabIndex = 1;
            this.lblLicensedTo.Text = "Company Name";
            // 
            // LoginFooter
            // 
            this.BackColor = Color.Transparent;
            this.Controls.Add(this.tlpLayout);
            this.MinimumSize = new Size(240, 44);
            this.Name = "LoginFooter";
            this.Size = new Size(600, 44);
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private Label lblCaption;
        private Label lblLicensedTo;
    }
}