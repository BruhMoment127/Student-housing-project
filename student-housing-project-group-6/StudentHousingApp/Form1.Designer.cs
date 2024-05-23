
namespace StudentHousingApp
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
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.newAccountPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountTypeBox = new System.Windows.Forms.ComboBox();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.newUsernameTextbox = new System.Windows.Forms.TextBox();
            this.makeAccountButton = new System.Windows.Forms.Button();
            this.JoinHousePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.JoinButton = new System.Windows.Forms.Button();
            this.joinCodeInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdminMainMenuPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanelAdmin = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.newAccountPanel.SuspendLayout();
            this.JoinHousePanel.SuspendLayout();
            this.AdminMainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(278, 297);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(167, 47);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(360, 165);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(146, 26);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(360, 217);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(146, 26);
            this.passwordInput.TabIndex = 2;
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(278, 360);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(167, 47);
            this.newAccountButton.TabIndex = 3;
            this.newAccountButton.Text = "make new account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.usernameInput);
            this.LoginPanel.Controls.Add(this.newAccountButton);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.loginButton);
            this.LoginPanel.Controls.Add(this.passwordInput);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(3, 3);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(794, 447);
            this.LoginPanel.TabIndex = 6;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newAccountPanel
            // 
            this.newAccountPanel.Controls.Add(this.label5);
            this.newAccountPanel.Controls.Add(this.AccountTypeBox);
            this.newAccountPanel.Controls.Add(this.backToLoginButton);
            this.newAccountPanel.Controls.Add(this.label4);
            this.newAccountPanel.Controls.Add(this.label3);
            this.newAccountPanel.Controls.Add(this.newPasswordTextbox);
            this.newAccountPanel.Controls.Add(this.newUsernameTextbox);
            this.newAccountPanel.Controls.Add(this.makeAccountButton);
            this.newAccountPanel.Location = new System.Drawing.Point(3, 3);
            this.newAccountPanel.Name = "newAccountPanel";
            this.newAccountPanel.Size = new System.Drawing.Size(794, 447);
            this.newAccountPanel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account type";
            // 
            // AccountTypeBox
            // 
            this.AccountTypeBox.FormattingEnabled = true;
            this.AccountTypeBox.Items.AddRange(new object[] {
            "Resident",
            "Admin"});
            this.AccountTypeBox.Location = new System.Drawing.Point(393, 240);
            this.AccountTypeBox.Name = "AccountTypeBox";
            this.AccountTypeBox.Size = new System.Drawing.Size(121, 28);
            this.AccountTypeBox.TabIndex = 6;
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.Location = new System.Drawing.Point(337, 338);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(75, 33);
            this.backToLoginButton.TabIndex = 5;
            this.backToLoginButton.Text = "Back";
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Location = new System.Drawing.Point(393, 185);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(100, 26);
            this.newPasswordTextbox.TabIndex = 2;
            // 
            // newUsernameTextbox
            // 
            this.newUsernameTextbox.Location = new System.Drawing.Point(393, 133);
            this.newUsernameTextbox.Name = "newUsernameTextbox";
            this.newUsernameTextbox.Size = new System.Drawing.Size(100, 26);
            this.newUsernameTextbox.TabIndex = 1;
            // 
            // makeAccountButton
            // 
            this.makeAccountButton.Location = new System.Drawing.Point(317, 297);
            this.makeAccountButton.Name = "makeAccountButton";
            this.makeAccountButton.Size = new System.Drawing.Size(128, 35);
            this.makeAccountButton.TabIndex = 0;
            this.makeAccountButton.Text = "Make account";
            this.makeAccountButton.UseVisualStyleBackColor = true;
            this.makeAccountButton.Click += new System.EventHandler(this.makeAccountButton_Click);
            // 
            // JoinHousePanel
            // 
            this.JoinHousePanel.Controls.Add(this.label7);
            this.JoinHousePanel.Controls.Add(this.JoinButton);
            this.JoinHousePanel.Controls.Add(this.joinCodeInput);
            this.JoinHousePanel.Controls.Add(this.label6);
            this.JoinHousePanel.Location = new System.Drawing.Point(3, 0);
            this.JoinHousePanel.Name = "JoinHousePanel";
            this.JoinHousePanel.Size = new System.Drawing.Size(794, 447);
            this.JoinHousePanel.TabIndex = 6;
            this.JoinHousePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.JoinHousePanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Code:";
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(337, 277);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(100, 40);
            this.JoinButton.TabIndex = 2;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // joinCodeInput
            // 
            this.joinCodeInput.Location = new System.Drawing.Point(326, 223);
            this.joinCodeInput.Name = "joinCodeInput";
            this.joinCodeInput.Size = new System.Drawing.Size(140, 26);
            this.joinCodeInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Join new house";
            // 
            // AdminMainMenuPanel
            // 
            this.AdminMainMenuPanel.Controls.Add(this.mainMenuPanelAdmin);
            this.AdminMainMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminMainMenuPanel.Name = "AdminMainMenuPanel";
            this.AdminMainMenuPanel.Size = new System.Drawing.Size(794, 447);
            this.AdminMainMenuPanel.TabIndex = 1;
            // 
            // mainMenuPanelAdmin
            // 
            this.mainMenuPanelAdmin.AutoSize = true;
            this.mainMenuPanelAdmin.Location = new System.Drawing.Point(361, 171);
            this.mainMenuPanelAdmin.Name = "mainMenuPanelAdmin";
            this.mainMenuPanelAdmin.Size = new System.Drawing.Size(136, 20);
            this.mainMenuPanelAdmin.TabIndex = 0;
            this.mainMenuPanelAdmin.Text = "Admin main menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JoinHousePanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.newAccountPanel);
            this.Controls.Add(this.AdminMainMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.newAccountPanel.ResumeLayout(false);
            this.newAccountPanel.PerformLayout();
            this.JoinHousePanel.ResumeLayout(false);
            this.JoinHousePanel.PerformLayout();
            this.AdminMainMenuPanel.ResumeLayout(false);
            this.AdminMainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel newAccountPanel;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.TextBox newUsernameTextbox;
        private System.Windows.Forms.Button makeAccountButton;
        private System.Windows.Forms.ComboBox AccountTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel JoinHousePanel;
        private System.Windows.Forms.Panel AdminMainMenuPanel;
        private System.Windows.Forms.Label mainMenuPanelAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.TextBox joinCodeInput;
    }
}

