using AnimeDownloaderLib.Model;
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
    public class SeasonItemsRepository : IItemRepository<ISeasonItem>
    {
        private IJsonPackerLogic _jsonPackerLogic;
        private string _path="";
        private ISeasonItem[] _items;
        public SeasonItemsRepository(IJsonPackerLogic jsonPackerLogic,string Path)
        {
            this._jsonPackerLogic = jsonPackerLogic;
            this._path = Path;
        }

        public int GetId()
        {
            return _items.Length + 1;
        }
        public ISeasonItem GetById(int id)
        {
            return _items.Where(x => x.Id == id).FirstOrDefault();
        }

        public ISeasonItem[] GetRangeByIds(int[] ids)
        {
            return _items.Where(x => ids.Contains(x.Id)).ToArray();
        }
        public ISeasonItem[] GetRange()
        {
            return _items.ToArray();
        }

        public void Fill(ISeasonItem[] inArray)
        {
            this._items = inArray;
        }

        public void Load()
        {
            if (_path != "")
            {
                if (File.Exists(_path))
                {
                    var text = File.ReadAllText(_path);

                    var dtoArray = JsonConvert.DeserializeObject<SeasonItemDto[]>(text);
                    if (dtoArray != null)
                    {
                        _items = dtoArray.Select(x => _jsonPackerLogic.MapFromDto<SeasonItem, SeasonItemDto>(x)).ToArray();
                        return;
                    }

                }
            }
            _items = new ISeasonItem[0];
        }


        public void Save()
        {
            if (_path != "")
            {
                File.Create(_path).Close();
                var dtoArray = _items.Select(x => _jsonPackerLogic.MapToDto<SeasonItemDto, SeasonItem>((SeasonItem)x)).ToArray();

                var text=JsonConvert.SerializeObject(dtoArray);
                File.WriteAllText(_path, text);
            }
        }

        public void Update(ISeasonItem[] array)
        {
            _items = array;
        }
    }
}
