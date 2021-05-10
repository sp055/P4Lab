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
            foreach (var user in User.UserList) 
            {
                //jesli wszystko sie zgadza
                if (user.Username == txtUsername.Text & user.Password == txtPassword.Text)
                {
                    MessageBox.Show("Zalogowano.");
                }

                //jesli jest uzytkownik ale nie zgadza sie haslo
                else if (user.Username == txtUsername.Text & !(user.Password == txtPassword.Text))
                {
                    MessageBox.Show("Błędne hasło.");
                }

                //jesli nie ma uzytkownika
                else 
                {
                    MessageBox.Show("Nie znaleziono użytkownika");
                }
            }
        }
    }
}
