
namespace SMMOB
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bot_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.showPassword = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.travel_page_button = new System.Windows.Forms.Button();
            this.captcha_page_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bot_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bot_panel
            // 
            this.bot_panel.BackColor = System.Drawing.Color.White;
            this.bot_panel.Controls.Add(this.label12);
            this.bot_panel.Controls.Add(this.label11);
            this.bot_panel.Controls.Add(this.captcha_page_button);
            this.bot_panel.Controls.Add(this.travel_page_button);
            this.bot_panel.Controls.Add(this.label8);
            this.bot_panel.Controls.Add(this.label6);
            this.bot_panel.Controls.Add(this.label5);
            this.bot_panel.Controls.Add(this.label10);
            this.bot_panel.Controls.Add(this.label9);
            this.bot_panel.Controls.Add(this.label7);
            this.bot_panel.Controls.Add(this.label4);
            this.bot_panel.Controls.Add(this.label3);
            this.bot_panel.Controls.Add(this.label2);
            this.bot_panel.Controls.Add(this.progressBar3);
            this.bot_panel.Controls.Add(this.progressBar2);
            this.bot_panel.Controls.Add(this.progressBar1);
            this.bot_panel.Controls.Add(this.showPassword);
            this.bot_panel.Controls.Add(this.login);
            this.bot_panel.Controls.Add(this.label1);
            this.bot_panel.Controls.Add(this.password);
            this.bot_panel.Controls.Add(this.email);
            this.bot_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bot_panel.Location = new System.Drawing.Point(0, 0);
            this.bot_panel.Name = "bot_panel";
            this.bot_panel.Size = new System.Drawing.Size(197, 619);
            this.bot_panel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Players Online: ???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "-/-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "-/-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "-/-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Experience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Energy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level ???";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(8, 443);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(179, 10);
            this.progressBar3.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(8, 414);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(179, 10);
            this.progressBar2.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 385);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // showPassword
            // 
            this.showPassword.Location = new System.Drawing.Point(171, 51);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(20, 20);
            this.showPassword.TabIndex = 4;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.login.Location = new System.Drawing.Point(12, 77);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(179, 23);
            this.login.TabIndex = 3;
            this.login.Text = "Save Credentials (and Login)";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Auto Login";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 51);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(153, 20);
            this.password.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 25);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(179, 20);
            this.email.TabIndex = 0;
            // 
            // browser
            // 
            this.browser.ActivateBrowserOnCreation = false;
// TODO: Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." beim Generieren des Codes für "".
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(197, 0);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(917, 619);
            this.browser.TabIndex = 1;
            // 
            // update
            // 
            this.update.Interval = 20000;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // travel_page_button
            // 
            this.travel_page_button.Location = new System.Drawing.Point(12, 141);
            this.travel_page_button.Name = "travel_page_button";
            this.travel_page_button.Size = new System.Drawing.Size(179, 23);
            this.travel_page_button.TabIndex = 22;
            this.travel_page_button.Text = "Go to Travel Page";
            this.travel_page_button.UseVisualStyleBackColor = true;
            this.travel_page_button.Click += new System.EventHandler(this.travel_page_button_Click);
            // 
            // captcha_page_button
            // 
            this.captcha_page_button.Location = new System.Drawing.Point(12, 186);
            this.captcha_page_button.Name = "captcha_page_button";
            this.captcha_page_button.Size = new System.Drawing.Size(179, 23);
            this.captcha_page_button.TabIndex = 23;
            this.captcha_page_button.Text = "Go to Captcha Page";
            this.captcha_page_button.UseVisualStyleBackColor = true;
            this.captcha_page_button.Click += new System.EventHandler(this.captcha_page_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Travel Bot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 26);
            this.label12.TabIndex = 25;
            this.label12.Text = "Captcha Bot (Experimental)\r\n-> Run this in a second Window";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 619);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.bot_panel);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.bot_panel.ResumeLayout(false);
            this.bot_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bot_panel;
        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Button travel_page_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button captcha_page_button;
    }
}

