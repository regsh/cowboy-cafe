/*
 * AngryChickenPropertyChangedTest.cs
 * Author:Regan Hale (following Nathan Bean's YouTube video)
 * Date: 3/26/20
 * Purpose: To test AngryChicken's implementation of the INotifyPropertyChanged interface
 */
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class AngryChickenPropertyChangedTests
    {
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void ChangingBreadInvokesPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () => //delegate method using lambda syntax
            {
                chicken.Bread = false; //because we know it is true by default (angrychickentests) setting it true here
                //should trigger property changed
            }
            );
        }
        [Fact]
        public void ChangingBreadInvokesPropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }
    }
}
