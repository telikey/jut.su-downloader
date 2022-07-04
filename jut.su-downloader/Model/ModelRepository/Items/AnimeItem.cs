using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Items
{
    public class AnimeItem:INotifyPropertyChanged
    {
        private int _Id = 0;
        public int Id
        {
            get => _Id;
            set => SetField(ref _Id, value);
        }

        private string _Title = "";
        public string Title
        {
            get => _Title;
            set => SetField(ref _Title, value);
        }

        private string _Path = "";
        public string Path
        {
            get => _Path;
            set => SetField(ref _Path, value);
        }

        private int[] _SeasonsItems = new int[0];

        private ObservableCollection<SeasonItem> _SeasonsItems_Array = null;
        public ObservableCollection<SeasonItem> SeasonsItems
        {
            get 
            {
                if (_SeasonsItems_Array != null)
                {
                    return _SeasonsItems_Array;
                }
                else
                {
                    var repos=(Repositories.Repositories)ClassInjector.Injector.GetObject(typeof(Repositories.Repositories));
                    _SeasonsItems_Array=new ObservableCollection<SeasonItem>(repos.SeasonItemsRepository.GetRangeByIds(_SeasonsItems));
                    return _SeasonsItems_Array;
                }
            }
            set
            {
                _SeasonsItems_Array = value;
                _SeasonsItems = value.Select(x=>x.Id).ToArray();
                var repos = (Repositories.Repositories)ClassInjector.Injector.GetObject(typeof(Repositories.Repositories));
                repos.SeasonItemsRepository.Update(value.ToArray());
            }
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
