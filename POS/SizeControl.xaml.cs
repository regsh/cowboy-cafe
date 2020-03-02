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
    /// Interaction logic for SizeControl.xaml
    /// </summary>
    public partial class SizeControl : UserControl
    {
        private IOrderItem itemToCustomize;

        public SizeControl(IOrderItem item)
        {
            InitializeComponent();
            itemToCustomize = item;
        }

        void SmallBtn_Click(object sender, EventArgs e)
        {
            if(itemToCustomize is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Small;
                if(this.DataContext is Order order)
                {
                    order.Add(side);
                }
                
            }
        }

        void MediumBtn_Click(object sender, EventArgs e)
        {
            if (itemToCustomize is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Medium;
                if (this.DataContext is Order order)
                {
                    order.Add(side);
                }
            }
        }

        void LargeBtn_Click(object sender, EventArgs e)
        {
            if (itemToCustomize is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Large;
                if (this.DataContext is Order order)
                {
                    order.Add(side);
                }
            }
            
        }
    }
}
