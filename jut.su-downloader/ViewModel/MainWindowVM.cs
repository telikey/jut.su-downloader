using jut.su_downloader.Logic;
using jut.su_downloader.Logic.Downloader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCommands;

namespace jut.su_downloader.ViewModel
{
    public class MainWindowVM
    {
        private IDownloaderLogic _iDownloaderLogic =null;
        private MainWindowCommands _mainWindowCommands = null;
        public MainWindowCommands MainWindowCommands { get => _mainWindowCommands; }

        public MainWindowVM(IDownloaderLogic IDownloaderLogic,MainWindowCommands commands)
        {
            this._iDownloaderLogic = IDownloaderLogic;
            this._mainWindowCommands= commands;
        }
    }
}
