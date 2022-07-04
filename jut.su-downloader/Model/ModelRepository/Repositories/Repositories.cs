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
        public Repositories(
            IItemRepository<AnimeItem> animeReportsitory,
            IItemRepository<SeasonItem> seasonRepository)
        {
            this.AnimeItemsRepository = animeReportsitory;
            this.SeasonItemsRepository = seasonRepository;
        }
    }
}
