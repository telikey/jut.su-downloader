using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Repositories
{
    public interface IItemRepository<TItem>
    {
        public int GetId();
        TItem GetById(int id);
        TItem[] GetRangeByIds(int[] ids);
        TItem[] GetRange();
        void Fill(TItem[] inArray);

        void Update(TItem[] array);

        void Save();
        void Load();
    }
}
