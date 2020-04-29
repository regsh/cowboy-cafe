/*
 * MenuTest.cs
 * Author: Regan Hale
 */

using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTest
    {
        [Fact]
        public void SidesShouldContainChiliCheeseFries()
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(typeof(ChiliCheeseFries), types);
        }

        [Fact]
        public void SidesShouldContainBakedBeans()
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(typeof(BakedBeans), types);
        }
        [Fact]
        public void SidesShouldContainPanDeCampo()
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(typeof(PanDeCampo), types);
        }
        [Fact]
        public void SidesShouldContainCornDodgers()
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(typeof(CornDodgers), types);
        }

        [Fact]
        public void SidesShouldContainExactlyFourItems()
        {
            Assert.Equal(4, Menu.Sides().Count());
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(Trailburger))]
        public void EntreesShouldContainAllEntreeItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Fact]
        public void EntreesShouldContainExactlySevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainAllEntreeItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Fact]
        public void DrinksShouldContainExactlyFourItems()
        {
            Assert.Equal(4, Menu.Drinks().Count());
        }



    }
}
