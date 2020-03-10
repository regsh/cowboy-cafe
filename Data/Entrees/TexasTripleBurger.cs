/*TexasTripleBurger.cs
<<<<<<< HEAD
 * Regan Hale
=======
 * Author:Regan Hale
 * Purpose: represent the texas triple burger entree at cowboy cafe
>>>>>>> f61996ff76cfd58387cf23a011f75139de2191c2
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Texas Triple Burger
    /// </summary>
    public class TexasTripleBurger : Entree
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
            set { bun = value;
                NotifyPropertyChanged("SpecialInstructions");
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
            set { ketchup = value;
                NotifyPropertyChanged("SpecialInstructions");
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
            set { mustard = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        private bool pickle = true;
        /// <summary>
        /// Include a pickle with the entree
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                NotifyPropertyChanged("SpecialInstructions");
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
            set { cheese = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        private bool tomato = true;
        /// <summary>
        /// Tomato included with the entree
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value;
                NotifyPropertyChanged("SpecialInstructions");
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
            set { lettuce = value;
                NotifyPropertyChanged("SpecialInstructions");
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
            set { mayo = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        private bool bacon = true;
        /// <summary>
        /// Bacon included in the entree
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        private bool egg = true;
        public bool Egg
        {
            get { return egg; }
            set { egg = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// The price of the double burger
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }
        /// <summary>
        /// The caloric content of the double burger
        /// </summary>
        public override uint Calories
        {
            get => 698;
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
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }

        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name => ToString();

        /// <summary>
        /// Returns name of the entree in a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
