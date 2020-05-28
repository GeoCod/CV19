using System;
using System.Windows.Input;

namespace CV19.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        /// <summary>Событие когда команда меняет состояние</summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>Проверяет можно или нельзя выполнять коммандну</summary>
        /// <param name="parameter"></param>
        public abstract bool CanExecute(object parameter);

        /// <summary>То, что должно быть выоплнено коммандой</summary>
        /// <param name="parameter"></param>
        public abstract void Execute(object parameter);
    }
}
