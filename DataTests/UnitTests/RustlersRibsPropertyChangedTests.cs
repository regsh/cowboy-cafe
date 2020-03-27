/*
 * RustlersRibsPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/26/20
 * Purpose: to test RustlersRibs' implementation of INotifyPropertyChanged
 */

using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class RustlersRibsPropertyChangedTests
    {
        [Fact]
        public void RustlersRibsImplementsINotifyPropertyChanged()
        {
            var ribs = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ribs);
        }
    }
}
