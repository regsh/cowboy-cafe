/*
 * PecosPulledPork.cs
 * Author:Regan Hale
 * Purpose: to represent the Pecos Pulled Pork entree at cowboy cafe
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        private bool bread = true;
        /// <summary>
        /// Include bread with the entree
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value;
                NotifyPropertyChanged("SpecialInstructions");
                NotifyPropertyChanged("Bread");
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
                NotifyPropertyChanged("Pickle");
            }
        }

        /// <summary>
        /// The price of the pulled pork entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// Caloric content of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

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
            return "Pecos Pulled Pork";
        }
    }
}
