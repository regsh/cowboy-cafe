/*
 * TrailburgerPropertyChangedTests.cs
 * Author:Regan Hale
 * Date: 3/26/20
 * Purpose: To test Trailburger's implementation of INotifyPropertyChanged
 */

using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TrailburgerPropertyChangedTests
    {
        [Fact]
        public void TrailburgerImplementsINotifyPropertyChanged()
        {
            var burger = new Trailburger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }
        [Fact]
        public void ChangingBunInvokesPropertyChangedOnBun()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }
        [Fact]
        public void ChangingBunInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupInvokesPropertyChangedOnKetchup()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingKetchupInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardInvokesPropertyChangedOnMustard()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }
        [Fact]
        public void ChangingMustardInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedOnPickle()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Pickle = false;
            });
        }
        [Fact]
        public void ChangingCheeseInvokesPropertyChangedOnCheese()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }
        [Fact]
        public void ChangingCheeseInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new Trailburger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }
       
    }

}

