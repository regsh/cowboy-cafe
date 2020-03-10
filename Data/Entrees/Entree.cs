/*Entree.cs
 * Author: Regan Hale
 * Purpose: Base class from which entrees at the cowboy cafe are derived
 * 2/5/2020
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class to represent an entree menu item at the cowboy cafe
    /// </summary>
    public abstract class Entree: IOrderItem
    {
        /// <summary>
        /// Gets the price of an entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the caloric content of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Holds instructions for the creation of an entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the entree for display in the order summary
        /// </summary>
        public abstract string Name { get; }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        //Taken from: https://stackoverflow.com/questions/23577311/how-to-implement-inotifypropertychanged-for-derived-classes
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
