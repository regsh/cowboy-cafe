﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Trailburger entree
    /// </summary>
    class Trailburger
    {
        private bool ketchup = true;
        /// <summary>
        /// Include ketchup with the entree
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; 
            }
            set { value = ketchup; }
        }
        private bool mustard = true;
        /// <summary>
        /// Include mustard with the entree
        /// </summary>
        public bool Mustard
        {
            get { return mustard; 
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
            get { return cheese; 
            }
            set { cheese = value; }
        }

        /// <summary>
        /// Price of the trailburger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// Caloric content of the trailburger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }
        /// <summary>
        /// Contains special instructions for the construction of the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
