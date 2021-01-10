using CarShop.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Repositories
{
    class CarsRepository : Repository, ICarsRepository
    {
        /// <summary>
        /// Usunięcie oferty z bazy wlasnych ofert samochodów 
        /// </summary>
        /// <param name="carId"></param>
        public void DeleteCar(int carId)
        {
            //Oprócz usunięcia samochodu należy usunąć również rekord z jejo wyposażeniem, w tym celu należy pobrać jego Id
            string queryFindEquipmentId = $"SELECT Cars.EquipmentId FROM Cars WHERE Cars.Id={carId};";
            Connection.Open();
            SqlCommand commandGetIdEquipment = new SqlCommand(queryFindEquipmentId, Connection);
            int equipmentId = (int)commandGetIdEquipment.ExecuteScalar();

            //Usunięcie samochodu z bazy
            string queryDeleteCar = $"DELETE FROM Cars WHERE Cars.Id={carId};";
            SqlCommand commandDeleteCar = new SqlCommand(queryDeleteCar, Connection);
            commandDeleteCar.ExecuteNonQuery();

            //Usunięcie wyposażenia samochodu, który został usunięty chwilę wcześniej
            string quertyDeleteEquipmnet = $"DELETE FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandDeleteEquipment = new SqlCommand(quertyDeleteEquipmnet, Connection);
            commandDeleteEquipment.ExecuteNonQuery();

            Connection.Close(); //Zamknięcie połączenia
        }
        /// <summary>
        /// Metoda zwracająca tabele z samochodami
        /// </summary>
        /// <returns></returns>
        public DataTable GetCars()
        {
            string queryAddCar = $"SELECT Cars.Id, Cars.Price, Brands.Brand, Types.Type, Cars.YearOfProduction, Users.FirstName, Users.LastName From Cars JOIN Brands ON Cars.BrandId = Brands.Id " +
                $"JOIN Types ON Cars.TypeId = Types.Id JOIN Users ON Cars.UserId = Users.Id;";
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(queryAddCar, Connection);
            DataTable dataTable = new DataTable(); 
            adapter.Fill(dataTable); //przepisanie pobranych danych do DataTable
            Connection.Close();
            return dataTable;
        }
        /// <summary>
        /// Motoda zwracająca (w postaci stringa) wyposażenie samochodu o podanym id
        /// </summary>
        /// <param name="IdCar">Id samochodu do pobrania wyposażenia</param>
        /// <returns></returns>
        public string GetEquipment(int IdCar)
        {
            //string zawierająca zwracaną wartość
            string equipment ="";

            //znalezienie Id wyposażenia na podstawie podanego Id samochodu
            string queryGetIdEquipment = $"SELECT Cars.EquipmentId FROM Cars WHERE Cars.Id ={IdCar};";
            Connection.Open(); //otwarcie połączenia
            SqlCommand commandGetEquipmentId = new SqlCommand(queryGetIdEquipment, Connection);
            int equipmentId = (int)commandGetEquipmentId.ExecuteScalar();

            //pobranie informacji czy w samochodzi zanjduje się ABS, jeśli tak dodanie nazwy do stringa
            string queryGetABS = $"SELECT Equipment.ABS FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandABS = new SqlCommand(queryGetABS, Connection);
            bool abs = (bool)commandABS.ExecuteScalar();
            if (abs) equipment += "ABS\n";

            //pobranie informacji czy w samochodzi zanjduje się ASR, jeśli tak dodanie nazwy do stringa
            string queryGetASR = $"SELECT Equipment.ASR FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandASR = new SqlCommand(queryGetASR, Connection);
            bool asr = (bool)commandASR.ExecuteScalar();
            if (asr) equipment += "ASR\n";

            //pobranie informacji czy w samochodzi zanjduje się klimatyzacja, jeśli tak dodanie nazwy do stringa
            string queryGetAirCondition = $"SELECT Equipment.AirConditioning FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandAirCondition = new SqlCommand(queryGetAirCondition, Connection);
            bool airCondition = (bool)commandAirCondition.ExecuteScalar();
            if (airCondition) equipment += "Klimatyzacja\n";

            //pobranie informacji czy w samochodzi zanjduje się GPS, jeśli tak dodanie nazwy do stringa
            string queryGetGPS = $"SELECT Equipment.GPS FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandGPS = new SqlCommand(queryGetGPS, Connection);
            bool gps = (bool)commandGPS.ExecuteScalar();
            if (gps) equipment += "GPS\n";

            //pobranie informacji czy w samochodzi zanjduje się czujnik parkowania, jeśli tak dodanie nazwy do stringa
            string queryGetParkingSensor = $"SELECT Equipment.ParkingSensor FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandParkingSensor = new SqlCommand(queryGetParkingSensor, Connection);
            bool parkingSensor = (bool)commandParkingSensor.ExecuteScalar();
            if (parkingSensor) equipment += "Czujnik parkowania\n";

            //pobranie informacji czy w samochodzi zanjduje się czujnik deszczu, jeśli tak dodanie nazwy do stringa
            string queryGetRainSensor = $"SELECT Equipment.RainSensor FROM Equipment WHERE Equipment.Id={equipmentId};";
            SqlCommand commandRainSensor = new SqlCommand(queryGetRainSensor, Connection);
            bool rainSensor = (bool)commandRainSensor.ExecuteScalar();
            if (rainSensor) equipment += "Czujnik deszczu\n";

            Connection.Close(); //zamknięci połączenia
            return equipment;
        }
        /// <summary>
        /// Metoda aktualizująca cene auta
        /// </summary>
        /// <param name="selectedId">Id auta do zmiany ceny</param>
        /// <param name="price">Nowa cena</param>
        internal void ChangePrice(int selectedId, int price)
        {
            string queryChangePrice = $"UPDATE Cars SET Price={price} WHERE Cars.Id={selectedId};";
            Connection.Open();
            SqlCommand commandChangePrice = new SqlCommand(queryChangePrice, Connection);
            commandChangePrice.ExecuteNonQuery();
            Connection.Close();
        }
        /// <summary>
        /// Metoda zwracajaca listę samochodów, ale tylko tych przypisanych do zalogowanego użytkownika
        /// </summary>
        /// <returns></returns>
        public DataTable GetYoursCars()
        {
            if(FormOtomoto.IdUser == 0) //jeśli żaden użytkownik nie jest zalogowany, następuje zakończenie funkcji
            {
                return null;
            }
            string queryAddCar = $"SELECT Cars.Id, Cars.Price, Brands.Brand, Types.Type, Cars.YearOfProduction FROM Cars JOIN Brands ON Cars.BrandId=Brands.Id JOIN Types ON Cars.TypeId=Types.Id WHERE Cars.UserId={FormOtomoto.IdUser};";
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(queryAddCar, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Connection.Close();
            return dataTable;
        }
        /// <summary>
        /// Dodanie nowego samochodu na sprzedaż
        /// </summary>
        /// <param name="year">Rok zakupu samochodu</param>
        /// <param name="brand">Marka samocodu</param>
        /// <param name="equipments">Wyposażenie</param>
        /// <param name="type">Type samochodu</param>
        /// <param name="price">Cena samochodu</param>
        public void AddCar(int year, string brand, int[] equipments, string type, int price)
        {
            //Dodanie do tablicy rekordu z wyposażeniem samochodu
            string addNewEquipment = $"insert into equipment values ({equipments[0]}, {equipments[1]}, {equipments[2]}, " +
                $"{equipments[3]}, {equipments[4]}, {equipments[5]});";
            Connection.Open();
            SqlCommand commandAddEquipment = new SqlCommand(addNewEquipment, Connection);
            int result = commandAddEquipment.ExecuteNonQuery();

            //Pobranie Id ostatniego elementu z tableli z wposażeniem (czyli Id rekordu wprowadzonego w tej funkcji)
            string queryLastEquipmentId = $"SELECT MAX(Id) FROM Equipment;";
            SqlCommand commandEquipmentId= new SqlCommand(queryLastEquipmentId, Connection);
            int equipmentId = (int)commandEquipmentId.ExecuteScalar();

            //Znalezienie Id dla podanej marki pojazdu
            string queryBrandId = $"SELECT Id FROM Brands WHERE Brand='{brand}';";
            SqlCommand commandBrandId = new SqlCommand(queryBrandId, Connection);
            int brandId = (int)commandBrandId.ExecuteScalar();

            //Znalezienie Id typu dla podanego
            string queryTypeId = $"SELECT Id FROM Types WHERE Type='{type}';";
            SqlCommand commandTypeId = new SqlCommand(queryTypeId, Connection);
            int typeId = (int)commandTypeId.ExecuteScalar();

            //Dodanie samochodu
            string queryAddCar = $"INSERT INTO Cars VALUES({year}, {brandId}, {equipmentId}, {typeId}, {FormOtomoto.IdUser}, {price});";
            SqlCommand commandAddCar = new SqlCommand(queryAddCar, Connection);
            int result1 = commandAddCar.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
