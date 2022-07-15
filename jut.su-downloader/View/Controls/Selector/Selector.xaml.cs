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

namespace jut.su_downloader.View.Controls.Selector
{
    public enum SelectorType
    {
        Text = 0,
        File = 1,
        FileWithDownloader = 2,
    }
    /// <summary>
    /// Interaction logic for Selector.xaml
    /// </summary>
    public partial class Selector : UserControl
    {
        public SelectorType Type
        {
            get { return (SelectorType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        public static readonly DependencyProperty TypeProperty =
              DependencyProperty.Register(
                  "Type", 
                  typeof(SelectorType), 
                  typeof(Selector), 
                  new PropertyMetadata(SelectorType.Text));

        public object Value
        {
            get { return (object)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static readonly DependencyProperty ValueProperty =
              DependencyProperty.Register(
                  "Value",
                  typeof(object),
                  typeof(Selector),
                  new PropertyMetadata(null));


        public Selector()
        {
            InitializeComponent();
        }
    }
}
