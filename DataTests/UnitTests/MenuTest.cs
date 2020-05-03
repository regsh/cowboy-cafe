/*
 * MenuTest.cs
 * Author: Regan Hale
 */

using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(Trailburger))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(ChiliCheeseFries))]
        public void CompleteMenuShouldContainAllMenuItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Fact]
        public void CompleteMenuShouldContainExactlyFifteenItems()
        {
            Assert.Equal(15, Menu.CompleteMenu().Count());
        }

        [Theory]
        [InlineData(typeof(Trailburger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        public void SearchForBurgerContainsAllBurgerItems(Type type)
        {
            IEnumerable<IOrderItem> items = Menu.CompleteMenu();
            Menu.CompleteSearch(items, "burger");
            var types = new List<Type>();
            foreach(IOrderItem item in items)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        [Fact]
        public void SearchForBurgerYieldsThreeItems()
        {
            var result = Menu.CompleteSearch(Menu.CompleteMenu(), "burger");
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void SearchForCowReturnsTwoItems()
        {
            var result = Menu.CompleteSearch(Menu.CompleteMenu(), "cow");
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void SearchIsNotCaseSensitive()
        {
            var resultOne = Menu.CompleteSearch(Menu.CompleteMenu(), "te");
            var resultTwo = Menu.CompleteSearch(Menu.CompleteMenu(), "TE");

            Assert.Equal(resultOne.Count(), resultTwo.Count());
        }

        [Fact]
        public void CalorieFilterWithNoValuesReturnsCompleteMenu()
        {
            Assert.Equal(Menu.CompleteMenu().Count(), Menu.FilterByCalories(Menu.CompleteMenu(), null, null).Count());
        }

        [Fact] 
        public void PriceFilterWithNoValuesReturnsCompleteMenu()
        {
            Assert.Equal(Menu.CompleteMenu().Count(), Menu.FilterByPrice(Menu.CompleteMenu(), null, null).Count());
        }

        
    }
}
