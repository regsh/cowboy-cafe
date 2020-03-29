/*
 * WaterPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: March 28,2020
 * Purpose: to test Water's implementation of INotifyPropertyChanged
 */

using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Medium;
            });
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Large;
            });
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Name", () =>
            {
                water.Size = Size.Medium;
            });
            Assert.PropertyChanged(water, "Name", () =>
            {
                water.Size = Size.Large;
            });
            Assert.PropertyChanged(water, "Name", () =>
            {
                water.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingLemonInvokesPropertyChangedOnLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });
        }
        [Fact]
        public void ChangingLemonInvokesPropertyChangedOnSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }
        [Fact]
        public void ChangingIceInvokesPropertyChangedOnIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });

        }
        [Fact]
        public void ChangingIceInvokesPropertyChangedOnSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }


    }
}

