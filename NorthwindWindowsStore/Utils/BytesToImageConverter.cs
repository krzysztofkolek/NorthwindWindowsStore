namespace NorthwindWindowsStore.Utils
{
    using System;
    using System.IO;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media.Imaging;

    public class BytesToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value != null && value is byte[])
            {
                byte[] bytes = value as byte[];
                IRandomAccessStream stream = new MemoryStream(bytes) as IRandomAccessStream;
                BitmapImage image = new BitmapImage();

                image.SetSource(stream);

                return image;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
