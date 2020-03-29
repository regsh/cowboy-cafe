/*
 * TexasTeaPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: March 28,2020
 * Purpose: to test TexasTea's implementation of INotifyPropertyChanged interface
 */

using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }


        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Large;
            });
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Name", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Name", () =>
            {
                tea.Size = Size.Large;
            });
            Assert.PropertyChanged(tea, "Name", () =>
            {
                tea.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large;
            });
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSweetInvokesPropertyChangedOnCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingLemonInvokesPropertyChangedOnLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }
        [Fact]
        public void ChangingLemonInvokesPropertyChangedOnSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }
        [Fact]
        public void ChangingIceInvokesPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });

        }
        [Fact]
        public void ChangingIceInvokesPropertyChangedOnSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }

        [Fact]
        public void ChangingSweetInvokesPropertyChangedOnSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSweetInvokesPropertyChangedOnName()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Name", () =>
            {
                tea.Sweet = false;
            });
        }
    }
}
