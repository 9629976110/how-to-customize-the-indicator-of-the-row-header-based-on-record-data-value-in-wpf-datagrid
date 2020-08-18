﻿using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SfDataGridDemo
{
    public class Model : NotificationObject
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        bool dataChanged;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; RaisePropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; RaisePropertyChanged("CustomerID"); }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; RaisePropertyChanged("CustomerName"); }
        }

        public string Country
        {
            get { return country; }
            set { country = value; RaisePropertyChanged("Country"); }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; RaisePropertyChanged("ShipCity"); }
        }

        public bool DataChanged
        {
            get { return dataChanged; }
            set { dataChanged = value; RaisePropertyChanged("DataChanged"); }
        }
    }
}
