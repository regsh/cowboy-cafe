/*
 * MenuItemSelectionControl.xaml.cs
 * Author:Regan Hale
 * Purpose: Defines behavior of the point-of-sale program for the Cowboy Cafe
 */

using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;
using PointOfSale.ExtensionMethods;
using PointOfSale.CustomizationScreens;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    { 
    
       // OrderControl orderControl;

        public MenuItemSelectionControl()
        {
            InitializeComponent();
            //orderControl = this.FindAncestor<OrderControl>();
            
        }
        


        //CLICK EVENT HANDLERS FOR ENTREES

        private void AngryChickenOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if(DataContext is Order myOrder)
            {
               //Window selectSize = new SizeSelection();
               // selectSize.Show();

                myOrder.Add(new AngryChicken());
                
                
            }
        }


        private void CowpokeChiliOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                //Finds the OrderControl that contains the MenuItemSelectionControl by recursive call that compares parent type to OrderControl
                var orderControl = this.FindAncestor<OrderControl>();

                //Creates new customization screen for the cowpoke chili
                var screen = new CustomizationScreens.CowpokeChiliCustomization();
                
                //Creates new instance of CowpokeChili to add to order and to set as the data context for screen
                var item = new CowpokeChili();
                screen.DataContext = item;
                myOrder.Add(item);
                
                //Displays the customization screen
                orderControl.SwapScreen(screen);
            }
        }


        private void DakotaDoubleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                //Finds the OrderControl that contains the MenuItemSelectionControl by recursive call that compares parent type to OrderControl
                var orderControl = this.FindAncestor<OrderControl>();

                //Creates new customization screen for the cowpoke chili
                var screen = new CustomizationScreens.DakotaDoubleBurgerCustomization();

                //Creates new instance of CowpokeChili to add to order and to set as the data context for screen
                var item = new DakotaDoubleBurger();
                screen.DataContext = item;
                myOrder.Add(item);

                //Displays the customization screen
                orderControl.SwapScreen(screen);
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
            if (DataContext is Order myOrder)
            {
                //Finds the OrderControl that contains the MenuItemSelectionControl by recursive call that compares parent type to OrderControl
                var orderControl = this.FindAncestor<OrderControl>();

                //Creates new customization screen for the cowpoke chili
                var screen = new CustomizationScreens.SizeControl();

                //Creates new instance of CowpokeChili to add to order and to set as the data context for the cust. screen
                var item = new BakedBeans();
                screen.DataContext = item;
                myOrder.Add(item);

                //Displays the customization screen
                orderControl.SwapScreen(screen);

            }
        }

        private void ChiliCheeseFriesOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new ChiliCheeseFries());
            }
        }

        private void CornDodgersOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new CornDodgers());
            }
        }

        private void PanDeCampoOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new PanDeCampo());
            }
        }

        //CLICK EVENT HANDLERS FOR DRINKS

        private void CowboyCoffeeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new CowboyCoffee()) ;
            }
        }

        private void JerkedSodaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new JerkedSoda());
            }
        }

        private void TexasTeaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new TexasTea());
            }
        }

        private void WaterOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order myOrder)
            {
                myOrder.Add(new Water());
            }
        }
        
    }
}
