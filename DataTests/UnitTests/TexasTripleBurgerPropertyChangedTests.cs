/*
 * TexasTripleBurgerPropertyChangedTests.cs
 * Author:Regan Hale
 * Date: 3/26/20
 * Purpose: to test TexasTripleBurger's implementation of INotifyPropertyChanged
 */

using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var burger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }
        [Fact]
        public void ChangingBunInvokesPropertyChangedOnBun()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }
        [Fact]
        public void ChangingBunInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupInvokesPropertyChangedOnKetchup()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingKetchupInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardInvokesPropertyChangedOnMustard()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }
        [Fact]
        public void ChangingMustardInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedOnPickle()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Pickle = false;
            });
        }
        [Fact]
        public void ChangingCheeseInvokesPropertyChangedOnCheese()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }
        [Fact]
        public void ChangingCheeseInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }
        [Fact]
        public void ChangingTomatoInvokesPropertyChangedOnTomato()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = false;
            });
        }
        [Fact]
        public void ChangingTomatoInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Tomato = false;
            });
        }
        [Fact]
        public void ChangingLettuceInvokesPropertyChangedOnLettuce()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingLettuceInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingMayoInvokesPropertyChangedOnMayo()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = false;
            });
        }
        [Fact]
        public void ChangingMayoInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mayo = false;
            });
        }
        [Fact]
        public void ChangingEggInvokesPropertyChangedOnMayo()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Egg", () =>
            {
                burger.Egg = false;
            });
        }
        [Fact]
        public void ChangingEggInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Egg = false;
            });
        }
        [Fact]
        public void ChangingBaconInvokesPropertyChangedOnMayo()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Bacon", () =>
            {
                burger.Bacon = false;
            });
        }
        [Fact]
        public void ChangingBaconInvokesPropertyChangedOnSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bacon = false;
            });
        }
    }

}


