using AzNBPRates.Models;
using AzNBPRates.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzNBPRates.Presenters
{
    public class RatePresenter
    {
        private readonly IRateView _view;
        private readonly HttpClient _httpClient;

        public RatePresenter(IRateView view)
        {
            _view = view;
            _httpClient = new HttpClient();

            _view.GetCurrentRatesClicked += OnGetCurrentRatesClicked;
            _view.GetArchivedRatesClicked += OnGetArchivedRatesClicked;
        }

        private async void OnGetCurrentRatesClicked(object sender, EventArgs e)
        {
            try
            {
                string url = "http://api.nbp.pl/api/exchangerates/tables/A/?format=json";
                string json = await _httpClient.GetStringAsync(url);
                var tables = JsonConvert.DeserializeObject<List<NbpTable>>(json);
                if (tables != null && tables.Count > 0)
                {
                    _view.SetRates(tables[0].rates);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania bieżących kursów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void OnGetArchivedRatesClicked(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(_view.YearInput, out int year))
                {
                    MessageBox.Show("Nieprawidłowy rok.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(_view.SelectedMonth, out int month))
                {
                    MessageBox.Show("Nieprawidłowy miesiąc.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime date = new DateTime(year, month, 1);
                string dateStr = date.ToString("yyyy-MM-dd");

                string url = $"http://api.nbp.pl/api/exchangerates/tables/A/{dateStr}/?format=json";
                string json = await _httpClient.GetStringAsync(url);
                var tables = JsonConvert.DeserializeObject<List<NbpTable>>(json);
                if (tables != null && tables.Count > 0)
                {
                    _view.SetRates(tables[0].rates);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Błąd połączenia: " + httpEx.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania archiwalnych kursów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
