/*
 * Water.cs
 * Author:Regan Hale
 * Public class to represent an order of Water at the Cowboy Cafe
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent an order of water
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {


        /// <summary>
        /// Price of the water
        /// </summary>
        public override double Price => 0.12;

        /// <summary>
        /// Caloric content of the water
        /// </summary>
        public override uint Calories => 0;

        private bool lemon = false;
        /// <summary>
        /// If the water is served with a lemon
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
        /// Special instructions for preparing an order of water
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
        public override string Name => ToString();

        /// <summary>
        /// Returns a description of the drink with size as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }

    }
}
