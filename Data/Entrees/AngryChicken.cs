/*
 * AngryChicken.cs
 * Author:Regan Hale
 * Class: AngryChicken
 * Purpose: represent the Angry Chicken entree at cowboy cafe
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {


        private bool bread = true;
        /// <summary>
        /// Include bread with the entree
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
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
            set
            {
                pickle = value;
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the Angry Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// The calorie content of the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
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
                //instructions.Add("Sample instructions");

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
        /// Changes the default behavior of ToString() to give the title of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
