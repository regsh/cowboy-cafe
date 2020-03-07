/*
 * IOrderItem.cs
 * Author: Regan Hale
 * Purpose: Interface to to allow for a collection of items ordered at the CowboyCafe
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    //Iterface to allow for a collection of menu items with similar functionality
    public interface IOrderItem
    {
        //Interfaces cannot have fields, but Properties are acceptable
        List<string> SpecialInstructions { get; }

        double Price { get; }
        
        /// <summary>
        /// Property to hold the name of the item, added so side and drink displays update with size changes
        /// </summary>
        string Name { get; }
    }
}
