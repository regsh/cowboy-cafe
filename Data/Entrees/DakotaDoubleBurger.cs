/*
 * DakotaDoubleBurger.cs
 * Author: Regan Hale
 * Purpose: to represent the DakotaDoubleBurger at the cowboy cafe
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Dakota Double Burger
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// Entree includes a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Bun");
            }
        }
        private bool ketchup = true;
        /// <summary>
        /// Include ketchup with the entree
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Ketchup");
            }
        }
        private bool mustard = true;
        /// <summary>
        /// Include mustard with the entree
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Mustard");
            }
        }
        private bool pickle = true;
        /// <summary>
        /// Include a pickle with the entree
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Pickle");
            }
        }
        private bool cheese = true;
        /// <summary>
        /// Cheese included with the entree
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Cheese");
            }
        }
        private bool tomato = true;
        /// <summary>
        /// Tomato included with the entree
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Tomato");
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// Lettuce included with the entree
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Lettuce");
            }
        }
        private bool mayo = true;
        /// <summary>
        /// Mayo included with the entree
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Mayo");
            }
        }



        /// <summary>
        /// The price of the double burger
        /// </summary>
        public override double Price
        {
            get { return 5.20; }
        }
        /// <summary>
        /// The caloric content of the double burger
        /// </summary>
        public override uint Calories
        {
            get => 464;
        }
        /// <summary>
        /// Contains special instructions for the construction of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }

        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name => ToString();

        /// <summary>
        /// Returns the name of the entree in a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
