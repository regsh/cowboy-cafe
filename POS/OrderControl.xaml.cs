/*
 * OrderControl.xaml.cs
 * Author: Regan Hale
 * Purpose: To contain user controls associated with manipulating and displaying a customer order at the cowboy cafe
 */
using CowboyCafe.Data;
using System;
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

            this.DataContext = new Order();
        }

        public void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.DataContext = new Order();
        }

        public void CompleteOrderBtn_Click(object sender, EventArgs e)
        {
            this.DataContext = new Order();

        }
    }
}
