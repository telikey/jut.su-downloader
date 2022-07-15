using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using ClassInjector;
using JSONPacker;
using jut.su_downloader.Logic.Commands;
using jut.su_downloader.Model.Dto;
using jut.su_downloader.Model.ModelRepository.Items;
using jut.su_downloader.Model.ModelRepository.Repositories;
using jut.su_downloader.View.Controls.Selector.Selectors.FileWithDownloader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCommands;

namespace jut.su_downloader.ViewModel
{
    public class SettingsPageVM
    {
        private SettingsPageCommands _settingsPageCommands = null;
        public SettingsPageCommands SettingsPageCommands { get => _settingsPageCommands; }

        public SettingsPageVM(SettingsPageCommands commands)
        {
            this._settingsPageCommands = commands;
        }

        IFileWithDownloaderValue _geckoDriverValue = GeckoDriverValueCreate();
        public IFileWithDownloaderValue GeckoDriverValue
        {
            get => _geckoDriverValue;
        }
        private static IFileWithDownloaderValue GeckoDriverValueCreate()
        {
            var result = Injector.GetObject<IFileWithDownloaderValue>();
            result.Label = "GeckoDriver Path:";
            result.FileName = "";
            result.DownloadPath = "https://github.com/mozilla/geckodriver/releases/download/v0.31.0/geckodriver-v0.31.0-win64.zip";
            return result;
        }
    }
}
