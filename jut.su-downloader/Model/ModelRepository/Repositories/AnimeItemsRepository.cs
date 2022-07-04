using JSONPacker;
using jut.su_downloader.Model.Dto;
using jut.su_downloader.Model.ModelRepository.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Repositories
{
    public class AnimeItemsRepository : IItemRepository<AnimeItem>
    {
        private IJsonPackerLogic _jsonPackerLogic;
        private string _path="";
        private AnimeItem[] _items;
        public AnimeItemsRepository(IJsonPackerLogic jsonPackerLogic,string Path)
        {
            this._jsonPackerLogic = jsonPackerLogic;
        }

        public AnimeItem GetById(int id)
        {
            return _items.Where(x => x.Id == id).FirstOrDefault();
        }

        public AnimeItem[] GetRangeByIds(int[] ids)
        {
            return _items.Where(x => ids.Contains(x.Id)).ToArray();
        }
        public AnimeItem[] GetRange()
        {
            return _items.ToArray();
        }

        public void Load()
        {
            if (_path != "")
            {
                if (File.Exists(_path))
                {
                    var text=File.ReadAllText(_path);

                    var dtoArray=JsonConvert.DeserializeObject<AnimeItemDto[]>(text);
                    _items = dtoArray.Select(x=>_jsonPackerLogic.MapFromDto<AnimeItem,AnimeItemDto>(x)).ToArray();

                }
            }
            else
            {
                _items= new AnimeItem[0];
            }
        }

        public void Save()
        {
            if (_path != "")
            {
                File.Create(_path).Close();
                var dtoArray = _items.Select(x => _jsonPackerLogic.MapToDto<AnimeItemDto, AnimeItem>(x)).ToArray();

                var text=JsonConvert.SerializeObject(dtoArray);
                File.WriteAllText(_path, text);
            }
        }

        public void Update(AnimeItem[] array)
        {
            _items = array;
        }
    }
}
