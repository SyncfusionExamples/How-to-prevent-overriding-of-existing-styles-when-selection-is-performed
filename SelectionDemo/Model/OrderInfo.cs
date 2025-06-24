using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SfDataGrid_Demo_4_8
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerId;
        private string country;
        private string customerName;
        private string shippingCity;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [Display(Name = "Order ID")]
        public int OrderID
        {
            get => orderID;
            set
            {
                if (orderID != value)
                {
                    orderID = value;
                    OnPropertyChanged("OrderID");
                }
            }
        }

        [Display(Name = "Customer ID")]
        public string CustomerID
        {
            get => customerId;
            set
            {
                if (customerId != value)
                {
                    customerId = value;
                    OnPropertyChanged("CustomerID");
                }
            }
        }

        [Display(Name = "Name")]
        public string CustomerName
        {
            get => customerName;
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    OnPropertyChanged("CustomerName");
                }
            }
        }

        [Display(Name = "Country")]
        public string Country
        {
            get => country;
            set
            {
                if (country != value)
                {
                    country = value;
                    OnPropertyChanged("Country");
                }
            }
        }

        [Display(Name = "Ship City")]
        public string ShipCity
        {
            get => shippingCity;
            set
            {
                if (shippingCity != value)
                {
                    shippingCity = value;
                    OnPropertyChanged("ShipCity");
                }
            }
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
        }
    }
}
