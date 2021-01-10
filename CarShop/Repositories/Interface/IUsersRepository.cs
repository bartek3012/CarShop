using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Repositories.Interface
{
    public interface IUsersRepository
    {
        /// <summary>
        /// Przechowywanie Id zalogowanego użytkownika
        /// </summary>
        int LoggedId { get;}
        /// <summary>
        /// Sprawdzanie poprawności logowania
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        /// <returns></returns>
        bool Login(string login, string password);
    }
}
