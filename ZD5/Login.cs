using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosed +=
               new System.Windows.Forms.FormClosedEventHandler(this.LoginWindowClosed);
            // dzięki temu po kliknięciu X w okonie Logowania aplikacja się zamknie a nie będzie wisiała w pamięci
        }

        private void LoginWindowClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //dalsza część
        }

        private void bZaloguj_Click(object sender, EventArgs e) // przy kliknięciu sprawdza podane dane z już istniejącymi
        {
            //wszystko sie zgadza
            if (User.UserList.Any(k => k.Username == txtUsername.Text & k.Password == txtPassword.Text))
            {
                MessageBox.Show("Zalogowano.");
                Application.Exit();
            }
            //jesli jest uzytkownik ale nie zgadza sie haslo
            else if (User.UserList.Any(k => k.Username == txtUsername.Text & !(k.Password == txtPassword.Text)))
            {
                MessageBox.Show("Błędne hasło.");
            }
            else
            {
                MessageBox.Show("Nie znaleziono użytkownika.");
            }
        }
    }
}
