using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Navigation;

namespace laba_4_5
{
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        public abstract void Execute(object? parameter, NavigationService? navigate);
        public abstract void Execute(string? searcch, string? filter, UniformGrid? prod, RoutedEventHandler? itemButtonClickHandler);

        public abstract void Execute(object? parameter);

        protected void OnCanExecuteChanged() 
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
