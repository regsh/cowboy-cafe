using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        private static uint lastOrderNumber;

        public uint OrderNumber { get; }

        public double Subtotal { get; private set; }

        public ObservableCollection<IOrderItem> Items { get; } = new ObservableCollection<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged; //this is the only "requirement" to implement INotifyPropertyChanged BUT, *SHOULD*** invoke when any properties are changed

        public Order()
        {
            //DOES THIS INCREMENT lastOrderNumber?
            OrderNumber = lastOrderNumber++;
        }

        public void Add(IOrderItem item)
        {
            Items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); //still don't really understand why there is a null ref. exception when no listener
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove(IOrderItem item)
        {
            Items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }


    }
}
