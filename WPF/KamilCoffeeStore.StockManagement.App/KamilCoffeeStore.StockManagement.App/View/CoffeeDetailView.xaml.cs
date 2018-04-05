using KamilCofeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace KamilCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : Window
    {
        public Coffee SelectedCoffee { get; set; }
        public CoffeeDetailView()
        {
            InitializeComponent();

            this.Loaded += CoffeeDetailView_Loaded;
        }

        void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadData();
            this.DataContext = SelectedCoffee;
        }

        private void SaveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedCoffee.CoffeeName = "SOmething Expensive";
            SelectedCoffee.Price = 1000;
        }

        //private void LoadData()
        //{
        //    CoffeeNameLabel.Content = SelectedCoffee.CoffeeName;


        //    BitmapImage img = new BitmapImage();
        //    img.BeginInit();
        //    img.UriSource = new Uri("/KamilCoffeeStore.StockManagement.App;component/Images/coffee" + SelectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
        //    img.EndInit();
        //    CoffeeImage.Source = img;
        //}
    }
}
