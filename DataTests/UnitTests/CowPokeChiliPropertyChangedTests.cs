/*
 * CowpokeChiliPropertyChangedTests.cs
 * Author:Regan Hale
 * Date: 3/26/20
 * Purpose: To test CowpokeChili's implementation of INotifyPropertyChanged
 */

using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class CowPokeChiliPropertyChangedTests
    {
        [Fact]
        public void CowpokeChiliImplementsINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }
        [Fact]
        public void ChangingCheeseInvokesPropertyChangedOnCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseInvokesPropertyChangedOnSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }

        [Fact]
        public void ChangingSourCreamInvokesPropertyChangedOnSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        [Fact]
        public void ChangingSourCreamInvokesPropertyChangedOnSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        [Fact]
        public void ChangingGreenOnionsInvokesPropertyChangedOnGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        [Fact]
        public void ChangingGreenOnionsInvokesPropertyChangedOnSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        [Fact]
        public void ChangingTortillaStripsInvokesPropertyChangedOnTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }
        [Fact]
        public void ChangingTortillaStripsInvokesPropertyChangedOnSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
