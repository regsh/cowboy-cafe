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

        public TransactionControl(Order o)
        {
            InitializeComponent();
            PaymentOptionsControl.CreditTransactionCompleted += PaymentOptionsControl_CreditTransactionCompleted;
            PaymentOptionsControl.PayByCash += PaymentOptionsControl_PayByCash;
            DataContext = o;
            TaxTxtBk.Text = Tax.ToString("C");
            TotalTxtBk.Text = Total.ToString("C");
        }

        private void PaymentOptionsControl_PayByCash(object sender, EventArgs e)
        {
            ReceiveCashControl receiveCash = new ReceiveCashControl();
            receiveCash.CashAdded += ReceiveCash_CashAdded;
            PaymentMethodBorder.Child = receiveCash;
        }

        private void ReceiveCash_CashAdded(object sender, CashEventArgs e)
        {
            ReturnChangeControl returnChange = new ReturnChangeControl(e.Change, e.CashDrawer);
            returnChange.CashTransactionCompleted += ReturnChange_CashTransactionCompleted;
            PaymentMethodBorder.Child = returnChange;
        }

        private void ReturnChange_CashTransactionCompleted(object sender, EventArgs e)
        {
            PrintReceipt("Cash");
        }

        private void PaymentOptionsControl_CreditTransactionCompleted(object sender, EventArgs e)
        {
            PrintReceipt("Credit Card");
        }

        public void PrintReceipt(string paymentMethod)
        {
            ReceiptPrinter printer = new ReceiptPrinter();
            printer.Print(TransactionToString(paymentMethod));
            MessageBox.Show("Receipt is printing.");
        }

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
