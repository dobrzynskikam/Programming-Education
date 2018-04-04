using KamilCofeeStore.StockManagement.Model;
using KamilCoffeeStore.StockManagement.App.Services;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace KamilCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView
    {
        private Coffee selectedCoffee;
        public CoffeeOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            IDataService coffeeDataService = new CoffeeDataService();
            CoffeeListView.ItemsSource = coffeeDataService.GetAllCoffees();
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCoffee = e.AddedItems[0] as Coffee;

            if (selectedCoffee != null)
            {
                CoffeeIdLabel.Content = selectedCoffee.CoffeeId;
                CoffeeNameLabel.Content = selectedCoffee.CoffeeName;
                CoffeeDescriptionLabel.Content = selectedCoffee.Description;
                CoffeePriceLabel.Content = selectedCoffee.Price;

                BitmapImage img = new BitmapImage();
                var path = Path.Combine(Environment.CurrentDirectory, "Images", "coffee" + selectedCoffee.CoffeeId + ".jpg");
                img.BeginInit();
                img.UriSource =new Uri("/KamilCoffeeStore.StockManagement.App;component/Images/coffee" + selectedCoffee.CoffeeId + ".jpg", UriKind.RelativeOrAbsolute);
                img.EndInit();

                CoffeeImage.Source = img;

                EditCofeeButton.Visibility = Visibility.Visible;
            }
        }

        private void EditCofeeButton_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView coffeDetailView = new CoffeeDetailView();
            coffeDetailView.SelectedCoffee = selectedCoffee;
            coffeDetailView.ShowDialog();
        }
    }
}
