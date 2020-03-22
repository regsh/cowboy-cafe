/*
 * SizeControl.xaml.cs
 * Author:Regan Hale
 * Purpose: Interaction logic for the SizeControl user control
 */
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
            UpdateSizeDisplay();
            
        }
        /// <summary>
        /// Changes Radio button display so appropriate button is checked according to size of IOrderItem
        /// </summary>
        private void UpdateSizeDisplay()
        {
            CowboyCafe.Data.Size size = CowboyCafe.Data.Size.Small;
            if(DataContext is Side side)
            {
                size = side.Size;
            }
            else if(DataContext is Drink drink)
            {
                size = drink.Size;
            }
            switch (size)
            {
                case CowboyCafe.Data.Size.Large:
                    LgRadioButton.IsChecked = true;
                    break;
                case CowboyCafe.Data.Size.Medium:
                    MedRadioButton.IsChecked = true;
                    break;
                case CowboyCafe.Data.Size.Small:
                    SmlRadioButton.IsChecked = true;
                    break;
                default:
                    break;
                    
            }
        }
        /// <summary>
        /// Updates the data context's object size based on selected radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateObjectSize(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton rb)
            {
                string name = rb.Name;
                switch (name)
                {
                    case "SmlRadioButton":
                        ChangeSize(CowboyCafe.Data.Size.Small);
                        break;
                    case "MedRadioButton":
                        ChangeSize(CowboyCafe.Data.Size.Medium);
                        break;
                    case "LgRadioButton":
                        ChangeSize(CowboyCafe.Data.Size.Large);
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Changes the size of DataContext object if that object is a Side or Drink
        /// </summary>
        /// <param name="size">Size to change IOrderItem's size to</param>
        private void ChangeSize(CowboyCafe.Data.Size size)
        {
            if(DataContext is Side side)
            {
                side.Size = size;
            }
            else if(DataContext is Drink drink)
            {
                drink.Size = size;
            }
        }
    }
}
