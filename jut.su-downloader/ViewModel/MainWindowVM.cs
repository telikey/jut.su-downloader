using JSONPacker;
using jut.su_downloader.Logic;
using jut.su_downloader.Logic.Downloader;
using jut.su_downloader.Model.Dto;
using jut.su_downloader.Model.ModelRepository.Items;
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

        public MainWindowVM(IDownloaderLogic IDownloaderLogic,MainWindowCommands commands,IJsonPackerLogic _packerLogic)
        {
            this._iDownloaderLogic = IDownloaderLogic;
            this._mainWindowCommands= commands;

            var item = new AnimeItem();
            item.Title = "some";
            item.Id = 1;
            item.Path = "100";
            var text=_packerLogic.Pack<AnimeItem,AnimeItemDto>(item);

            var obj=_packerLogic.UnPack<AnimeItem,AnimeItemDto>(text);
        }
    }
}
