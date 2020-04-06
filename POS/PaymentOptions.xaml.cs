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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {

        public PaymentOptions()
        {
            InitializeComponent();

        }


        public void CreditCardPaymentBtn_Clicked(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            double total = ((TransactionControl)ExtensionMethods.ExtensionMethods.FindAncestor<TransactionControl>(this)).Total;
            switch (terminal.ProcessTransaction(total))
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
            ((TransactionControl)ExtensionMethods.ExtensionMethods.FindAncestor<TransactionControl>(this)).PaymentMethodBorder.Child = new ReceiveCashControl();
        }

        public void PrintReceipt()
        {
            MessageBox.Show("receipt is printing;");
        }

    }
}
