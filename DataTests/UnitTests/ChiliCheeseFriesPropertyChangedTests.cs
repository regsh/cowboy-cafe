/*
 * ChiliCheeseFriesPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/26/20
 * Purpose: to test ChiliCheeseFries' implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Medium;
            });
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Large;
            });
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Name", () =>
            {
                fries.Size = Size.Medium;
            });
            Assert.PropertyChanged(fries, "Name", () =>
            {
                fries.Size = Size.Large;
            });
            Assert.PropertyChanged(fries, "Name", () =>
            {
                fries.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Medium;
            });
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Large;
            });
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Medium;
            });
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Large;
            });
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Small;
            });
        }
    }
}

