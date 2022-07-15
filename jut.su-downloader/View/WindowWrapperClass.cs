using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace jut.su_downloader.View
{
    public partial class WindowWrapperClass
    {
        public void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window).Close();
        }

        public void MaxButtonClick(object sender, RoutedEventArgs e)
        {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState = (((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

        public void MinButtonClick(object sender, RoutedEventArgs e)
        {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState = WindowState.Minimized;
        }
    }
}
