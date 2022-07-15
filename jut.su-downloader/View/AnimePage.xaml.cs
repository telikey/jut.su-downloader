using ClassInjector;
using jut.su_downloader.ViewModel;
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

namespace jut.su_downloader.View
{
    /// <summary>
    /// Interaction logic for AnimePage.xaml
    /// </summary>
    public partial class AnimePage : Page
    {
        public AnimePage()
        {
            InitializeComponent();

            this.DataContext = Injector.GetObject<AnimePageVM>();
        }
    }
}
