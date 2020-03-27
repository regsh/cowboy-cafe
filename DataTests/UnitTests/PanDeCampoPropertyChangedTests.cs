/*
 * PanDeCampoPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/26/20
 * Purpose: to test PanDeCampo' implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoImplementsINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Medium;
            });
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Large;
            });
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Name", () =>
            {
                pan.Size = Size.Medium;
            });
            Assert.PropertyChanged(pan, "Name", () =>
            {
                pan.Size = Size.Large;
            });
            Assert.PropertyChanged(pan, "Name", () =>
            {
                pan.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = Size.Medium;
            });
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = Size.Large;
            });
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = Size.Medium;
            });
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = Size.Large;
            });
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = Size.Small;
            });
        }
    }
}



