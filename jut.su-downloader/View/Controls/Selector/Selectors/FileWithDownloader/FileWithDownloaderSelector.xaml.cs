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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jut.su_downloader.View.Controls.Selector.Selectors.FileWithDownloader
{
    /// <summary>
    /// Interaction logic for FileWthDownloaderSelector.xaml
    /// </summary>
    public partial class FileWithDownloaderSelector : UserControl
    {
        public IFileWithDownloaderValue Value
        {
            get { return (IFileWithDownloaderValue)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static readonly DependencyProperty ValueProperty =
              DependencyProperty.Register(
                  "Value",
                  typeof(IFileWithDownloaderValue),
                  typeof(FileWithDownloaderSelector),
                  new PropertyMetadata(null));

        public FileWithDownloaderSelector()
        {
            InitializeComponent();
        }
    }
}
