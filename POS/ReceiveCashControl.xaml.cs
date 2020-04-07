using CashRegister;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ReceiveCashControl.xaml
    /// </summary>
    public partial class ReceiveCashControl : UserControl, INotifyPropertyChanged
    {
        public event EventHandler<CashEventArgs> CashAdded;
        public double CashReceived { get; set; }

        public double OrderTotal
        {
            get
            {
                return (ExtensionMethods.ExtensionMethods.FindAncestor<TransactionControl>(this)).Total;
            }
        }

        private int ones = 0;
        public int Ones
        {
            get => ones;
            set
            {
                CashReceived += (value - ones) * 1;
                ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }

        private int twos = 0;
        public int Twos
        {
            get => twos;
            set
            {
                CashReceived += (value - twos) * 2;
                twos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int fives = 0;
        public int Fives
        {
            get => fives;
            set
            {
                CashReceived += (value - fives) * 5;
                fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }

        private int tens = 0;
        public int Tens
        {
            get => tens;
            set
            {
                CashReceived += (value - tens) * 10;
                tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int twenties = 0;
        public int Twenties
        {
            get => twenties;
            set
            {
                CashReceived += (value - twenties) * 20;
                twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int fifties = 0;
        public int Fifties
        {
            get => fifties;
            set
            {
                CashReceived += (value - fifties) * 50;
                fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int hundreds = 0;
        public int Hundreds
        {
            get => hundreds;
            set
            {
                CashReceived += (value - hundreds) * 100;
                hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }

        private int pennies = 0;
        public int Pennies
        {
            get => pennies;
            set
            {
                CashReceived += (value - pennies) * .01;
                pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int nickels = 0;
        public int Nickels
        {
            get => nickels;
            set
            {
                CashReceived += (value - nickels) * 0.05;
                nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int dimes = 0;
        public int Dimes
        {
            get => dimes;
            set
            {
                CashReceived += (value - dimes) * .1;
                dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int quarters = 0;
        public int Quarters
        {
            get => quarters;
            set
            {
                CashReceived += (value - quarters) * .25;
                quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }

        private int halfDollars = 0;
        public int HalfDollars
        {
            get => halfDollars;
            set
            {
                CashReceived += (value - halfDollars) * .5;
                halfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }
        private int dollars = 0;
        public int Dollars
        {
            get => dollars;
            set
            {
                CashReceived += (value - dollars) * 1;
                dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CashReceived"));
            }
        }

        public ReceiveCashControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnCurrencyClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                switch (b.Name)
                {
                    case "OneBtn":
                        Ones++;
                        break;
                    case "TwoBtn":
                        Twos++;
                        break;
                    case "FiveBtn":
                        Fives++;
                        break;
                    case "TenBtn":
                        Tens++;
                        break;
                    case "TwentyBtn":
                        Twenties++;
                        break;
                    case "FiftyBtn":
                        Fifties++;
                        break;
                    case "HundredBtn":
                        Hundreds++;
                        break;
                    case "PennyBtn":
                        Pennies++;
                        break;
                    case "NickelBtn":
                        Nickels++;
                        break;
                    case "DimeBtn":
                        Dimes++;
                        break;
                    case "QuarterBtn":
                        Quarters++;
                        break;
                    case "HalfDollarBtn":
                        HalfDollars++;
                        break;
                    case "DollarBtn":
                        Dollars++;
                        break;
                    default: break;
                }
            }
        }

        public void AddToDrawerClicked(object sender, RoutedEventArgs e)
        {
            if (OrderTotal > CashReceived)
            {
                MessageBox.Show("Insufficient cash received");
            }
            else if (ExtensionMethods.ExtensionMethods.FindAncestor<OrderControl>(this) is OrderControl orderControl)
            {
                CashDrawer drawer = orderControl.CashDrawer;
                drawer.AddBill(Bills.One, Ones);
                drawer.AddBill(Bills.Two, Twos);
                drawer.AddBill(Bills.Five, Fives);
                drawer.AddBill(Bills.Ten, Tens);
                drawer.AddBill(Bills.Twenty, Twenties);
                drawer.AddBill(Bills.Fifty, Fifties);
                drawer.AddBill(Bills.Hundred, Hundreds);
                drawer.AddCoin(Coins.Penny, Pennies);
                drawer.AddCoin(Coins.Nickel, Nickels);
                drawer.AddCoin(Coins.Dime, Dimes);
                drawer.AddCoin(Coins.Quarter, Quarters);
                drawer.AddCoin(Coins.HalfDollar, HalfDollars);
                drawer.AddCoin(Coins.Dollar, Dollars);
                CashAdded?.Invoke(this, new CashEventArgs(CashReceived - OrderTotal, drawer));
            }
        }


    }
}
