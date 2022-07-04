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
        public IItemRepository<AnimeItem> AnimeItemsRepository { get; set; }
        public IItemRepository<SeasonItem> SeasonItemsRepository { get; set; }
        public IItemRepository<ElementItem> ElementItemsRepository { get; set; }
        public Repositories(
            IItemRepository<AnimeItem> animeItemsReportsitory,
            IItemRepository<SeasonItem> seasonItemsRepository,
            IItemRepository<ElementItem> elementItemsRepository)
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
    }
}
