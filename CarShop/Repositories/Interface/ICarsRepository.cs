using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Repositories.Interface
{
    interface ICarsRepository
    {
        /// <summary>
        /// Pobranie wszytskicj samochodów z tabeli
        /// </summary>
        /// <returns></returns>
        DataTable GetCars();

        /// <summary>
        /// Pobranie wszytskich samochodów użytkownika
        /// </summary>
        /// <returns></returns>
        DataTable GetYoursCars();
        /// <summary>
        /// Dodanie nowego samochodu do tebeli
        /// </summary>
        /// <param name="year">Rok produkcji</param>
        /// <param name="brand">Nazwa marki</param>
        /// <param name="equipmentId">Wyposażenie</param>
        /// <param name="type">Typ</param>
        /// <param name="userId">Id użytkownika</param>
        /// <param name="price">Cena</param>
        void AddCar(int year, string brand, int []equipments, string type, int price);

        /// <summary>
        /// Usunięcie auta z bazy
        /// </summary>
        /// <param name="carId">Id samochodu do usunięcia</param>
        void DeleteCar(int carId);



    }
}
