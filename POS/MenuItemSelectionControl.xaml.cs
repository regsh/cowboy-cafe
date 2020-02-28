/*
 * MenuItemSelectionControl.xaml.cs
 * Author:Regan Hale
 * Purpose: Defines behavior of the point-of-sale program for the Cowboy Cafe
 */

using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }
        
        //CLICK EVENT HANDLERS FOR ENTREES

        private void AngryChickenOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if(DataContext is Order myOrder)
            {
                myOrder.Add(new AngryChicken());
            }
        }


        private void CowpokeChiliOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new CowpokeChili());
            }
        }


        private void DakotaDoubleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new DakotaDoubleBurger());
            }
        }

        private void PecosPulledPorkOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new PecosPulledPork());
            }
        }

        private void RustlersRibsOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new RustlersRibs());
            }
        }

        private void TexasTripleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new TexasTripleBurger());
            }
        }

        private void TrailBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new Trailburger());
            }
        }

        //CLICK EVENT HANDLERS FOR SIDES
        
        private void BakedBeansOrderBtn_Click(object sender, RoutedEventArgs e)
        {
           // OrderListView.Items.Add(new BakedBeans());
        }

        private void ChiliCheeseFriesOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new ChiliCheeseFries());
        }

        private void CornDodgersOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CornDodgers());
        }

        private void PanDeCampoOrderBtn_Click(object sender, RoutedEventArgs e)
        {
           // OrderListView.Items.Add(new PanDeCampo());
        }

        //CLICK EVENT HANDLERS FOR DRINKS

        private void CowboyCoffeeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
           // OrderListView.Items.Add(new CowboyCoffee());
        }

        private void JerkedSodaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new JerkedSoda());
        }

        private void TexasTeaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTea());
        }

        private void WaterOrderBtn_Click(object sender, RoutedEventArgs e)
        {
          //  OrderListView.Items.Add(new Water());
        }
        
    }
}
