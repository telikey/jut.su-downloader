using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Model.Dto
{
    public class SeasonItemDto
    {
        public int Id = 0;

        public string Title = "";

        public string Path = "";

        public int[] ElementItems = new int[0];

        public int Order = 0;

        public bool IsFilms=false;
    }
}
