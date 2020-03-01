using CowboyCafe.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            this.DataContext = new Order();
        }

        public void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.DataContext = new Order();
        }

        public void CompleteOrderBtn_Click(object sender, EventArgs e)
        {
            this.DataContext = new Order();

        }
    }
}
