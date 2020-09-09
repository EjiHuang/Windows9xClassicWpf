/*
 https://stackoverflow.com/questions/6558615/how-to-get-specific-icon-in-a-container-like-dll-in-xaml?answertab=active#tab-top
 */
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp
{
    [ValueConversion(typeof(string), typeof(ImageSource))]
    public class HabeasIcon : IValueConverter
    {
        [DllImport("shell32.dll")]
        private static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] fileName = ((string)parameter).Split('|');

            if (targetType != typeof(ImageSource))
                return Binding.DoNothing;

            IntPtr hIcon = ExtractIcon(Process.GetCurrentProcess().Handle, fileName[0], int.Parse(fileName[1]));

            ImageSource ret = Imaging.CreateBitmapSourceFromHIcon(hIcon, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            return ret;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        { throw new NotImplementedException(); }
    }
}
