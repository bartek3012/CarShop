using CarShop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop.Forms
{
    public partial class FormCredit : Form
    {
        private int priceValue;
        private CreditRepository creditRepository = new CreditRepository();
        public FormCredit(int price)
        {
            InitializeComponent();
            textBoxAmount.Text = price.ToString();
            priceValue = price;
        }
        private void FormCredit_Load(object sender, EventArgs e)
        {
            DataTable dataTable = creditRepository.GetCredits();
            if(dataTable!=null)
            {
                dataGridViewCredits.DataSource = dataTable;
            }


            dataGridViewCredits.Columns["Id"].Visible = false;
            dataGridViewCredits.Columns["Percent"].HeaderText = "Oprocentowanie";
            dataGridViewCredits.Columns["Amont"].HeaderText = "Cena";
            dataGridViewCredits.Columns["YearsRepayment"].HeaderText = "Lata spłaty";
            dataGridViewCredits.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dataGridViewCredits.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewCredits.EnableHeadersVisualStyles = false;
        }
        private void buttonTakeCredit_Click(object sender, EventArgs e)
        {
            string bank, yearsString;
            try
            {
            bank = comboBoxBank.SelectedItem.ToString();
            yearsString = comboBoxYears.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano wartości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(priceValue == 0)
            {
                MessageBox.Show("Błąd ceny, wybierz kredyt n inne auto", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int years = Int32.Parse(yearsString);
            creditRepository.AddCredit(FormOtomoto.IdUser, bank, years, priceValue);
            dataGridViewCredits.DataSource = creditRepository.GetCredits();
        }


    }
}
