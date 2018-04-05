using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace KamilCoffeeStore.StockManagement.App.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage img = new BitmapImage();
            var path = Path.Combine(Environment.CurrentDirectory, "Images", "coffee" + value + ".jpg");
            img.BeginInit();
            img.UriSource = new Uri("/KamilCoffeeStore.StockManagement.App;component/Images/coffee" + value + ".jpg", UriKind.RelativeOrAbsolute);
            img.EndInit();
            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
