using CarShop.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop.Repositories
{
   public class UsersRepository : Repository, IUsersRepository
    {
        /// <summary>
        /// Property Id zalogowanego użytkownika
        /// </summary>
        public int LoggedId { get; private set; }

        public UsersRepository()
        {

        }
        /// <summary>
        /// Sprawdzenie poprawności logowania i w przypadku dobrych danych przejście do kolejnych funkcji programu
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string login, string password)
        {
            string queryLogin = $"SELECT Users.Id FROM Users WHERE Login='{login}' AND Password='{password}';";
            Connection.Open();
            SqlCommand sqlCommand = new SqlCommand(queryLogin, Connection);
            try
            {
            LoggedId = (int)sqlCommand.ExecuteScalar(); //jeśli zakończy się niepowodzeniem, wyświetlony zostaje okmunikat 
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane logowanie. Spróbuj ponownie.", "Błąd logowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();
                return false;
            }
            Connection.Close();
            return true; //w przypadku poprawnego logowania zwrócona jest wartość true
        }
    }
}
