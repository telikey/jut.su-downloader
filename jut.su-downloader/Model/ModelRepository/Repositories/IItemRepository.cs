using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Repositories
{
    public interface IItemRepository<TItem>
    {
        TItem GetById(int id);
        TItem[] GetRangeByIds(int[] ids);
        TItem[] GetRange();

        void Update(TItem[] array);

        void Save();
        void Load();
    }
}
