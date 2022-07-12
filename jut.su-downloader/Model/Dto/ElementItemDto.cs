using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.Dto
{
    public class ElementItemDto
    {
        public int Id = 0;

        public string Title = "";

        public string Path = "";

        public int Order = 0;

        public bool CanDownload = false;

        public string DownloadPath = "";
    }
}
