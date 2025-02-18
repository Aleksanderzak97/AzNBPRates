using AzNBPRates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzNBPRates.Views
{
    public interface IRateView
    {
        /// <summary>
        /// Tekst wprowadzony przez użytkownika (rok).
        /// </summary>
        string YearInput { get; }

        /// <summary>
        /// Wybrany miesiąc
        /// </summary>
        string SelectedMonth { get; }

        /// <summary>
        /// Metoda do ustawiania danych kursów w widoku (np. jako źródło danych DataGridView).
        /// </summary>
        /// <param name="rates">Lista kursów walut.</param>
        void SetRates(List<CurrencyRateModel> rates);

        event EventHandler GetCurrentRatesClicked;
        event EventHandler GetArchivedRatesClicked;
    }
}
