using CashRegister;
using System;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ReturnChangeControl.xaml
    /// </summary>
    public partial class ReturnChangeControl : UserControl, INotifyPropertyChanged
    {
        public event EventHandler CashTransactionCompleted;

        public event PropertyChangedEventHandler PropertyChanged;

        private double totalOwed;
        public double TotalOwed
        {
            get => totalOwed; set
            {
                totalOwed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalOwed"));
            } }

        public double OutstandingBalance;

        private CashDrawer CashDrawer { get; set; }

        public int OnesOwed { get; set; }
        public int TwosOwed { get; set; }
        public int FivesOwed { get; set; }
        public int TensOwed { get; set; }
        public int TwentiesOwed { get; set; }
        public int FiftiesOwed { get; set; }
        public int HundredsOwed { get; set; }
        public int PenniesOwed { get; set; }
        public int NickelsOwed { get; set; }
        public int DimesOwed { get; set; }
        public int QuartersOwed { get; set; }
        public int HalfDollarsOwed { get; set; }
        public int DollarsOwed { get; set; }

        public ReturnChangeControl(double totalChangeOwed, CashDrawer drawer)
        {
            InitializeComponent();
            DataContext = this;
            CashDrawer = drawer;
            TotalOwed = totalChangeOwed;
            OutstandingBalance = TotalOwed;

            HundredsOwed = Math.Min(CalculateBillsOwed(100), drawer.Hundreds);
            OutstandingBalance -= HundredsOwed * 100;

            FiftiesOwed = Math.Min(CalculateBillsOwed(50), drawer.Fifties);
            OutstandingBalance -= (FiftiesOwed * 50);

            TwentiesOwed = Math.Min(CalculateBillsOwed(20), drawer.Twenties);
            OutstandingBalance -= (TwentiesOwed * 20);

            TensOwed = Math.Min(CalculateBillsOwed(10), drawer.Tens);
            OutstandingBalance -= (TensOwed * 10);

            FivesOwed = Math.Min(CalculateBillsOwed(5), drawer.Fives);
            OutstandingBalance -= (FivesOwed * 5);

            OnesOwed = Math.Min(CalculateBillsOwed(1), drawer.Ones);
            OutstandingBalance -= OnesOwed;

            DollarsOwed = Math.Min(CalculateBillsOwed(1), drawer.Dollars);
            OutstandingBalance -= DollarsOwed;

            HalfDollarsOwed = Math.Min(CalculateBillsOwed(.5), drawer.HalfDollars);
            OutstandingBalance -= (HalfDollarsOwed * 0.5);

            QuartersOwed = Math.Min(CalculateBillsOwed(0.25), drawer.Quarters);
            OutstandingBalance -= (QuartersOwed * 0.25);

            DimesOwed = Math.Min(CalculateBillsOwed(0.1), drawer.Dimes);
            OutstandingBalance -= (DimesOwed * .10);

            NickelsOwed = Math.Min(CalculateBillsOwed(0.05), drawer.Nickels);
            OutstandingBalance -= (NickelsOwed * .05);

            PenniesOwed = Math.Min(CalculateBillsOwed(0.01), drawer.Pennies);
            OutstandingBalance -= (PenniesOwed * .01);

            if (Math.Round(OutstandingBalance,2) > 0) throw new DrawerOverdrawException();
        }

        public int CalculateBillsOwed(double denominationValue)
        {
            int quantity = Convert.ToInt32(Math.Floor(OutstandingBalance / denominationValue));
            return quantity;
        }

        public void FinishClicked(object sender, RoutedEventArgs e)
        {
            GiveChange();
            CashTransactionCompleted?.Invoke(this, new RoutedEventArgs());
            OrderControl oc = ExtensionMethods.ExtensionMethods.FindAncestor<OrderControl>(this);
            oc.DataContext = new Order();
            oc.CustomizationContainer.Child = new MenuItemSelectionControl();
        }

        public void GiveChange()
        {
            CashDrawer.RemoveBill(Bills.One, OnesOwed);
            CashDrawer.RemoveBill(Bills.Five, FivesOwed);
            CashDrawer.RemoveBill(Bills.Ten, TensOwed);
            CashDrawer.RemoveBill(Bills.Twenty, TwentiesOwed);
            CashDrawer.RemoveBill(Bills.Fifty, FiftiesOwed);
            CashDrawer.RemoveBill(Bills.Hundred, HundredsOwed);

            CashDrawer.RemoveCoin(Coins.Penny, PenniesOwed);
            CashDrawer.RemoveCoin(Coins.Nickel, NickelsOwed);
            CashDrawer.RemoveCoin(Coins.Dime, DimesOwed);
            CashDrawer.RemoveCoin(Coins.Quarter, QuartersOwed);
            CashDrawer.RemoveCoin(Coins.HalfDollar, HalfDollarsOwed);
            CashDrawer.RemoveCoin(Coins.Dollar, DollarsOwed);
        }
    }
}
