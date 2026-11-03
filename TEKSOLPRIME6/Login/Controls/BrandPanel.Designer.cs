using Wisej.Web;
using System.Drawing;

namespace TEKSOLPRIME6.Login.Controls
{
    partial class BrandPanel
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
            this.picProductLogo = new PictureBox();
            this.pnlMesh = new Panel();
            this.tlpLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.BackColor = Color.Transparent;
            this.tlpLayout.ColumnCount = 1;
            this.tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tlpLayout.Controls.Add(this.picProductLogo, 0, 1);
            this.tlpLayout.Controls.Add(this.pnlMesh, 0, 2);
            this.tlpLayout.Dock = DockStyle.Fill;
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 3;
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            this.tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));
            this.tlpLayout.Size = new Size(460, 640);
            this.tlpLayout.TabIndex = 0;
            // 
            // picProductLogo
            // 
            this.picProductLogo.BackColor = Color.Transparent;
            this.picProductLogo.Dock = DockStyle.Fill;
            this.picProductLogo.ImageSource = "Resources/Logos/p5_desktop_bg.png";
            this.picProductLogo.Margin = new Padding(32, 0, 32, 0);
            this.picProductLogo.Name = "picProductLogo";
            this.picProductLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.picProductLogo.TabIndex = 0;
            this.picProductLogo.TabStop = false;
            // 
            // pnlMesh
            // 
            this.pnlMesh.BackColor = Color.Transparent;
            this.pnlMesh.Dock = DockStyle.Fill;
            this.pnlMesh.Margin = new Padding(0);
            this.pnlMesh.Name = "pnlMesh";
            this.pnlMesh.TabIndex = 1;
            // 
            // BrandPanel
            // 
            this.Controls.Add(this.tlpLayout);
            this.MinimumSize = new Size(320, 400);
            this.Name = "BrandPanel";
            this.Size = new Size(460, 640);
            this.tlpLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProductLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private PictureBox picProductLogo;
        private Panel pnlMesh;
    }
}