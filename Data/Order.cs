using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order
    {
        public double Subtotal => 0;

        public List<IOrderItem> Items => throw new NotImplementedException();

        public void Add(IOrderItem item)
        {
            
        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
