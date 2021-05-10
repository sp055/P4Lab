
namespace ZD5
{
    partial class Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bZaloguj = new System.Windows.Forms.Button();
            this.lLogin = new System.Windows.Forms.Label();
            this.lHaslo = new System.Windows.Forms.Label();
            this.lMainLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // bZaloguj
            // 
            this.bZaloguj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bZaloguj.Location = new System.Drawing.Point(0, 224);
            this.bZaloguj.Name = "bZaloguj";
            this.bZaloguj.Size = new System.Drawing.Size(434, 37);
            this.bZaloguj.TabIndex = 3;
            this.bZaloguj.Text = "Zaloguj";
            this.bZaloguj.UseVisualStyleBackColor = true;
            this.bZaloguj.Click += new System.EventHandler(this.bZaloguj_Click);
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(83, 73);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(36, 13);
            this.lLogin.TabIndex = 4;
            this.lLogin.Text = "Login:";
            // 
            // lHaslo
            // 
            this.lHaslo.AutoSize = true;
            this.lHaslo.Location = new System.Drawing.Point(80, 99);
            this.lHaslo.Name = "lHaslo";
            this.lHaslo.Size = new System.Drawing.Size(39, 13);
            this.lHaslo.TabIndex = 5;
            this.lHaslo.Text = "Hasło:";
            // 
            // lMainLogin
            // 
            this.lMainLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lMainLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMainLogin.Location = new System.Drawing.Point(0, 0);
            this.lMainLogin.Name = "lMainLogin";
            this.lMainLogin.Size = new System.Drawing.Size(434, 67);
            this.lMainLogin.TabIndex = 6;
            this.lMainLogin.Text = "Login";
            this.lMainLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.lMainLogin);
            this.Controls.Add(this.lHaslo);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.bZaloguj);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bZaloguj;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lHaslo;
        private System.Windows.Forms.Label lMainLogin;
    }
}