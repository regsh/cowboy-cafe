using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.DataTests.UnitTests
{
    //Used for testing the Order class
    public class MockOrderItem : IOrderItem
    {
        public List<string> SpecialInstructions { get; set; }

        public double Price { get; set; } = 0;

        public string Name { get; set; } = "MockItem";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
