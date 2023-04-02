using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DeskoptStyle.Command.Commandbt
{
    internal class RelayCommandbt : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Action<object?> _execute;
        public Predicate<object?> _canexecute;

        public RelayCommandbt(Action<object?> execute, Predicate<object?>? canexecute = null)
        {
            ArgumentNullException.ThrowIfNull(execute, nameof(execute));
            _execute = execute;
            _canexecute = canexecute;
        }

        public void Execute(object? parameter) => _execute?.Invoke(parameter);
        public bool CanExecute(object? parameter) => _canexecute is null || _canexecute.Invoke(parameter);
    }
}
