using jut.su_downloader.Logic;
using jut.su_downloader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInjector;
using jut.su_downloader.Logic.Downloader;

namespace jut.su_downloader.InjectorProcess
{
    public class InjectorSolutionProcess
    {
        public static void Fill()
        {
            Injector.Add<IDownloaderLogic, Jut_su_Logic>(null,true);
            Injector.Add<MainWindowVM, MainWindowVM>(null, false);

        }
    }
}
