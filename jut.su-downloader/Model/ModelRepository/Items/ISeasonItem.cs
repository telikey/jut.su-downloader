using AnimeDownloaderLib.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Items
{
    public class SeasonItem : INotifyPropertyChanged,ISeasonItem
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

        private int _Order = 0;
        public int Order
        {
            get => _Order;
            set => SetField(ref _Order, value);
        }

        private bool _IsFilms = false;
        public bool IsFilms
        {
            get => _IsFilms;
            set => SetField(ref _IsFilms, value);
        }

        private int[] _ElementItems = new int[0];

        private ObservableCollection<IElementItem> _ElementItems_Array = null;
        public ObservableCollection<IElementItem> ElementItems
        {
            get
            {
                if (_ElementItems_Array != null)
                {
                    return _ElementItems_Array;
                }
                else
                {
                    var repos = (Repositories.Repositories)ClassInjector.Injector.GetObject(typeof(Repositories.Repositories));
                    _ElementItems_Array = new ObservableCollection<IElementItem>(repos.ElementItemsRepository.GetRangeByIds(_ElementItems));
                    return _ElementItems_Array;
                }
            }
            set
            {
                _ElementItems_Array = value;
                var repos = (Repositories.Repositories)ClassInjector.Injector.GetObject(typeof(Repositories.Repositories));
                repos.ElementItemsRepository.Update(_ElementItems_Array.Select(x => (IElementItem)x).ToArray());
                _ElementItems = _ElementItems_Array.Select(x => x.Id).ToArray();
            }
        }
        private void CollectionChangedMethod(object sender, NotifyCollectionChangedEventArgs e)
        {
            var repos = (Repositories.Repositories)ClassInjector.Injector.GetObject(typeof(Repositories.Repositories));
            repos.ElementItemsRepository.Update(_ElementItems_Array.Select(x=>(IElementItem)x).ToArray());
            _ElementItems = _ElementItems_Array.Select(x => x.Id).ToArray();
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
