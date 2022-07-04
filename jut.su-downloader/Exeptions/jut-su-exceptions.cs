using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jut.su_downloader.Exeptions
{
    internal class jut_su_exceptions:Exception
    {
        public jut_su_exceptions(string message) : base("jut.su_downloader: "+message)
        {

        }
    }
}
