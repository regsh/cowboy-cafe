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
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SizeSelection.xaml
    /// </summary>
    public partial class SizeSelection : Window
    {
        public SizeSelection()
        {
            InitializeComponent();
        }
        public void SmallBtn_Click(object sender, EventArgs e)
        {
            //add small size of previously selected item
        }

        public void MediumBtn_Click(object sender, EventArgs e)
        {
            //add medium size of previously selected itme
        }

        public void LargeBtn_Click(object sender, EventArgs e)
        {
            //add large size of previously selected item
        }

    }
}
