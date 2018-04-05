using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamilCofeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        public int CoffeeId
        {
            get;
            set;
        }

        public string CoffeeName
        {
            get;
            set;
        }

        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }

        public string Description
        {
            get;
            set;
        }

        public Country OriginCountry
        {
            get;
            set;
        }

        public bool InStock
        {
            get;
            set;
        }

        public int AmountInStock
        {
            get;
            set;
        }

        public DateTime FirstAddedToStockDate
        {
            get;
            set;
        }

        public int ImageId
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
