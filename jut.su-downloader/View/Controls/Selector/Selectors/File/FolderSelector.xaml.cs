using jut.su_downloader.View.Controls.Selector.Selectors.File;
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

namespace jut.su_downloader.View.Controls.Selector.Selectors.File
{
    /// <summary>
    /// Interaction logic for FileWthDownloaderSelector.xaml
    /// </summary>
    public partial class FolderSelector : UserControl
    {
        public IFolderValue Value
        {
            get { return (IFolderValue)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static readonly DependencyProperty ValueProperty =
              DependencyProperty.Register(
                  "Value",
                  typeof(IFolderValue),
                  typeof(FolderSelector),
                  new PropertyMetadata(null));

        public FolderSelector()
        {
            InitializeComponent();
        }
    }
}
