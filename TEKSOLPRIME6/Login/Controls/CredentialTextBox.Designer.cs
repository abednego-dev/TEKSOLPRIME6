using Wisej.Web;
using System.Drawing;

namespace TEKSOLPRIME6.Login.Controls
{
    partial class CredentialTextBox
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
            this.pnlIcon = new Panel();
            this.picIcon = new PictureBox();
            this.pnlInput = new Panel();
            this.txtInput = new TextBox();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.picIcon);
            this.pnlIcon.Dock = DockStyle.Left;
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Padding = new Padding(14);
            this.pnlIcon.Size = new Size(56, 52);
            this.pnlIcon.TabIndex = 1;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = Color.Transparent;
            this.picIcon.Dock = DockStyle.Fill;
            this.picIcon.Name = "picIcon";
            this.picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            this.picIcon.TabStop = false;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = Color.Transparent;
            this.pnlInput.Controls.Add(this.txtInput);
            this.pnlInput.Dock = DockStyle.Fill;
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new Padding(14, 0, 10, 0);
            this.pnlInput.Size = new Size(324, 52);
            this.pnlInput.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.AutoSize = false;
            this.txtInput.BackColor = Color.Transparent;
            this.txtInput.BorderStyle = BorderStyle.None;
            this.txtInput.Dock = DockStyle.Fill;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new Size(300, 52);
            this.txtInput.TabIndex = 0;
            // 
            // CredentialTextBox
            // 
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlIcon);
            this.MinimumSize = new Size(160, 52);
            this.Name = "CredentialTextBox";
            this.Size = new Size(380, 52);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlIcon;
        private PictureBox picIcon;
        private Panel pnlInput;
        private TextBox txtInput;
    }
}