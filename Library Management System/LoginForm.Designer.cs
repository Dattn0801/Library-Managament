
namespace Library_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbClear = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbUserName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassWord = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbClear);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbPassWord);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 717);
            this.panel1.TabIndex = 0;
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbClear.Location = new System.Drawing.Point(189, 500);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(76, 28);
            this.lbClear.TabIndex = 5;
            this.lbClear.Text = "Clear";
            this.lbClear.Click += new System.EventHandler(this.lbClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(126, 425);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 57);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.AcceptsReturn = false;
            this.tbUserName.AcceptsTab = false;
            this.tbUserName.AnimationSpeed = 200;
            this.tbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbUserName.AutoSizeHeight = true;
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbUserName.BackgroundImage")));
            this.tbUserName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbUserName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbUserName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbUserName.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbUserName.BorderRadius = 1;
            this.tbUserName.BorderThickness = 1;
            this.tbUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbUserName.DefaultText = "";
            this.tbUserName.FillColor = System.Drawing.Color.White;
            this.tbUserName.HideSelection = true;
            this.tbUserName.IconLeft = null;
            this.tbUserName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.IconPadding = 10;
            this.tbUserName.IconRight = null;
            this.tbUserName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.Lines = new string[0];
            this.tbUserName.Location = new System.Drawing.Point(102, 242);
            this.tbUserName.MaxLength = 32767;
            this.tbUserName.MinimumSize = new System.Drawing.Size(2, 2);
            this.tbUserName.Modified = false;
            this.tbUserName.Multiline = false;
            this.tbUserName.Name = "tbUserName";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUserName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbUserName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUserName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUserName.OnIdleState = stateProperties8;
            this.tbUserName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbUserName.PlaceholderText = "Enter your user name";
            this.tbUserName.ReadOnly = false;
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.ShortcutsEnabled = true;
            this.tbUserName.Size = new System.Drawing.Size(260, 48);
            this.tbUserName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbUserName.TabIndex = 2;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserName.TextMarginBottom = 0;
            this.tbUserName.TextMarginLeft = 3;
            this.tbUserName.TextMarginTop = 1;
            this.tbUserName.TextPlaceholder = "Enter your user name";
            this.tbUserName.UseSystemPasswordChar = false;
            this.tbUserName.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(118, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER LOGIN";
            // 
            // tbPassWord
            // 
            this.tbPassWord.AcceptsReturn = false;
            this.tbPassWord.AcceptsTab = false;
            this.tbPassWord.AnimationSpeed = 200;
            this.tbPassWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPassWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPassWord.AutoSizeHeight = true;
            this.tbPassWord.BackColor = System.Drawing.Color.Transparent;
            this.tbPassWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassWord.BackgroundImage")));
            this.tbPassWord.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbPassWord.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPassWord.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbPassWord.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbPassWord.BorderRadius = 1;
            this.tbPassWord.BorderThickness = 1;
            this.tbPassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassWord.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbPassWord.DefaultText = "";
            this.tbPassWord.FillColor = System.Drawing.Color.White;
            this.tbPassWord.HideSelection = true;
            this.tbPassWord.IconLeft = null;
            this.tbPassWord.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassWord.IconPadding = 10;
            this.tbPassWord.IconRight = null;
            this.tbPassWord.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassWord.Lines = new string[0];
            this.tbPassWord.Location = new System.Drawing.Point(102, 338);
            this.tbPassWord.MaxLength = 32767;
            this.tbPassWord.MinimumSize = new System.Drawing.Size(2, 2);
            this.tbPassWord.Modified = false;
            this.tbPassWord.Multiline = false;
            this.tbPassWord.Name = "tbPassWord";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassWord.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbPassWord.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassWord.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassWord.OnIdleState = stateProperties4;
            this.tbPassWord.Padding = new System.Windows.Forms.Padding(3);
            this.tbPassWord.PasswordChar = '\0';
            this.tbPassWord.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPassWord.PlaceholderText = "Enter your password";
            this.tbPassWord.ReadOnly = false;
            this.tbPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassWord.SelectedText = "";
            this.tbPassWord.SelectionLength = 0;
            this.tbPassWord.SelectionStart = 0;
            this.tbPassWord.ShortcutsEnabled = true;
            this.tbPassWord.Size = new System.Drawing.Size(260, 48);
            this.tbPassWord.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbPassWord.TabIndex = 3;
            this.tbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassWord.TextMarginBottom = 0;
            this.tbPassWord.TextMarginLeft = 3;
            this.tbPassWord.TextMarginTop = 1;
            this.tbPassWord.TextPlaceholder = "Enter your password";
            this.tbPassWord.UseSystemPasswordChar = false;
            this.tbPassWord.WordWrap = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 717);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox tbUserName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.Label lbClear;
        private Bunifu.UI.WinForms.BunifuTextBox tbPassWord;
    }
}