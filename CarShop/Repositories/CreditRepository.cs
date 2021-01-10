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
    
    class CreditRepository:Repository, ICreditRepository
    {

        public CreditRepository()
        {
        }
        /// <summary>
        /// Dodanie kredytu
        /// </summary>
        /// <param name="userId">Id użytkownika</param>
        /// <param name="bank">Wybrany bank</param>
        /// <param name="years">Lata spłaty</param>
        /// <param name="amount">Kwota kredytu</param>
        public void AddCredit(int userId, string bank, int years, int amount)
        {
            Connection.Open();
            //Znalezienie Id banku
            string queryGetIdBank = $"SELECT Banks.Id FROM Banks WHERE Banks.Bank = '{bank}';";
            SqlCommand commandGetBankId = new SqlCommand(queryGetIdBank, Connection);
            int bankId = (int)commandGetBankId.ExecuteScalar();

            //Znaleznienie id lat spłaty
            string queryGetYears = $"SELECT YearsOfRepayment.Id FROM YearsOfRepayment WHERE YearsOfRepayment.YearsRepayment = {years};";
            SqlCommand commandGetYearId = new SqlCommand(queryGetYears, Connection);
            int yearId = (int)commandGetYearId.ExecuteScalar();

            //Dodanie kredytu do listy
            string queryAddCredit = $"INSERT INTO Credit VALUES({bankId}, {yearId}, {amount}, {userId});";
            SqlCommand commandAdd = new SqlCommand(queryAddCredit, Connection);
            int x = commandAdd.ExecuteNonQuery();
            Connection.Close();
        }
        /// <summary>
        /// Zwrócenie kredytów zalogowanego użytkownika w postaci tableli
        /// </summary>
        /// <returns></returns>
        public DataTable GetCredits()
        {
            string quertyGetCredits = "SELECT Banks.*, Credit.Amont, YearsOfRepayment.YearsRepayment FROM Credit JOIN Banks ON Credit.BankId = Banks.Id JOIN YearsOfRepayment ON Credit.YearsOfRepaymentId = YearsOfRepayment.Id;";
            Connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quertyGetCredits, Connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            return dataTable;
        }
    }
}
