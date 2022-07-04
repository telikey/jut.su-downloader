using AnimeDownloaderLib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.ModelRepository.Items
{
    public class ElementItem : INotifyPropertyChanged,IElementItem
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
