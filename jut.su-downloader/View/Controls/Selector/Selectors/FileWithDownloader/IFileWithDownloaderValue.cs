using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.View.Controls.Selector.Selectors.FileWithDownloader
{
    public interface IFileWithDownloaderValue
    {
        string Label { get; set; }
        string FileName { get; set; }
        string DownloadPath { get; set; }
    }
    public class FileWithDownloaderValue : IFileWithDownloaderValue
    {
        public string Label { get; set; }
        public string FileName { get; set; }
        public string DownloadPath { get; set; }
    }
}
