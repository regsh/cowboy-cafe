/*
 * OrderPropertyChangedTests.cs
 * Author:Regan Hale
 * Date: March 29,2020
 * Purpose: to test Order class's implementation of INotifyPropertyChanged
 */
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderPropertyChangedTests
    {
        [Fact]
        public void OrderImplementsINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void AddingItemsInvokesPropertyChangedOnItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Items", () => order.Add(item));
        }

        [Fact]
        public void AddingItemsInvokesPropertyChangedOnSubtotal()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Subtotal", () => order.Add(item));
        }
        [Fact]
        public void RemovingItemsInvokesPropertyChangedOnItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Items.Add(item);
            Assert.PropertyChanged(order, "Items", () => order.Remove(item));
        }

        [Fact]
        public void RemovingItemsInvokesPropertyChangedOnSubtotal()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Items.Add(item);
            Assert.PropertyChanged(order, "Subtotal", () => order.Remove(item));
        }
    }
}

