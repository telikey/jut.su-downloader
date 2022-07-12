using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using JSONPacker;
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
    public class MainWindowVM
    {
        private MainWindowCommands _mainWindowCommands = null;
        public MainWindowCommands MainWindowCommands { get => _mainWindowCommands; }

        public MainWindowVM(MainWindowCommands commands, Repositories repositories)
        {
            this._mainWindowCommands = commands;

            _animeItems = new ObservableCollection<IAnimeItem>(repositories.AnimeItemsRepository.GetRange());
        }

        private ObservableCollection<IAnimeItem> _animeItems = null;
        public ObservableCollection<IAnimeItem> AnimeItems { get => _animeItems; }

    }
}
