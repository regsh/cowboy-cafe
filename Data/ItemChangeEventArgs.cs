using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace CowboyCafe.Data
{
    public class ItemChangeEventArgs : NotifyCollectionChangedEventArgs
    {
        public string PropertyChanged;
        
        public ItemChangeEventArgs(string changed) : base(NotifyCollectionChangedAction.Reset)
        {
            this.PropertyChanged = changed;
        }
        
    }
}
