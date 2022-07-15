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
using Microsoft.Windows;

namespace jut.su_downloader.View
{
    /// <summary>
    /// Логика взаимодействия для WindowWrapper.xaml
    /// </summary>
    public partial class WindowWrapper : Window
    {
        public WindowWrapper()
        {
            InitializeComponent();
        }

        public void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void MaxButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }
        public void MinButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }
    }
}
