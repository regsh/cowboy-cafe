/*Trailburger.cs
 * Author:Regan Hale
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Trailburger entree
    /// </summary>
    public class Trailburger: Entree
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
            set { bun = value; }
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
            set { ketchup = value; }
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
            set { mustard = value; }
        }
        private bool pickle = true;
        /// <summary>
        /// Include a pickle with the entree
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
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
            set { cheese = value; }
        }

        /// <summary>
        /// Price of the trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// Caloric content of the trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
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
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }
    }
}
