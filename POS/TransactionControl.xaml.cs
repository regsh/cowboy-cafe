using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CashRegister;

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
                    return myOrder.Subtotal * 0.16;
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
            DataContext = o;
            TaxTxtBk.Text = Tax.ToString("C");
            TotalTxtBk.Text = Total.ToString("C");

        }

        public void CreditCardPaymentBtn_Clicked(object sender, RoutedEventArgs e) 
        {
            CardTerminal terminal = new CardTerminal();
            switch (terminal.ProcessTransaction(Total))
            {
                case ResultCode.Success:
                    PrintReceipt();
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

        public void CashPaymentBtn_Clicked(object sender, RoutedEventArgs e)
        {

        }

        public void PrintReceipt()
        {
            MessageBox.Show("Receipt is printing.");
        }
    }
}
