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
            User admin = new User("admin", "admin");
            User.AddUserToList(admin);
        }

        private void BZarejestruj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Podaj nazwe użytkownika.");
            }
            else if(SprawdzCzyIstnieje(txtUsername.Text))
            {
                MessageBox.Show("Taki użytkownik już istnieje.");
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Hasło nie może być puste.");
            }
            else if (string.IsNullOrWhiteSpace(txtReapetPassword.Text) || !(txtPassword.Text == txtReapetPassword.Text))
            {
                MessageBox.Show("Hasła nie są takie same.");
            }
            else if (!cbRODO.Checked)
            {
                MessageBox.Show("Musisz zaakceptować klauzulę RODO.");
            }
            else
            {
                MessageBox.Show("Pomyślnie zarejestrowano. Możesz się teraz zalogować.");
                User user = new User(txtUsername.Text, txtPassword.Text);
                User.AddUserToList(user);

                Login oknoLogowania = new Login();
                oknoLogowania.Show();
                this.Hide();
            }
        }

        static bool SprawdzCzyIstnieje(string a)
        {
            bool sprawdz;
            foreach (var user in User.UserList)
            {
                if (a == user.Username)
                {
                    sprawdz = true;
                    return sprawdz;
                }
            }
            return sprawdz = false;
        }
    }
}
