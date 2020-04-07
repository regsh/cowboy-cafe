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

        public void CreditCardPaymentBtn_Clicked(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            double total = ((TransactionControl)ExtensionMethods.ExtensionMethods.FindAncestor<TransactionControl>(this)).Total;
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

        public void CashPaymentBtn_Clicked(object sender, RoutedEventArgs e)
        {
            PayByCash?.Invoke(this, new RoutedEventArgs());
        }
    }
}
