/*
 * BakedBeansPropertyChangedTests.cs
 * Author: Regan Hale
 * Date: 3/26/20
 * Purpose: to test BakedBean's implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.DataTests.UnitTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Large;
            });
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnName()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Name", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Name", () =>
            {
                beans.Size = Size.Large;
            });
            Assert.PropertyChanged(beans, "Name", () =>
            {
                beans.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Large;
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeInvokesPropertyChangedOnCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Large;
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Small;
            });
        }
    }
}
