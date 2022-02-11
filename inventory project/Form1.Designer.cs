namespace inventory_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelleft = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelright = new System.Windows.Forms.Panel();
            this.ButtonEye = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Purple;
            this.panelleft.Controls.Add(this.pictureBox3);
            this.panelleft.Controls.Add(this.label1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(249, 446);
            this.panelleft.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 219);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "We Organiz";
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelright.Controls.Add(this.ButtonEye);
            this.panelright.Controls.Add(this.ButtonLogin);
            this.panelright.Controls.Add(this.bunifuThinButton21);
            this.panelright.Controls.Add(this.ButtonExit);
            this.panelright.Controls.Add(this.label6);
            this.panelright.Controls.Add(this.TextBoxUserName);
            this.panelright.Controls.Add(this.TextBoxPassword);
            this.panelright.Controls.Add(this.label5);
            this.panelright.Controls.Add(this.pictureBox2);
            this.panelright.Controls.Add(this.pictureBox1);
            this.panelright.Controls.Add(this.labelSignIn);
            this.panelright.Location = new System.Drawing.Point(249, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(368, 446);
            this.panelright.TabIndex = 1;
            this.panelright.Paint += new System.Windows.Forms.PaintEventHandler(this.panelright_Paint);
            // 
            // ButtonEye
            // 
            this.ButtonEye.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEye.ImageOptions.Image")));
            this.ButtonEye.Location = new System.Drawing.Point(302, 225);
            this.ButtonEye.Name = "ButtonEye";
            this.ButtonEye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonEye.Size = new System.Drawing.Size(22, 24);
            this.ButtonEye.TabIndex = 14;
            this.ButtonEye.Click += new System.EventHandler(this.ButtonEye_Click);
            this.ButtonEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonEye_MouseDown);
            this.ButtonEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonEye_MouseUp);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Appearance.BackColor = System.Drawing.Color.Purple;
            this.ButtonLogin.Appearance.BackColor2 = System.Drawing.Color.Purple;
            this.ButtonLogin.Appearance.BorderColor = System.Drawing.Color.Purple;
            this.ButtonLogin.Appearance.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonLogin.Appearance.Options.UseBackColor = true;
            this.ButtonLogin.Appearance.Options.UseBorderColor = true;
            this.ButtonLogin.Appearance.Options.UseFont = true;
            this.ButtonLogin.Appearance.Options.UseForeColor = true;
            this.ButtonLogin.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonLogin.AppearanceDisabled.BackColor2 = System.Drawing.Color.Maroon;
            this.ButtonLogin.AppearanceDisabled.BorderColor = System.Drawing.Color.Maroon;
            this.ButtonLogin.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonLogin.AppearanceDisabled.Options.UseBackColor = true;
            this.ButtonLogin.AppearanceDisabled.Options.UseBorderColor = true;
            this.ButtonLogin.AppearanceDisabled.Options.UseForeColor = true;
            this.ButtonLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonLogin.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonLogin.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonLogin.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonLogin.AppearanceHovered.Options.UseBorderColor = true;
            this.ButtonLogin.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.ButtonLogin.AppearancePressed.BackColor2 = System.Drawing.Color.Black;
            this.ButtonLogin.AppearancePressed.BorderColor = System.Drawing.Color.Black;
            this.ButtonLogin.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.ButtonLogin.AppearancePressed.Options.UseBackColor = true;
            this.ButtonLogin.AppearancePressed.Options.UseBorderColor = true;
            this.ButtonLogin.AppearancePressed.Options.UseForeColor = true;
            this.ButtonLogin.Location = new System.Drawing.Point(78, 306);
            this.ButtonLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.ButtonLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(246, 38);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ThinButton";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(173, 794);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(269, 111);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonExit.Location = new System.Drawing.Point(341, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(27, 25);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(177, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "2021";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxUserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserName.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TextBoxUserName.HintForeColor = System.Drawing.Color.Purple;
            this.TextBoxUserName.HintText = "Username ";
            this.TextBoxUserName.isPassword = false;
            this.TextBoxUserName.LineFocusedColor = System.Drawing.Color.Purple;
            this.TextBoxUserName.LineIdleColor = System.Drawing.Color.Purple;
            this.TextBoxUserName.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.TextBoxUserName.LineThickness = 4;
            this.TextBoxUserName.Location = new System.Drawing.Point(78, 149);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.TextBoxUserName.MaxLength = 32767;
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(246, 37);
            this.TextBoxUserName.TabIndex = 1;
            this.TextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TextBoxPassword.HintForeColor = System.Drawing.Color.Purple;
            this.TextBoxPassword.HintText = "Password";
            this.TextBoxPassword.isPassword = true;
            this.TextBoxPassword.LineFocusedColor = System.Drawing.Color.Purple;
            this.TextBoxPassword.LineIdleColor = System.Drawing.Color.Purple;
            this.TextBoxPassword.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.TextBoxPassword.LineThickness = 3;
            this.TextBoxPassword.Location = new System.Drawing.Point(78, 220);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(246, 37);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(125, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Created by Mr.Saeed";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelSignIn.Location = new System.Drawing.Point(6, 38);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(147, 61);
            this.labelSignIn.TabIndex = 3;
            this.labelSignIn.Text = "Sign In";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 446);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxUserName;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxPassword;
        private DevExpress.XtraEditors.SimpleButton ButtonEye;
        private DevExpress.XtraEditors.SimpleButton ButtonLogin;
    }
}

