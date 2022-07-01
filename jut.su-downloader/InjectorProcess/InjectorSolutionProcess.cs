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
            //MainWindowVM
            Injector.Add<AllCommands, AllCommands>(null, true);
            Injector.Add<ICommandLogic<ICommand>, CommandLogic<ICommand>>(new object[]
            {
                Injector.GetObject<AllCommands>(),
                "Command"
            }, true);
            Injector.Add<IDownloaderLogic, Jut_su_Logic>(null,true);
            Injector.Add<MainWindowVM, MainWindowVM>(null, false);

            //

        }
    }
}
