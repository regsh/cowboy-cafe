/*
 * PecosPulledPorkPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/26/20
 * Purpose: to test PecosPulledPork's implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.DataTests.UnitTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }
        [Fact]
        public void ChangingBreadInvokesPropertyChangedOnBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
             {
                 pork.Bread = false;
             });
        }
        [Fact]
        public void ChangingBreadInvokesPropertyChangedOnSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedOnPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }
        [Fact]
        public void ChangingPickleInvokesPropertyChangedOnSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }
    }
}
