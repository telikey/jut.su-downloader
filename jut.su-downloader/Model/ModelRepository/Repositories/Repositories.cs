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

        public Repositories(
            IItemRepository<AnimeDownloaderLib.Model.IAnimeItem> animeItemsReportsitory,
            IItemRepository<ISeasonItem> seasonItemsRepository,
            IItemRepository<IElementItem> elementItemsRepository
            )
        {
            this.AnimeItemsRepository = animeItemsReportsitory;
            this.SeasonItemsRepository = seasonItemsRepository;
            this.ElementItemsRepository = elementItemsRepository;

            this.AnimeItemsRepository.Load();
            this.ElementItemsRepository.Load();
            this.SeasonItemsRepository.Load();
        }

        public void Save()
        {
            this.AnimeItemsRepository.Save();
            this.SeasonItemsRepository.Save();
            this.ElementItemsRepository.Save();
        }

        public void Load()
        {
            this.ElementItemsRepository.Load();
            this.SeasonItemsRepository.Load();
            this.AnimeItemsRepository.Load();
        }
    }
}
