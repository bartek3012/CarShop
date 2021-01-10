using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShop.Repositories;

namespace CarShop.UserControls
{
    public partial class LoginUserControl : UserControl
    {
        private UsersRepository usersRepository = new UsersRepository();
        /// <summary>
        /// Zmienna dostępy pokazująca czy użytkownik zalogował się poprawnie
        /// </summary>
        public bool IsLogged { get; private set; }
        /// <summary>
        /// UserControl do logowania użytkowników
        /// </summary>
        public LoginUserControl()
        {
            InitializeComponent();
            IsLogged = false;
        }
        /// <summary>
        /// Zwrócenie Id zalogowanego użytkownika
        /// </summary>
        /// <returns></returns>
        internal int GetId()
        {
            return usersRepository.LoggedId;
        }

        /// <summary>
        /// Sprawdzenie poprawności danych logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if(usersRepository.Login(login, password) == true) //jeśli udało się zalogować
            {
                IsLogged = true; //ustawieni zmiennej dostępu do programu
                this.Hide(); //schowanie UserControl z logowaniem
            }
        }
    }
}
