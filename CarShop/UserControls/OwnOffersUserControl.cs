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
    public partial class OwnOffersUserControl : UserControl
    {
        /// <summary>
        /// Obiekt klasy do obsługi bazy danych
        /// </summary>
        CarsRepository carsRepository = new CarsRepository();

        /// <summary>
        /// Zanzaczony Id
        /// </summary>
        public int selectedId { get; private set; }

        /// <summary>
        /// Informacja o schowaniu strony
        /// </summary>
        public bool IsHiden { get; set; }
        public OwnOffersUserControl()
        {
            InitializeComponent();
            IsHiden = false;
        }
        /// <summary>
        /// Wypełnienie tabeli własnymi aukcjami i ustawienie wyglądu tabeli
        /// </summary>
        public void SetDataGrid()
        {
            dataGridViewOwnOffers.DataSource = carsRepository.GetYoursCars();// Wypełnienie tabeli własnymi aukcjami

            // Ustawienie wyglądu tabeli (nazwy kolumn i kolory tła nagłówków)
            dataGridViewOwnOffers.Columns["Price"].HeaderText = "Cena";
            dataGridViewOwnOffers.Columns["Brand"].HeaderText = "Marka";
            dataGridViewOwnOffers.Columns["Type"].HeaderText = "Typ";
            dataGridViewOwnOffers.Columns["Type"].Width = 80;
            dataGridViewOwnOffers.Columns["YearOfProduction"].HeaderText = "Rok produkcji";
            dataGridViewOwnOffers.Columns["YearOfProduction"].Width = 80;
            dataGridViewOwnOffers.Columns["Id"].Width = 40;
            dataGridViewOwnOffers.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dataGridViewOwnOffers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewOwnOffers.EnableHeadersVisualStyles = false;
        }
        /// <summary>
        /// Jeśli zmiana jest widoczność ekrany, następuje aktualizacja tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OwnOffersUserControl_VisibleChanged(object sender, EventArgs e)
        {
            carsRepository.GetYoursCars();
        }
        /// <summary>
        /// Zmiana ceny samochodu na własnej aukcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPriceChange_Click(object sender, EventArgs e)
        {
            //Jeśli podana cena nie jest liczbą następuje przerwanie funkcji
            int price;
            if (Int32.TryParse(textBoxPirceChange.Text, out price) == false)
            {
                MessageBox.Show("Niepoprawna liczba", "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //W przeciwnym razie cena zostaje zmieniona i nasępuje aktualizacja tabeli
            carsRepository.ChangePrice(selectedId, price);
            dataGridViewOwnOffers.DataSource = carsRepository.GetYoursCars();
        }
        /// <summary>
        /// Zdarzenie zmiany zanzaczenrgo rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOwnOffers_SelectionChanged(object sender, EventArgs e)
        {
            //Brak działania jeśli żaden lub wszytskie wiersze są zaznaczone zakończ funckję
            int rowsCount = dataGridViewOwnOffers.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;
            try
            {
            //pobranie pierwszego zaznaczonego wiersza
            DataGridViewRow row = dataGridViewOwnOffers.SelectedRows[0];
            selectedId = Int32.Parse(row.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
            }

        }
        /// <summary>
        /// Przycisk dodania oferty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddOffer_Click(object sender, EventArgs e)
        {
            //Pobranie marki i typu z comboboxó
            string brand = comboBoxBrand.SelectedItem.ToString();
            string type = comboBoxType.Text;
            if (brand == "" || type == "")
            {
                MessageBox.Show("Nie uzupełniono wszytskich pól", "Uzupełnij pola", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Sprawdzenie poprwnosci roku i ceny (czy liczba z poprawnego przedziału)
            int price, year;
            if (Int32.TryParse(textBoxPriceSet.Text, out price) == false || Int32.TryParse(textBoxYear.Text, out year) == false)
            {
                MessageBox.Show("Nie podano poprawnie liczby", "Uzupełnij pola", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (price <= 0 || year <= 1800)
            {
                MessageBox.Show("Nie podano poprawnie liczby", "Uzupełnij pola", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Zapisanie wyników z checkboxów w postaci tabeli intów z zakresu (0,1) co umożliwi zastosowanie odpowiedniego zapytania sql
            int[] equipmentValue = new int[] { Convert.ToInt32(checkBoxABS.Checked), Convert.ToInt32(checkBoxASR.Checked), Convert.ToInt32(checkBoxAirCondition.Checked), Convert.ToInt32(checkBoxGPS.Checked), Convert.ToInt32(checkBoxParkingSensor.Checked),
                Convert.ToInt32(checkBoxRainSensor.Checked) };
            
            //Wywołanie mateod dodania aukcji i aktualizacja tabeli
            carsRepository.AddCar(year, brand, equipmentValue, type, price);
            dataGridViewOwnOffers.DataSource = carsRepository.GetYoursCars();
        }
        /// <summary>
        /// Przecisk do usunięcia zanaczonej aukcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            carsRepository.DeleteCar(selectedId);
            dataGridViewOwnOffers.DataSource = carsRepository.GetYoursCars();
        }
        /// <summary>
        /// Przycisk powrotu do wszytskich akucji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            IsHiden = true; //Ustawienie zmienej mówiącej o schowaniu strony na true
            this.Visible = false; //Schowanie strony
        }
    }
}
