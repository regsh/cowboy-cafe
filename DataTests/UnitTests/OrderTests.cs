/*
 * OrderTests.cs
 * Author:Regan Hale
 * Purpose: To test functionality of the Order class
 */

using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        //Used for testing the Order class
        public class MockOrderItem : IOrderItem
        {
            public List<string> SpecialInstructions { get; set; }

            public double Price { get; set; } = 0;

            public string Name { get; set; } = "MockItem";

            public uint Calories => 100;

            public event PropertyChangedEventHandler PropertyChanged;
        }

        [Fact] //In Xunit, a fact is a test that expects no parameters
        public void ShouldBeAbleToAddItems() //this name "ShouldBe..." is called a spec. In Xunit it becomes a function name
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }
        
        [Fact]
        public void ShouldBeAbleToGetAnEnumerationOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,   //requires that the items are expected to be in the order, rather than them all just existing in the collection
                item => Assert.Equal(item0, item), //first parameter is expected, second is the one comparing
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));

        }
        [Theory] //Xunit for tests that take parameters
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0,0})]
        [InlineData(new double[] { 1.99, 2.99, 3.99})]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5, 10, 8.0})]
        [InlineData(new double[] { 3.134562312546542131})]
        [InlineData(new double[] { double.NaN})]

        public void SubtotalShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            var total = 0.0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });

            }
            Assert.Equal(total, order.Subtotal);


        }
        [Theory] //could theoretically add an assert for Remove, but ideally each test tests precisely one function
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory] 
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }

    }
}
