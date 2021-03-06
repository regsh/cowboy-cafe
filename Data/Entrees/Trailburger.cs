﻿/*
 * TrailBurger.cs
 * Author:Regan Hale
 * Purpose: represent the Trailburger entree at cowboy cafe
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Trailburger entree
    /// </summary>
    public class Trailburger : Entree
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
        /// Caloric content of the TrailBurger
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
        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name => ToString();


        /// <summary>
        /// Returns the name of the entree as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
