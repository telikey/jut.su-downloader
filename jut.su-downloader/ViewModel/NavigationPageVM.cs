using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using JSONPacker;
using jut.su_downloader.Logic.Commands;
using jut.su_downloader.Model.Dto;
using jut.su_downloader.Model.ModelRepository.Items;
using jut.su_downloader.Model.ModelRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCommands;

namespace jut.su_downloader.ViewModel
{
    public class NavigationPageVM
    {
        private NavigationPageCommands _navigationPageCommands = null;
        public NavigationPageCommands NavigationPageCommands { get => _navigationPageCommands; }

        public NavigationPageVM(NavigationPageCommands commands)
        {
            this._navigationPageCommands = commands;
        }
    }
}
