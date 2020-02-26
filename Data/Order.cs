using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        public double Subtotal => 0;

        public List<IOrderItem> Items => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged; //this is the only "requirement" to implement INotifyPropertyChanged BUT, *SHOULD*** invoke when any properties are changed

        public void Add(IOrderItem item)
        {
            
        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
