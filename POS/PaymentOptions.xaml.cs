/*
 * PaymentOptions.xaml.cs
 * Author:Regan Hale
 * Purpose: Code behind for user control to select between cash and credit card payment options
 */

using System;
using System.Windows;
using System.Windows.Controls;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        public event EventHandler CreditTransactionCompleted;

        public event EventHandler PayByCash;
        
        public PaymentOptions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles click event on the Credit Card payment option button by instantiating an CardTerminal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CreditCardPaymentBtn_Clicked(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            double total = ((TransactionControl)ExtensionMethods.ExtensionMethods.FindAncestor<TransactionControl>(this)).Total;
            
            //Possible results from running total balance for order on terminal
            switch (terminal.ProcessTransaction(total))
            {
                case ResultCode.Success:
                    CreditTransactionCompleted?.Invoke(this, new RoutedEventArgs());
                    OrderControl oc = ExtensionMethods.ExtensionMethods.FindAncestor<OrderControl>(this);
                    oc.DataContext = new Order();
                    oc.CustomizationContainer.Child = new MenuItemSelectionControl();
                    break;
                case ResultCode.InsufficentFunds:
                    MessageBox.Show("Insufficient funds. Please submit another form of payment.");
                    break;
                case ResultCode.CancelledCard:
                    MessageBox.Show("Cancelled card. Please submit another form of payment.");
                    break;
                case ResultCode.ReadError:
                    MessageBox.Show("Read error. Please try again.");
                    break;
                case ResultCode.UnknownErrror:
                    MessageBox.Show("An error occurred. Please try again;");
                    break;
            }
        }
        /// <summary>
        /// Handles click event on "Cash" payment option button by invoking PayByCash event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CashPaymentBtn_Clicked(object sender, RoutedEventArgs e)
        {
            PayByCash?.Invoke(this, new RoutedEventArgs());
        }
    }
}
