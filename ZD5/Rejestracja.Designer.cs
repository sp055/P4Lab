
namespace ZD5
{
    partial class Rejestracja
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lRejestracja = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lHaslo = new System.Windows.Forms.Label();
            this.LPowtorzHaslo = new System.Windows.Forms.Label();
            this.BZarejestruj = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtReapetPassword = new System.Windows.Forms.TextBox();
            this.cbRODO = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lRejestracja
            // 
            this.lRejestracja.Dock = System.Windows.Forms.DockStyle.Top;
            this.lRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRejestracja.Location = new System.Drawing.Point(0, 0);
            this.lRejestracja.Name = "lRejestracja";
            this.lRejestracja.Size = new System.Drawing.Size(434, 67);
            this.lRejestracja.TabIndex = 0;
            this.lRejestracja.Text = "Rejestracja";
            this.lRejestracja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(83, 73);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(36, 13);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Login:";
            // 
            // lHaslo
            // 
            this.lHaslo.AutoSize = true;
            this.lHaslo.Location = new System.Drawing.Point(80, 99);
            this.lHaslo.Name = "lHaslo";
            this.lHaslo.Size = new System.Drawing.Size(39, 13);
            this.lHaslo.TabIndex = 2;
            this.lHaslo.Text = "Hasło:";
            // 
            // LPowtorzHaslo
            // 
            this.LPowtorzHaslo.AutoSize = true;
            this.LPowtorzHaslo.Location = new System.Drawing.Point(40, 125);
            this.LPowtorzHaslo.Name = "LPowtorzHaslo";
            this.LPowtorzHaslo.Size = new System.Drawing.Size(78, 13);
            this.LPowtorzHaslo.TabIndex = 3;
            this.LPowtorzHaslo.Text = "Powrórz hasło:";
            // 
            // BZarejestruj
            // 
            this.BZarejestruj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BZarejestruj.Location = new System.Drawing.Point(0, 224);
            this.BZarejestruj.Name = "BZarejestruj";
            this.BZarejestruj.Size = new System.Drawing.Size(434, 37);
            this.BZarejestruj.TabIndex = 5;
            this.BZarejestruj.Text = "Zarejestruj";
            this.BZarejestruj.UseVisualStyleBackColor = true;
            this.BZarejestruj.Click += new System.EventHandler(this.BZarejestruj_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtReapetPassword
            // 
            this.txtReapetPassword.Location = new System.Drawing.Point(125, 122);
            this.txtReapetPassword.Name = "txtReapetPassword";
            this.txtReapetPassword.PasswordChar = '*';
            this.txtReapetPassword.Size = new System.Drawing.Size(242, 20);
            this.txtReapetPassword.TabIndex = 8;
            // 
            // cbRODO
            // 
            this.cbRODO.AutoSize = true;
            this.cbRODO.Location = new System.Drawing.Point(125, 148);
            this.cbRODO.Name = "cbRODO";
            this.cbRODO.Size = new System.Drawing.Size(92, 17);
            this.cbRODO.TabIndex = 9;
            this.cbRODO.Text = "Zgoda RODO";
            this.cbRODO.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbRODO);
            this.Controls.Add(this.txtReapetPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.BZarejestruj);
            this.Controls.Add(this.LPowtorzHaslo);
            this.Controls.Add(this.lHaslo);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.lRejestracja);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRejestracja;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lHaslo;
        private System.Windows.Forms.Label LPowtorzHaslo;
        private System.Windows.Forms.Button BZarejestruj;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtReapetPassword;
        private System.Windows.Forms.CheckBox cbRODO;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

