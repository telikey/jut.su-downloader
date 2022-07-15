using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using JSONPacker;
using jut.su_downloader.Logic.Commands;
using jut.su_downloader.Model.Dto;
using jut.su_downloader.Model.ModelRepository.Items;
using jut.su_downloader.Model.ModelRepository.Repositories;
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
    }
}
