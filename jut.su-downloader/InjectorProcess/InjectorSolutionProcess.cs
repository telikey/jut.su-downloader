using jut.su_downloader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInjector;
using WPFCommands;
using System.Windows.Input;
using JSONPacker;
using jut.su_downloader.Model.ModelRepository.Repositories;
using jut.su_downloader.Model.ModelRepository.Items;
using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using jut.su_downloader.Logic.Commands;
using jut.su_downloader.View.Controls.Selector.Selectors.FileWithDownloader;
using jut.su_downloader.View.Controls.Selector.Selectors.File;

namespace jut.su_downloader.InjectorProcess
{
    public class InjectorSolutionProcess
    {
        public static void Fill()
        {
            //Items
            Injector.Add<IAnimeItem, AnimeItem>(null, false);
            Injector.Add<ISeasonItem, SeasonItem>(null, false);
            Injector.Add<IElementItem, ElementItem>(null, false);

            //Selector
            Injector.Add<IFileWithDownloaderValue, FileWithDownloaderValue>(null, false);
            Injector.Add<IFolderValue, FolderValue>(null, false);

            //Commands
            Injector.Add<AnimePageCommands, AnimePageCommands>(null, true);
            Injector.Add<NavigationPageCommands, NavigationPageCommands>(null, true);
            Injector.Add<SettingsPageCommands, SettingsPageCommands>(null, true);

            //CommandLogic
            Injector.Add<ICommandLogic<ICommand, AnimePageCommands>, CommandLogic<ICommand, AnimePageCommands>>(null, true);
            Injector.Add<ICommandLogic<ICommand, NavigationPageCommands>, CommandLogic<ICommand, NavigationPageCommands>>(null, true);
            Injector.Add<ICommandLogic<ICommand, SettingsPageCommands>, CommandLogic<ICommand, SettingsPageCommands>>(null, true);

            //DownloaderLogic
            Injector.Add<IAnimeDownloaderLogic, Jut_su_downloader_Logic>(null, true);

            //JsonPacker
            Injector.Add<IJsonPackerLogic, JsonPackerLogic>(new object[]
            {
                "_",
                ""
            }, true);

            //Repositories
            Injector.Add<IItemRepository<IElementItem>, ElementItemsRepository>(new object[]
            {
                "C:\\temp\\downloader\\ElementItems.txt"
            }, true);
            Injector.Add<IItemRepository<ISeasonItem>, SeasonItemsRepository>(new object[]
            {
                "C:\\temp\\downloader\\SeasonItems.txt"
            }, true);
            Injector.Add<IItemRepository<IAnimeItem>, AnimeItemsRepository>(new object[]
            {
                "C:\\temp\\downloader\\AnimeItems.txt"
            }, true);
            Injector.Add<Repositories, Repositories>(null, true);

            //MainWindowVM
            Injector.Add<AnimePageVM, AnimePageVM>(null, true);
            Injector.Add<NavigationPageVM, NavigationPageVM>(null, true);
            Injector.Add<SettingsPageVM, SettingsPageVM>(null, true);
        }
    }
}
