using ClassInjector;
using jut.su_downloader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommands
{
    public class MainWindowCommands: IFromObjectForCommandLogic
    {
        [GetCommandMethod]
        private ICommand button1_Command()
        {
            return new RelayCommand((x) => {
                var mainWindowVM=Injector.GetObject<MainWindowVM>();
            });
        }
    }
}
