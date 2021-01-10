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
using CarShop.Forms;

namespace CarShop.UserControls
{
    public partial class OffersUserControl : UserControl
    {
        /// <summary>
        /// Zawiera informacją czy UserControl został schowany
        /// </summary>
        public bool IsHide { get; private set; }
        /// <summary>
        /// Zmienna zawierajaca cene zaznaczonego rzędu
        /// </summary>
        private float price;
        /// <summary>
        /// Obiekt kalasy do komunikacji z bazą danych
        /// </summary>
        private CarsRepository carsRepository = new CarsRepository();
        public OffersUserControl()
        {
            InitializeComponent();
        } 
        /// <summary>
        /// Metoda wywołaywana po inicjalizacji strony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OffersUserControl_Load(object sender, EventArgs e)
        {
            IsHide = false; //zmienna określająca czy okno zostało schowane ustawiona na false
            dataGridViewOffers.DataSource = carsRepository.GetCars(); //Wpisanie ofert do tabeli

            //Zaminy nazw kolumn i koloru tła nagłówków tabeli
            dataGridViewOffers.Columns["Price"].HeaderText = "Cena";
            dataGridViewOffers.Columns["Brand"].HeaderText = "Marka";
            dataGridViewOffers.Columns["Type"].HeaderText = "Typ";
            dataGridViewOffers.Columns["Type"].Width = 80;
            dataGridViewOffers.Columns["YearOfProduction"].HeaderText = "Rok produkcji";
            dataGridViewOffers.Columns["YearOfProduction"].Width = 80;
            dataGridViewOffers.Columns["FirstName"].HeaderText = "Imie właściciela";
            dataGridViewOffers.Columns["LastName"].HeaderText = "Nazwisko właściciela";
            dataGridViewOffers.Columns["Id"].Width = 40;

            dataGridViewOffers.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridViewOffers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewOffers.EnableHeadersVisualStyles = false;
        }
        /// <summary>
        /// Aktualizacja danych w dataDidzie
        /// </summary>
        public void RefreshDataGrid()
        {
            dataGridViewOffers.DataSource = carsRepository.GetCars();
        }
        /// <summary>
        /// Metoda wywoływana przy przełączeniu wybranego rekordu w DataGridzie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOffers_SelectionChanged(object sender, EventArgs e)
        {
            //Brak działania jeśli żaden lub wszytskie wiersze są zaznaczone zakończ funckję
            int rowsCount = dataGridViewOffers.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;
            try
            {
            //pobranie pierwszego zaznaczonego wiersza i wpisanie danych do etykiet
            DataGridViewRow row = dataGridViewOffers.SelectedRows[0];
            price = float.Parse(row.Cells[1].Value.ToString());
            labelPrice.Text = Math.Round(price, 2).ToString(); //Etykieta ceny
            labelBrand.Text = row.Cells[2].Value.ToString(); //Etykieta marki
            labelType.Text = row.Cells[3].Value.ToString(); //Etykieta typu
            labelYear.Text = row.Cells[4].Value.ToString(); //Etykieta z rokiem produkcji
            labelFirstName.Text = row.Cells[5].Value.ToString(); //Etykieta z imieniem właściciela
            labelLastName.Text = row.Cells[6].Value.ToString(); //Etykieta z nazwiskiem właściciela
            labelEquipment.Text = carsRepository.GetEquipment(Int32.Parse(row.Cells[0].Value.ToString())); //Etykieta z wyposażeniem
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Przełączenia UserControl na wyświetlenie własnych ofert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOwnOffers_Click(object sender, EventArgs e)
        {
            IsHide = true; //Ustawienie zmiennej przechowującej informację o ukryciu UserControl
            this.Hide(); //Schowanie UserControl
        }
        /// <summary>
        /// Stwirzenie i wyswietlenie okna do obsługi kredytów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCredit_Click(object sender, EventArgs e)
        {
            FormCredit formCredit = new FormCredit(Convert.ToInt32(price));
            formCredit.Show();
        }
    }
}
