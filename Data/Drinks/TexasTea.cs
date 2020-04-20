/*
 * TexasTea.cs
 * Author:Regan Hale
 * Class to represent the Texas Tea drink at the Cowboy Cafe
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order of TexasTea
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// Whether the tea has added sweetener
        /// </summary>
        public bool Sweet
        {
            get => sweet;
            set
            {
                sweet = value;
                NotifyPropertyChanged("Sweet");
                NotifyPropertyChanged("Name");
                NotifyPropertyChanged("Calories");
            
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the tea is served with a lemon
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                NotifyPropertyChanged("Lemon");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 1.00;
                    case (Size.Medium): return 1.50;
                    case (Size.Large): return 2.00;
                    default: throw new ArgumentException(); //should never happen, as size has a default value
                }
            }
        }
        /// <summary>
        /// Caloric content of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint kCals;
                switch (Size)
                {
                    case (Size.Small):
                        kCals = 10;
                        break;
                    case (Size.Medium):
                        kCals = 22;
                        break;
                    case (Size.Large):
                        kCals = 36;
                        break;
                    default: throw new ArgumentException();
                }
                if (!Sweet) kCals /= 2;
                return kCals;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name
        {
            get
            {
                string result = Size.ToString() + " Texas";
                if (Sweet) result += " Sweet";
                else result += " Plain";
                result += " Tea";
                return result;
            }
        }

        /// <summary>
        /// Basic string describing the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Texas Tea";
        }


    }
}
