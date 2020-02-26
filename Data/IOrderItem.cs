using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        //Interfaces cannot have fields, but Properties are acceptable
        List<string> SpecialInstructions { get; }

        double Price { get; }

    }
}
