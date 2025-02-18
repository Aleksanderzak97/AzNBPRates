using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzNBPRates.Models
{
    public class CurrencyRateModel : INotifyPropertyChanged
    {
        private string _currency;
        private string _code;
        private decimal _mid;

        public string Currency
        {
            get => _currency;
            set
            {
                _currency = value;
                OnPropertyChanged(nameof(Currency));
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }

        public decimal Mid
        {
            get => _mid;
            set
            {
                _mid = value;
                OnPropertyChanged(nameof(Mid));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
