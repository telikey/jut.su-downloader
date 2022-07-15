using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.View.Controls.Selector.Selectors.File
{
    public interface IFolderValue
    {
        string Label { get; set; }
        string FolderName { get; set; }
    }
    public class FolderValue : IFolderValue
    {
        public string Label { get; set; }
        public string FolderName { get; set; }
    }
}
