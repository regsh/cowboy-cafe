using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CowboyCafe.Data;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for SizeControl.xaml
    /// </summary>
    public partial class SizeControl : UserControl
    {
        //Data context for this will be set in MenuItemSelectionControl
        //to be an IOrderItem that requires a size (i.e. side or drink)
        public SizeControl()
        {
            InitializeComponent();
        }

    }
}
