/*
 * CowboyCoffeePropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/28/20
 * Purpose: to test CowboyCoffee's implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowbowCoffeeImplementsINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }


        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Large;
            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Name", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Name", () =>
            {
                coffee.Size = Size.Large;
            });
            Assert.PropertyChanged(coffee, "Name", () =>
            {
                coffee.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Large;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Large;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingCreamInvokesPropertyChangedOnCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        [Fact]
        public void ChangingCreamInvokesPropertyChangedOnSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
                {
                    coffee.RoomForCream = true;
                });
        }
        [Fact]
        public void ChangingIceInvokesPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });

        }
        [Fact]
        public void ChangingIceInvokesPropertyChangedOnSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }

        [Fact]
        public void ChangingDecafInvokesPropertyChangedOnDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });
        }
        [Fact]
        public void ChangingDecafInvokesPropertyChangedOnSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
                {
                    coffee.Decaf = true;
                });
        }

        [Fact]
        public void ChangingDecafInvokesPropertyChangedOnName()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Name", () =>
            {
                coffee.Decaf = true;
            });
        }
    }
}
