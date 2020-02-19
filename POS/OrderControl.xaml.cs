using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;


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
            
        }

        private void AngryChickenOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CowboyCafe.Data.AngryChicken AC = new CowboyCafe.Data.AngryChicken();
            OrderListView.Items.Add(AC);
        }

        private void RustersRibsOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        private void CowpokeChiliOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            CowboyCafe.Data.CowpokeChili CC = new CowboyCafe.Data.CowpokeChili();
            OrderListView.Items.Add(CC);
        }

        private void ChiliCheeseFriesOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
    }
}
