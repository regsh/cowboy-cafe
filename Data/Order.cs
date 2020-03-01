/*
 * Order.cs
 * Author: Regan Hale
 * Purpose: Class to provide a class for binding to the UI, which contains information about a single customer order
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent a customer order
    /// </summary>
    public class Order:INotifyPropertyChanged
    {
        private static uint lastOrderNumber;

        /// <summary>
        /// Number associated with the given order
        /// </summary>
        public uint OrderNumber { get; }

        /// <summary>
        /// Current subtotal of Items included in the order
        /// </summary>
        public double Subtotal { get; private set; }

        /// <summary>
        /// IOrderItems added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Triggered when Subtotal or Items changes (OrderNumber should not change)
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged; //this is the only "requirement" to implement INotifyPropertyChanged BUT, *SHOULD*** invoke when any properties are changed

        /// <summary>
        /// Order constructor, creates consecutive order numbers for sequential orders
        /// </summary>
        public Order()
        {
            OrderNumber = ++lastOrderNumber;
        }
        /// <summary>
        /// Adds an IOrderItem to the order collection
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            Items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); //still don't really understand why there is a null ref. exception when no listener
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// Removes an IOrderItem from the collection of order items
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            Items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// Converts the order to a string containing the order number
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Order {OrderNumber}";
        }


    }
}
