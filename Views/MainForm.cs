using AzNBPRates.Models;
using AzNBPRates.Views;

namespace AzNBPRates
{
    public partial class MainForm : Form, IRateView
    {
        public event EventHandler GetCurrentRatesClicked;
        public event EventHandler GetArchivedRatesClicked;

        public string YearInput => textBoxYear.Text;

        public string SelectedMonth => comboBoxMonth.SelectedItem?.ToString() ?? "";

        public MainForm()
        {
            InitializeComponent();
            InitializeMonthComboBox();
        }

        private void InitializeMonthComboBox()
        {
            comboBoxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i.ToString());
            }
            if (comboBoxMonth.Items.Count > 0)
                comboBoxMonth.SelectedIndex = 0;
        }

        private void buttonCurrentRates_Click(object sender, EventArgs e)
        {
            GetCurrentRatesClicked?.Invoke(this, EventArgs.Empty);
        }

        private void buttonArchivedRates_Click(object sender, EventArgs e)
        {
            GetArchivedRatesClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetRates(List<CurrencyRateModel> rates)
        {
            dataGridViewRates.AutoGenerateColumns = false;
            dataGridViewRates.Columns.Clear();

            var colCurrency = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Currency",  
                HeaderText = "Waluta"          
            };
            dataGridViewRates.Columns.Add(colCurrency);

            var colCode = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "Kod"
            };
            dataGridViewRates.Columns.Add(colCode);

            var colMid = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mid",
                HeaderText = "Kurs œr."
            };
            dataGridViewRates.Columns.Add(colMid);

            dataGridViewRates.DataSource = rates;
        }
    }
}
