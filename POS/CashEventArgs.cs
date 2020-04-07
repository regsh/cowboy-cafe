using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PointOfSale
{
    public class CashEventArgs: RoutedEventArgs
    {
        public double Change { get; set; }

        public CashRegister.CashDrawer CashDrawer { get; set; }
        public CashEventArgs(double changeOwed, CashRegister.CashDrawer drawer)
        {
            Change = changeOwed;
            CashDrawer = drawer;
        }
    }
}
