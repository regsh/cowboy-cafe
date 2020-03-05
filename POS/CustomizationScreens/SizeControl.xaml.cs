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
        CowboyCafe.Data.Size currentSize;
        
        public SizeControl()
        {
            InitializeComponent();
        }

        void SmallBtn_Click(object sender, EventArgs e)
        {
            SelectButton(SmallBtn);

        }

        void MediumBtn_Click(object sender, EventArgs e)
        {
            SelectButton(MediumBtn);
        }

        void LargeBtn_Click(object sender, EventArgs e)
        {
            SelectButton(LargeBtn);
        }

        void SelectButton(Button b)
        {
            SmallBtn.Background = default;
            MediumBtn.Background = default;
            LargeBtn.Background = default;
            b.Background = (Brush)Application.Current.Resources["Selected"];
        }
    }
}
