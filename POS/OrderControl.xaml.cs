/*
 * OrderControl.xaml.cs
 * Author: Regan Hale
 * Purpose: To contain user controls associated with manipulating and displaying a customer order at the cowboy cafe
 */
using CowboyCafe.Data;
using System;
using System.Windows;
using System.Windows.Controls;
using CashRegister;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public CashDrawer CashDrawer { get; } = new CashDrawer();

        public Order CurrentOrder { get; set; }
        
        public OrderControl()
        {
            InitializeComponent();
            CurrentOrder = new Order();
            this.DataContext = CurrentOrder;
        }

        public void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.DataContext = new Order();
            CustomizationContainer.Child = new MenuItemSelectionControl();
        }

        public void CompleteOrderBtn_Click(object sender, EventArgs e)
        {
            CustomizationContainer.Child = new TransactionControl((Order)this.DataContext);
        }

        public void ItemSelectionBtn_Click(object sender, EventArgs e)
        {
            CustomizationContainer.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            CustomizationContainer.Child = element;
        }
    }
}
