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
            CustomizeEntree(new AngryChicken());
        }


        private void CowpokeChiliOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeEntree(new CowpokeChili());
            /*
            if (DataContext is Order myOrder)
            {

                
                CustomizeEntree(new CowpokeChili());
                
                var orderControl = this.FindAncestor<OrderControl>();

                
                var screen = new CustomizationScreens.CowpokeChiliCustomization();
                
                //Creates new instance of CowpokeChili to add to order and to set as the data context for screen
                var item = new CowpokeChili();
                screen.DataContext = item;
                myOrder.Add(item);
                
                //Displays the customization screen
                orderControl.SwapScreen(screen);
            }
            */
        }
        /// <summary>
        /// Method to customize the entree items on cowboy cafe menu
        /// Selects appropriate customization screen and displays options according to entree ordered
        /// </summary>
        /// <param name="entree">Instance of the entree to be customized</param>
        private void CustomizeEntree(Entree entree)
        {
            if (DataContext is Order myOrder)
            {
                //Finds the OrderControl that contains the MenuItemSelectionControl by recursive call that compares parent type to OrderControl
                var orderControl = this.FindAncestor<OrderControl>();

                //Creates variable to hold the customization screen determined by the switch
                UserControl screen = null;

                switch (entree)
                {
                    case AngryChicken ac:
                        screen = new AngryChickenCustomization();
                        break;
                    case CowpokeChili cc:
                        screen = new CowpokeChiliCustomization();
                        break;
                    case DakotaDoubleBurger ddb:
                        screen = new DakotaDoubleBurgerCustomization();
                        break;
                    case PecosPulledPork ppp:
                        screen = new PecosPulledPorkCustomization();
                        break;
                    case RustlersRibs rr:
                        screen = new RustlersRibsCustomization();
                        break;
                    case TexasTripleBurger ttb:
                        screen = new TexasTripleBurgerCustomization();
                        break;
                    case Trailburger tb:
                        screen = new TrailburgerCustomization();
                        break;
                    default:
                        break;
                        
                }
                //Adds item determined by button to the entree
                myOrder.Add(entree);

                //switches screen to correct customization screen
                if (screen != null)
                {
                    screen.DataContext = entree;
                    orderControl.SwapScreen(screen);
                }
            }
        }

        private void DakotaDoubleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeEntree(new DakotaDoubleBurger());
        }

        private void PecosPulledPorkOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeEntree(new PecosPulledPork());
        }

        private void RustlersRibsOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeEntree(new RustlersRibs());
        }

        private void TexasTripleBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeEntree(new TexasTripleBurger());
        }

        private void TrailBurgerOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeEntree(new Trailburger());
        }

        //CLICK EVENT HANDLERS FOR SIDES
        private void CustomizeSide(Side side)
        {
            if (DataContext is Order myOrder)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                SizeControl sizeControl = new SizeControl();
                myOrder.Add(side);
                sizeControl.DataContext = side;
                orderControl.SwapScreen(sizeControl);
            }
        }

        private void BakedBeansOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeSide(new BakedBeans());
        }

        private void ChiliCheeseFriesOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeSide(new ChiliCheeseFries());
        }

        private void CornDodgersOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeSide(new CornDodgers());
        }

        private void PanDeCampoOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeSide(new PanDeCampo());
        }

        //CLICK EVENT HANDLERS FOR DRINKS

        private void CustomizeDrink(Drink drink)
        {
            if (DataContext is Order myOrder)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                UserControl screen = null;
                switch (drink)
                {
                    case CowboyCoffee cc:
                        screen = new CowboyCoffeeCustomization();
                        break;
                    case JerkedSoda js:
                        screen = new JerkedSodaCustomization();
                        break;
                    case TexasTea tt:
                        screen = new TexasTeaCustomization();
                        break;
                    case Water w:
                        screen = new WaterCustomization();
                        break;
                    default:
                        break;

                }
                myOrder.Add(drink);
                if (screen != null)
                {
                    screen.DataContext = drink;
                    orderControl.SwapScreen(screen);
                }
            }
        }
        private void CowboyCoffeeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeDrink(new CowboyCoffee());
        }

        private void JerkedSodaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeDrink(new JerkedSoda());
        }

        private void TexasTeaOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeDrink(new TexasTea());
        }

        private void WaterOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomizeDrink(new Water());
        }
    }
}
