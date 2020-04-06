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
            DataContext = o;
            TaxTxtBk.Text = Tax.ToString("C");
            TotalTxtBk.Text = Total.ToString("C");
        }

        public void PrintReceipt()
        {
            MessageBox.Show("Receipt is printing.");
        }
    }
}
