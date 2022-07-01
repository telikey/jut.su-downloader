using jut.su_downloader.Logic;
using jut.su_downloader.Logic.Downloader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.ViewModel
{
    public class MainWindowVM
    {
        private IDownloaderLogic _iDownloaderLogic =null;

        public MainWindowVM(IDownloaderLogic IDownloaderLogic)
        {
            this._iDownloaderLogic = IDownloaderLogic;
        }
    }
}
