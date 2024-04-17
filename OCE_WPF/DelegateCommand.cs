using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OCE_WPF
{
    class DelegateCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action<object?> _execute;
        private readonly Predicate<object?> _canExecute;

        public DelegateCommand(Action<object?> execute, Predicate<object?> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute(parameter);
        }
    }
}
