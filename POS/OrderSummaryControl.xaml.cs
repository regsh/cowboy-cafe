/*
 * OrderSummaryControl.xaml.cs
 * Author:Regan Hale
 * Purpose: To provide a means of viewing the current order in the POS inteface
 */

using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void NewItemSelected(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem selectedItem = ((sender as ListBox).SelectedItem as IOrderItem);
            ShowCustomization(selectedItem);  
        }

        private void DeleteItem(object sender, RoutedEventArgs e)
        {
           if (sender is Button b)
            {
                if(b.DataContext is IOrderItem item)
                {
                    try
                    {
                        Order currentOrder = (Order)this.DataContext;
                        currentOrder.Remove(item);
                    }
                    catch
                    {
                        throw new System.Exception();
                    }
                }
            }
            ReplaceScreen();
        }

        private void ReplaceScreen()
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.CustomizationContainer.Child = new MenuItemSelectionControl();
        }

        private void ShowCustomization(IOrderItem item)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            UserControl screen = null;

            if(item is Entree e)
            {
                switch (e)
                {
                    case AngryChicken ac:
                        screen = new AngryChickenCustomization(ac);
                        break;
                    case CowpokeChili cc:
                        screen = new CowpokeChiliCustomization();
                        screen.DataContext = cc;
                        break;
                    case DakotaDoubleBurger ddb:
                        screen = new DakotaDoubleBurgerCustomization();
                        break;
                    case PecosPulledPork ppp:
                        screen = new PecosPulledPorkCustomization();
                        break;
                    case RustlersRibs rr:
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
            }
            else if(item is Side side)
            {
                screen = new CustomizationScreens.SizeControl(side);
            }
            else if(item is Drink drink)
            {
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
            }

            if (screen != null)
            {
                screen.DataContext = item;
                orderControl.CustomizationContainer.Child = screen;
            }
        }
    }
}
