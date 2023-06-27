using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_exam
{
    public class FinancialChanges : InOutCl
    {
        public string MonthName { get; set; } = "";

        private int finances;

        //private int jan, feb, march, apr, may, june, july, aug, sept, oct, nov, dec;

        public event PropertyChangedEventHandler? PropertyChanged;

        
        

        public int Finances
        {
            get
            {
                /*
                if (Date.Year == 2022)
                {
                    if (Date.Month == 1)
                    {
                        return finances += MoneyChange;
                    }
                    else
                   if (Date.Month == 2)
                    {
                        return finances += MoneyChange;
                    }
                    if (Date.Month == 3)
                    {
                        return finances += MoneyChange;
                    }
                    else
                  if (Date.Month == 4)
                    {
                        return finances += MoneyChange;
                    }
                    if (Date.Month == 5)
                    {
                        return finances += MoneyChange;
                    }
                    else
                  if (Date.Month == 6)
                    {
                        return finances += MoneyChange;
                    }
                    if (Date.Month == 7)
                    {
                        return finances += MoneyChange;
                    }
                    else
                  if (Date.Month == 8)
                    {
                        return finances += MoneyChange;
                    }
                    if (Date.Month == 9)
                    {
                        return finances += MoneyChange;
                    }
                    else
                  if (Date.Month == 10)
                    {
                        return finances += MoneyChange;
                    }
                    if (Date.Month == 11)
                    {
                        return finances += MoneyChange;
                    }
                    else
                  if (Date.Month == 12)
                    {
                        return finances += MoneyChange;
                    }
                    
                }*/
                return finances += MoneyChange;
            }
            set
            {
                finances = value;
            }
        }


    }
}
