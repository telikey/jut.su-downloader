using AnimeDownloaderLib;
using AnimeDownloaderLib.Model;
using ClassInjector;
using jut.su_downloader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFCommands;

namespace jut.su_downloader.Logic.Commands
{
    public class AnimePageCommands: IFromObjectForCommandLogic
    {
        //[GetCommandMethod]
        //private ICommand LoadAnime_Command()
        //{
        //    return new RelayCommand((x) =>
        //    {
        //        try
        //        {
        //            var animeCount = Convert.ToInt32(x);
        //            var mainWindowVM = Injector.GetObject<AnimePageVM>();
        //            var downloader = Injector.GetObject<IAnimeDownloaderLogic>();
        //            var lst=downloader.FillAnime(animeCount);
        //            mainWindowVM.AnimeItems.Clear();
        //            foreach(var item in lst)
        //            {
        //                mainWindowVM.AnimeItems.Add(item);
        //            }
        //        }
        //        catch { }
        //    });
        //}

        [GetCommandMethod]
        private ICommand LoadSeasons_Command()
        {
            return new RelayCommand((x) =>
            {
                if (x is IAnimeItem) {
                    var animeItem = x as IAnimeItem;
                    if (animeItem.SeasonsItems.Count == 0)
                    {
                        var downloader = Injector.GetObject<IAnimeDownloaderLogic>();
                        var lst = downloader.FillSeasons((new[] { animeItem }).ToList());
                        animeItem.SeasonsItems.Clear();
                        foreach (var item in lst)
                        {
                            animeItem.SeasonsItems.Add(item);
                        }
                    }
                }
            });
        }

        [GetCommandMethod]
        private ICommand LoadElements_Command()
        {
            return new RelayCommand((x) =>
            {
                if (x is ISeasonItem)
                {
                    var seasonItem = x as ISeasonItem;
                    if (seasonItem.ElementItems.Count == 0)
                    {
                        var downloader = Injector.GetObject<IAnimeDownloaderLogic>();
                        var lst = downloader.FillElements((new[] { seasonItem }).ToList());
                        seasonItem.ElementItems.Clear();
                        foreach (var item in lst)
                        {
                            seasonItem.ElementItems.Add(item);
                        }
                    }
                }
            });
        }
    }
}
