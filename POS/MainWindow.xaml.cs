/*
 * MainWindow.xaml.cs
 * Author:Regan Hale
 * Purpose: Defines behavior for the main window which contains the OrderControl for the CowboyCafe POS
 */

using System.Windows;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //ALWAYS leave this in place. Draws from xaml file to render content
        }
    }
}
