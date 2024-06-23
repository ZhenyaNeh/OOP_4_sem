using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace laba_7
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand CustomCommand =
            new RoutedUICommand("Custom Command", "CustomCommand", typeof(CustomCommands));
    }
}
