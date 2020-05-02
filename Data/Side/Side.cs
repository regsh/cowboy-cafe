/*
 * Size.cs
 * Author:Nathan Bean
 * Edited by: Regan Hale
 * Purpose: Size base class from which sides at cowboy cafe are derived
 */

using System;
using System.Collections.Generic;

using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side:IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing variable for Size property
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the size of the side
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

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the name of the item for display in the order summary
        /// </summary>
        public abstract string Name { get; }

        public bool SmallAvailable { get; set; } = true;

        public bool MediumAvailable { get; set; } = true;

        public bool LargeAvailable { get; set; } = true;

        public bool InStock { get => (SmallAvailable || MediumAvailable || LargeAvailable); }

        //can i just make this null and do a null check later?
        //no sides have special instructions
        public List<string> SpecialInstructions { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
