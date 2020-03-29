/*
 * DrinkPropertyChangedTests.cs
 * Author:Regan Hale
 * Date: 3/29/20
 * Purpose: to test the Drink base class's implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class DrinkPropertyChangedTests
    {
        public class MockDrinkItem : Drink
        {
            public override double Price { get; } = 1.00;
            public override List<string> SpecialInstructions { get;} = new List<string>();

            public override uint Calories { get; } = 100;

            public override string Name { get; } = "Mock Item";

        }

        [Fact]
        public void DrinkImplementsINotifyPropertyChanged()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }
        [Fact]
        public void ChangingSizeInvokesPropetyChangedOnSize()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.PropertyChanged(drink, "Size", () => drink.Size = Size.Medium);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.PropertyChanged(drink, "Price", () => drink.Size = Size.Medium);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.PropertyChanged(drink, "Calories", () => drink.Size = Size.Medium);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.PropertyChanged(drink, "Calories", () => drink.Size = Size.Medium);
        }
        [Fact]
        public void ChangingIceInvokesPropertyChangedOnIce()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.PropertyChanged(drink, "Ice", () => drink.Ice = false);
        }

        [Fact]
        public void ChangingIceInvokesPropertyChangedOnSpecialInstructions()
        {
            MockDrinkItem drink = new MockDrinkItem();
            Assert.PropertyChanged(drink, "SpecialInstructions", () => drink.Ice = false);
        }
    }
}
