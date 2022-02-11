namespace inventory_project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.buttonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelChildform = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            this.panelChildform.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.AutoSize = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(0, 670);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.Purple;
            this.panelInformation.Location = new System.Drawing.Point(469, 0);
            this.panelInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(797, 32);
            this.panelInformation.TabIndex = 1;
            this.panelInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInformation_Paint);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageActive = null;
            this.buttonMenu.Location = new System.Drawing.Point(4, -19);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(36, 32);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Zoom = 10;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelChildform
            // 
            this.panelChildform.BackColor = System.Drawing.Color.Fuchsia;
            this.panelChildform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelChildform.Controls.Add(this.buttonMenu);
            this.panelChildform.Location = new System.Drawing.Point(469, 32);
            this.panelChildform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(797, 638);
            this.panelChildform.TabIndex = 2;
            this.panelChildform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildform_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1267, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            this.panelChildform.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Panel panelChildform;
        private Bunifu.Framework.UI.BunifuImageButton buttonMenu;
    }
}