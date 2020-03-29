/*
 * JerkedSodaPropertyChangedTests.cs
 * Author:Regan Hale
 * Date: March 28,2020
 * Purpose: to test JerkedSoda's implementation of the INotifyPropertyChangedInterface
 */

using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void CowbowsodaImplementsINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }


        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Name", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Name", () =>
            {
                soda.Size = Size.Large;
            });
            Assert.PropertyChanged(soda, "Name", () =>
            {
                soda.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Large;
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large;
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingFlavorInvokesPropertyChangedOnFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            });
        }
        [Fact]
        public void ChangingFlavorInvokesPropertyChangedOnName()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Name", () =>
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            });
        }
        [Fact]
        public void ChangingIceInvokesPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });

        }
        [Fact]
        public void ChangingIceInvokesPropertyChangedOnSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }

        
    }
}

