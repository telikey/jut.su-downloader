using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommands
{
    public class AllCommands
    {
        [GetCommandMethod]
        private ICommand button1_Command()
        {
            return new RelayCommand((x) => { 
            
            });
        }
    }
}
