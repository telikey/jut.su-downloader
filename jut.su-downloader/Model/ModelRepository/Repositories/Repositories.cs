using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using jut.su_downloader.Model.ModelRepository.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Repositories
{
    public class Repositories
    {
        public IItemRepository<AnimeDownloaderLib.Model.IAnimeItem> AnimeItemsRepository { get; set; }
        public IItemRepository<ISeasonItem> SeasonItemsRepository { get; set; }
        public IItemRepository<IElementItem> ElementItemsRepository { get; set; }

        private IDownloaderLogic<AnimeDownloaderLib.Model.IAnimeItem> _iDownloaderLogic = null;
        public Repositories(
            IItemRepository<AnimeDownloaderLib.Model.IAnimeItem> animeItemsReportsitory,
            IItemRepository<ISeasonItem> seasonItemsRepository,
            IItemRepository<IElementItem> elementItemsRepository,

            IDownloaderLogic<AnimeDownloaderLib.Model.IAnimeItem> IDownloaderLogic)
        {
            this.AnimeItemsRepository = animeItemsReportsitory;
            this.SeasonItemsRepository = seasonItemsRepository;
            this.ElementItemsRepository = elementItemsRepository;

            this.AnimeItemsRepository.Load();
            this.ElementItemsRepository.Load();
            this.SeasonItemsRepository.Load();

            this._iDownloaderLogic = IDownloaderLogic;
        }

        public void Fill(int NumberOfElements)
        {
            List<IAnimeItem> array = new List<IAnimeItem>();
            this._iDownloaderLogic.Fill(array, NumberOfElements);
            AnimeItemsRepository.Fill(array.ToArray());
            SeasonItemsRepository.Fill(array.SelectMany(x=>x.SeasonsItems.ToArray()).Distinct().ToArray());
            ElementItemsRepository.Fill(array.SelectMany(x => x.SeasonsItems.ToArray()).Distinct().SelectMany(x=>x.ElementItems).Distinct().ToArray());
        }

        public void Save()
        {
            this.AnimeItemsRepository.Save();
            this.SeasonItemsRepository.Save();
            this.ElementItemsRepository.Save();
        }

        public void Load()
        {
            this.AnimeItemsRepository.Load();
            this.SeasonItemsRepository.Load();
            this.ElementItemsRepository.Load();
        }
    }
}
