using jut.su_downloader.Logic;
using jut.su_downloader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInjector;
using jut.su_downloader.Logic.Downloader;
using WPFCommands;
using System.Windows.Input;

namespace jut.su_downloader.InjectorProcess
{
    public class InjectorSolutionProcess
    {
        public static void Fill()
        {
            //Commands
            Injector.Add<MainWindowCommands, MainWindowCommands>(null, true);

            //CommandLogic
            Injector.Add<ICommandLogic<ICommand,MainWindowCommands>, CommandLogic<ICommand,MainWindowCommands>>(new object[]
            {
                "Command"
            }, true);

            //DownloaderLogic
            Injector.Add<IDownloaderLogic, Jut_su_Logic>(null, true);

            //MainWindowVM
            Injector.Add<MainWindowVM, MainWindowVM>(null, true);

        }
    }
}
