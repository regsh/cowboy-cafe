/*
 * CornDodgersPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/26/20
 * Purpose: to test CornDodgers' implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Medium;
            });
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Large;
            });
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Name", () =>
            {
                dodgers.Size = Size.Medium;
            });
            Assert.PropertyChanged(dodgers, "Name", () =>
            {
                dodgers.Size = Size.Large;
            });
            Assert.PropertyChanged(dodgers, "Name", () =>
            {
                dodgers.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Medium;
            });
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Large;
            });
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Medium;
            });
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Large;
            });
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Small;
            });
        }
    }
}


