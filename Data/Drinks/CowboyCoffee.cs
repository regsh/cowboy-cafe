/*
 * CowboyCoffee.cs
 * Author: Regan Hale
 * Purpose: Class to represent a Cowboy Coffee order at the Cowboy Cafe
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents a cowboy coffee order at the cowboy cafe
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private bool decaf = false;
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Name");
            }
        }
        private bool roomForCream = false;
        /// <summary>
        /// Whether room should be left for cream when preparing order
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool ice = false;
        /// <summary>
        /// Whether the coffee is served with ice
        /// </summary>
        public override bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 0.60;
                    case (Size.Medium): return 1.10;
                    case (Size.Large): return 1.60;
                    default: throw new ArgumentException();
                }
            }
        }
        /// <summary>
        /// The caloric content of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 3;
                    case (Size.Medium): return 5;
                    case (Size.Large): return 7;
                    default: throw new ArgumentException();
                }
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                //should it show decaf in special instructions? redundant because also reflected in the name
                if (Decaf) instructions.Add("Decaf");
                return instructions;
            }
        }
        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name => ToString();

        public override string ToString()
        {
            string result = Size.ToString();
            if (Decaf) result += " Decaf";
            result += " Cowboy Coffee";
            return result;
        }
    }
}
