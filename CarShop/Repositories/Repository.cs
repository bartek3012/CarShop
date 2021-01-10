using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Repositories
{
    public abstract class Repository
    {
        /// <summary>
        /// Zmienna przechowująca połączenie z bazą danych
        /// </summary>
        protected readonly SqlConnection Connection;

        public Repository()
        {
            //Stworzenie połączenia za pomocą Connection Stringa
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
