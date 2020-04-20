/*
 * TransactionControl.xaml.cs
 * Author: Regan Hale
 * Purpose: Code-behind for control to handle finalizing a payment transaction for an order at the Cowboy Cafe
 */

using CashRegister;
using CowboyCafe.Data;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// The tax owed for the order
        /// Assumes tax of 16%
        /// </summary>
        public double Tax
        {
            get
            {
                if (DataContext is Order myOrder)
                {
                    double tax = myOrder.Subtotal * 0.16;
                    return Math.Round(tax, 2);
                }
                else return 0;
            }
        }
        /// <summary>
        /// The order total, including tax
        /// </summary>
        public double Total
        {
            get
            {
                if (DataContext is Order myOrder)
                {
                    return myOrder.Subtotal + this.Tax;
                }
                else return 0;
            }
        }

        public TransactionControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initializes a TransactionControl for provided order
        /// </summary>
        /// <param name="o">The order being processed</param>
        public TransactionControl(Order o)
        {
            InitializeComponent();
            PaymentOptionsControl.CreditTransactionCompleted += PaymentOptionsControl_CreditTransactionCompleted;
            PaymentOptionsControl.PayByCash += PaymentOptionsControl_PayByCash;
            DataContext = o;
            TaxTxtBk.Text = Tax.ToString("C");
            TotalTxtBk.Text = Total.ToString("C");
        }
        /// <summary>
        /// Handles click on pay by cash option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentOptionsControl_PayByCash(object sender, EventArgs e)
        {
            ReceiveCashControl receiveCash = new ReceiveCashControl();
            receiveCash.CashAdded += ReceiveCash_CashAdded;
            PaymentMethodBorder.Child = receiveCash;
        }
        /// <summary>
        /// Processes cash received from a ReceiveCashControl and displays a new ReturnChangeControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiveCash_CashAdded(object sender, CashEventArgs e)
        {
            ReturnChangeControl returnChange = new ReturnChangeControl(e.Change, e.CashDrawer);
            returnChange.CashTransactionCompleted += ReturnChange_CashTransactionCompleted;
            PaymentMethodBorder.Child = returnChange;
        }
        /// <summary>
        /// Handles the completion of a cash transaction by printing a receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnChange_CashTransactionCompleted(object sender, EventArgs e)
        {
            PrintReceipt("Cash");
        }
        /// <summary>
        /// Handles completion of a credit card purchase and prints a receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentOptionsControl_CreditTransactionCompleted(object sender, EventArgs e)
        {
            PrintReceipt("Credit Card");
        }
        /// <summary>
        /// Prints a receipt according to the payment method passed
        /// </summary>
        /// <param name="paymentMethod">payment method as a string for display on the receipt</param>
        public void PrintReceipt(string paymentMethod)
        {
            ReceiptPrinter printer = new ReceiptPrinter();
            printer.Print(TransactionToString(paymentMethod));
            MessageBox.Show("Receipt is printing.");
        }
        /// <summary>
        /// Converts the information from a transaction to the appropriate format for the receipt printer
        /// </summary>
        /// <param name="transactionType">Type of transaction as a string: Cash or Credit</param>
        /// <returns></returns>
        public string TransactionToString(string transactionType)
        {
            string result = "";
            string newLine = Environment.NewLine;
            if (DataContext is Order myOrder)
            {
                result += newLine;
                result += (myOrder.ToString() + newLine);
                result += $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}{newLine}";
                foreach (IOrderItem item in myOrder.Items)
                {
                    result += $"{item.Name} {item.Price.ToString("C")}{newLine}";
                    if (item.SpecialInstructions != null)
                    {
                        foreach (string s in item.SpecialInstructions)
                        {
                            result += $" - {s}{newLine}";
                        }
                    }
                }
                result += $"Subtotal {myOrder.Subtotal.ToString("C")}{newLine}";
                result += $"Tax {Tax.ToString("C")}{newLine}";
                result += $"Total {Total.ToString("C")}{newLine}";
                result += $"Payment by {transactionType}";
            }
            return result;
        }
    }
}
