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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
            User admin = new User("admin", "admin"); // testowy użytkownik który zawsze się pojawia przy starcie programu żeby
            User.AddUserToList(admin);               // zaprezentować funkcje szukania użytkownika w oknie Logowanie
        }

        private void BZarejestruj_Click(object sender, EventArgs e) //przy kliknięciu guzika odpala sprawdzanie
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) //brak nazwy
            {
                MessageBox.Show("Podaj nazwe użytkownika."); 
            }
            else if(SprawdzCzyIstnieje(txtUsername.Text)) //taki użytkownik już jest - w tym wypadku 'admin'
            {
                MessageBox.Show("Taki użytkownik już istnieje.");
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text)) //puste haslo
            {
                MessageBox.Show("Hasło nie może być puste.");
            }
            else if (string.IsNullOrWhiteSpace(txtReapetPassword.Text) || !(txtPassword.Text == txtReapetPassword.Text)) //hasla sie nie zgadzaja
            {
                MessageBox.Show("Hasła nie są takie same.");
            }
            else if (!cbRODO.Checked) //nie kliknieto checkboxa
            {
                MessageBox.Show("Musisz zaakceptować klauzulę RODO.");
            }
            else
            {
                //tworzy użytkownika z podanych wcześniej danych i przesyła dane do listy żeby zapisać je dla okna Logowanie
                User user = new User(txtUsername.Text, txtPassword.Text);
                User.AddUserToList(user);
                MessageBox.Show("Pomyślnie zarejestrowano. Możesz się teraz zalogować.");
                //otwiera okno Logowanie i chowa okno Rejestracja
                Login oknoLogowania = new Login();
                oknoLogowania.Show();
                this.Hide();
            }
        }

        static bool SprawdzCzyIstnieje(string a) // funkcja pomocna do sprawdzenia czy taki użytkownik już istnieje
        {
            if (User.UserList.Exists(x => x.Username == a) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
