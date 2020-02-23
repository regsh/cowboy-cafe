/*
 * OrderControl.xaml.cs
 * Author:Regan Hale
 * Purpose: Defines behavior of the point-of-sale program for the Cowboy Cafe
 */

using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            
        }
        
        //CLICK EVENT HANDLERS FOR ENTREES

        private void AngryChickenOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }


        private void CowpokeChiliOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }


        private void DakotaDoubleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        private void PecosPulledPorkOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        private void RustlersRibsOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        private void TexasTripleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        private void TrailBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Trailburger());
        }

        //CLICK EVENT HANDLERS FOR SIDES

        private void BakedBeansOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        private void ChiliCheeseFriesOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        private void CornDodgersOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        private void PanDeCampoOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        //CLICK EVENT HANDLERS FOR DRINKS

        private void CowboyCoffeeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        private void JerkedSodaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        private void TexasTeaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        private void WaterOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}
