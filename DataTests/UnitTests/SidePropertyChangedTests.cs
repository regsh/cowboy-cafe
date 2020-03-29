/*
 * SidePropertyChangedTests.cs
 * Author:Regan Hale
 * Date: March 29,2020
 * Purpose: to test the Side base class's implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class SidePropertyChangedTests
    {
        public class MockSideItem : Side
        {
            public override double Price { get; } = 0.50;

            public override uint Calories { get; } = 25;

            public override string Name { get;} = "Mock Side";
        }

        [Fact]
        public void SideImplementsINotifyPropertyChanged()
        {
            MockSideItem side = new MockSideItem();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }

        [Fact]
        public void ChangingSizeInvokesPropetyChangedOnSize()
        {
            MockSideItem side = new MockSideItem();
            Assert.PropertyChanged(side, "Size", () => side.Size = Size.Medium);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            MockSideItem side = new MockSideItem();
            Assert.PropertyChanged(side, "Price", () => side.Size = Size.Medium);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            MockSideItem side = new MockSideItem();
            Assert.PropertyChanged(side, "Calories", () => side.Size = Size.Medium);
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            MockSideItem side = new MockSideItem();
            Assert.PropertyChanged(side, "Calories", () => side.Size = Size.Medium);
        }
    }
}
