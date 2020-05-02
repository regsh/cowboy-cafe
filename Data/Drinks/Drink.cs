/*
 * Drink.cs
 * Author:Regan Hale
 * Purpose: Base class for foundation of drink orders at the cowboy cafe
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    ///Abstract class to represent a generic drink at the Cowboy Cafe
    /// </summary>
    public abstract class Drink:IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing variable for Size property
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size
        {
            get => size;

            set
            {
                size = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public bool SmallAvailable { get; set; } = true;

        public bool MediumAvailable { get; set; } = true;

        public bool LargeAvailable { get; set; } = true;

        public bool InStock { get => (SmallAvailable || MediumAvailable || LargeAvailable); }

        /// <summary>
        /// Represents the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Represents the caloric content of the drink
        /// </summary>
        public abstract uint Calories { get; }

        private bool ice = true;
        /// <summary>
        /// Whether the given drink contains ice
        /// </summary>
        public virtual bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Special instructions for preparing the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// Name of the drink as displayed in the OrderSummaryControl
        /// </summary>
        public abstract string Name { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        //Taken from: https://stackoverflow.com/questions/23577311/how-to-implement-inotifypropertychanged-for-derived-classes
        /// <summary>
        /// Method to invoke Drink base class PropertyChanged event handler in derived classes
        /// Take from StackOverflow post#23577311
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
