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
    public class SeasonItemsRepository : IItemRepository<SeasonItem>
    {
        private IJsonPackerLogic _jsonPackerLogic;
        private string _path="";
        private SeasonItem[] _items;
        public SeasonItemsRepository(IJsonPackerLogic jsonPackerLogic,string Path)
        {
            this._jsonPackerLogic = jsonPackerLogic;
        }

        public SeasonItem GetById(int id)
        {
            return _items.Where(x => x.Id == id).FirstOrDefault();
        }

        public SeasonItem[] GetRangeByIds(int[] ids)
        {
            return _items.Where(x => ids.Contains(x.Id)).ToArray();
        }
        public SeasonItem[] GetRange()
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

                    var dtoArray=JsonConvert.DeserializeObject<SeasonItemDto[]>(text);
                    _items = dtoArray.Select(x=>_jsonPackerLogic.MapFromDto<SeasonItem, SeasonItemDto>(x)).ToArray();

                }
            }
            else
            {
                _items= new SeasonItem[0];
            }
        }

        public void Save()
        {
            if (_path != "")
            {
                File.Create(_path).Close();
                var dtoArray = _items.Select(x => _jsonPackerLogic.MapToDto<SeasonItemDto, SeasonItem>(x)).ToArray();

                var text=JsonConvert.SerializeObject(dtoArray);
                File.WriteAllText(_path, text);
            }
        }

        public void Update(SeasonItem[] array)
        {
            _items = array;
        }
    }
}
