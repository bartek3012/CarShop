using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Repositories.Interface
{
    interface ICreditRepository
    {
        /// <summary>
        /// Pobranie kredytów i zwrócenie tabeli
        /// </summary>
        /// <returns></returns>
        DataTable GetCredits();

        /// <summary>
        /// Dodanie (wzięcie) kredytu do bazy
        /// </summary>
        /// <param name="userId">Id użytkownika</param>
        /// <param name="bank">Wybrany bank</param>
        /// <param name="years">Lata spłaty</param>
        /// <param name="amount">Kwota</param>
        void AddCredit(int userId, string bank, int years, int amount);
    }
}
