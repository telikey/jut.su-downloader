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
    public class AnimePageVM
    {
        private AnimePageCommands _animePageCommands = null;
        public AnimePageCommands AnimePageCommands { get => _animePageCommands; }

        public AnimePageVM(AnimePageCommands commands, Repositories repositories)
        {
            this._animePageCommands = commands;

            _animeItems = new ObservableCollection<IAnimeItem>();
            for (int i = 0; i < 80; i++)
            {
                _animeItems.Add(new AnimeItem() { Title = "Наруто", ImageURI = "https://static.insales-cdn.com/images/products/1/3690/548621930/abystyle-abydco761-naruto-group-poster-61x91-5cm.jpg" });
            }
            for (int i = 0; i < 80; i++)
            {
                _animeItems.Add(new AnimeItem() { Title = "Наруто 2", ImageURI = "https://static.insales-cdn.com/images/products/1/3690/548621930/abystyle-abydco761-naruto-group-poster-61x91-5cm.jpg" });
            }

            //animeDownloader.Init();
            //var items = animeDownloader.FillAnime(1, 2);

            //_animeItems = new ObservableCollection<IAnimeItem>(items);
        }

        private ObservableCollection<IAnimeItem> _animeItems = null;
        public ObservableCollection<IAnimeItem> AnimeItems { get => _animeItems; }

    }
}
