using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_exam
{
    public class InOutCl : INotifyPropertyChanged
    {
        private DateTime _date;
        private int _moneychange;
        private string _reason;


        public event PropertyChangedEventHandler? PropertyChanged;

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Date)));
            }
        }
        public int MoneyChange
        {
            get => _moneychange;
            set
            {
                _moneychange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MoneyChange)));
            }
        }
        public string Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Reason)));
            }
        }


        /* public DateTime Date
         {
             get { return _date; }
             set
             {
                 if(_date == value)
                 return;

                 _date = value;
                 OnPropertyChanged(nameof(Date));
             }
         }
         public int MoneyChange
         {
             get { return _moneychange; }
             set
             {
                 if (_moneychange == value)
                     return;

                 _moneychange = value;
                 OnPropertyChanged(nameof(MoneyChange));
             }
         }
         public string Reason
         {
             get { return _reason; }
             set
             {
                 if (_reason == value)
                     return;

                 _reason = value;
                 OnPropertyChanged(nameof(Reason));
             }
         }

         protected virtual void OnPropertyChanged(string propertyName = "")
         {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }
     }*/



    }
}

